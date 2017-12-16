using System;
using System.Net;
using System.Net.Sockets;
using Link.Pools;

namespace Link.Net
{
    public class TcpSocketOpener : IPassiveConnectionFactory
    {
        public ServerInfo ServerInfo { get; set; }
        public IPool<SocketAsyncEventArgs> SocketAsyncEventArgsReceivePool { get; set; }
        public IPool<SocketAsyncEventArgs> SocketAsyncEventArgsSendPool { get; set; }

        public TcpSocketOpener() : this(ServerInfo.Local)
        {
        }
        public TcpSocketOpener(string server) : this(ServerInfo.Parse(server))
        {
        }
        public TcpSocketOpener(string host, int port) : this(new ServerInfo(host, port))
        {
        }
        public TcpSocketOpener(string name, string host, int port) : this(new ServerInfo(host, port, name))
        {
        }
        public TcpSocketOpener(ServerInfo serverInfo)
        {
            ServerInfo = serverInfo;

            SocketAsyncEventArgsReceivePool = SocketAsyncEventArgsPool.ReceiveInstance;
            SocketAsyncEventArgsSendPool = SocketAsyncEventArgsPool.SendInstance;
        }

        public Connection Take()
        {
            var socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            socket.Connect(ServerInfo.Host, ServerInfo.Port);
            return new SocketConnection(socket);
        }
        public void Free(Connection connection)
        {
            connection?.Close();
        }
    }
}

