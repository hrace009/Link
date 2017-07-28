using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.IO;
using Link.IO;
using Link.Pools;

namespace Link.Net
{
    public class SocketConnection : Connection
    {
        public Socket BaseSocket { get; private set; }
        public SocketAsyncEventArgs SocketReceiveArgs { get; private set; }
        public SocketAsyncEventArgs SocketSendArgs { get; private set; }

        private IPool<SocketAsyncEventArgs> ReceivePool { get; }
        private IPool<SocketAsyncEventArgs> SendPool { get; }

        public SocketConnection(Socket socket, IPool<SocketAsyncEventArgs> receivePool, IPool<SocketAsyncEventArgs> sendPool)
        {
            BaseSocket = socket;

            SendPool = sendPool;
            ReceivePool = receivePool;

            SocketReceiveArgs = receivePool.Take();
            SocketSendArgs = sendPool.Take();

            SocketReceiveArgs.Completed += socketArgsRecv_Completed;
            SocketSendArgs.Completed += socketArgsSend_Completed;
        }
        public SocketConnection(Socket socket) : this(
            socket,
            SocketAsyncEventArgsPool.ReceiveInstance,
            SocketAsyncEventArgsPool.SendInstance)
        {
        }
        public SocketConnection(SocketType socketType, ProtocolType protocolType) : this(new Socket(socketType, protocolType))
        {
        }
        public SocketConnection(AddressFamily addressFamily, SocketType socketType, ProtocolType protocolType) : this(new Socket(addressFamily, socketType, protocolType))
        {
        }

        private object lckObject = new object();

        public override void Start()
        {
            lock (lckObject)
            {
                if (State == ConnectionState.Working)
                {
                    return;
                }
                State = ConnectionState.Working;
                StartReceive();
            }
        }
        public override void Stop()
        {
            lock (lckObject)
            {
                State = ConnectionState.NotWorking;
            }
        }
        public override void Close()
        {
            lock (lckObject)
            {
                try
                {
                    BaseSocket.Shutdown(SocketShutdown.Both);
                }
                catch
                {
                }
                try
                {
                    BaseSocket.Dispose();
                }
                catch
                {
                }
                State = ConnectionState.Closed;
                SocketReceiveArgs.Completed -= socketArgsRecv_Completed;
                SocketSendArgs.Completed -= socketArgsSend_Completed;
                ReceivePool.Return(SocketReceiveArgs);
                SendPool.Return(SocketSendArgs);
            }
        }
        protected override bool ProcessSend(byte[] buffer, int offset, int length)
        {
            return StartSend(buffer, offset, length);
        }

        private void StartReceive()
        {
            if (State != ConnectionState.Working)
            {
                return;
            }
            try
            {
                if (!BaseSocket.ReceiveAsync(SocketReceiveArgs))
                {
                    ReceiveProcess(SocketReceiveArgs);
                }
            }
            catch
            {
                Close();
            }
        }
        private bool StartSend(byte[] buffer, int offset, int count)
        {
            if (State != ConnectionState.Working)
            {
                return false;
            }
            //SocketSendArgs.SetBuffer(buffer, offset, count); // CHECK SendPool.Free if change
            try
            {
                var len = BaseSocket.Send(buffer, offset, count, SocketFlags.None, out SocketError errorCode);
                if (len == 0 || errorCode != SocketError.Success)
                {
                    Close();
                }
                /*
                if (!BaseSocket.SendAsync(SocketSendArgs))
                {
                    SendProcess(SocketSendArgs);
                }*/
                return State != ConnectionState.Closed;
            }
            catch
            {
                Close();
                return false;
            }
        }
        private void socketArgsRecv_Completed(object sender, SocketAsyncEventArgs e)
        {
            ReceiveProcess(e);
        }
        private void socketArgsSend_Completed(object sender, SocketAsyncEventArgs e)
        {
            SendProcess(e);
        }
        private void ReceiveProcess(SocketAsyncEventArgs socketArgs)
        {
            try
            {
                if (socketArgs.SocketError != SocketError.Success ||
                    socketArgs.BytesTransferred <= 0)
                {
                    Close();
                    return;
                }
            }
            catch
            {
                Close();
                return;
            }
#if !DEBUG
            try
            {
#endif
            if (State != ConnectionState.Closed)
            {
                ProcessReceive(socketArgs.Buffer, socketArgs.Offset, socketArgs.BytesTransferred);
            }
            StartReceive();
#if !DEBUG
            }
            catch
            {
                Close();
                return;
            }
#endif
        }
        private void SendProcess(SocketAsyncEventArgs socketArgs)
        {
            try
            {
                if (socketArgs.SocketError != SocketError.Success ||
                    socketArgs.BytesTransferred <= 0)
                {
                    Close();
                    return;
                }
            }
            catch
            {
                Close();
            }
        }
    }
}
