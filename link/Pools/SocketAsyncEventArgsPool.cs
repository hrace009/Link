using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Collections.Concurrent;

namespace Link.Pools
{
    using SocketAsyncEventArgsPoolInstance = Link.Pools.PoolInstance<SocketAsyncEventArgsPool, SocketAsyncEventArgs>;
    public class SocketAsyncEventArgsPool : StackPool<SocketAsyncEventArgs>
    {
        public const int DefaultBufferSize = 4096;

        public static readonly SocketAsyncEventArgsPoolInstance SendInstance = new SocketAsyncEventArgsPoolInstance(new SocketAsyncEventArgsPool());
        public static readonly SocketAsyncEventArgsPoolInstance ReceiveInstance = new SocketAsyncEventArgsPoolInstance(new SocketAsyncEventArgsPool());

        public BufferPool BufferPool { get; private set; }
        public SocketAsyncEventArgsPool(BufferPool bufferPool = null, int bufferSize = DefaultBufferSize, bool fixedBufferSize = false)
        {
            if (bufferPool == null)
            {
                bufferPool = new BufferPool(bufferSize, fixedBufferSize);
            }
            BufferPool = bufferPool;
        }

        public override bool Return(SocketAsyncEventArgs item, bool force)
        {
            if ((item?.Buffer?.Length ?? 0) > 0 && item.Count > 0)
            {
                BufferPool.Return(item.Buffer, item.Offset, item.Count);
            }
            Reset(item);
            Cleanup(item);
            return false;
        }
        public override SocketAsyncEventArgs Take()
        {
            var result = new SocketAsyncEventArgs();
            if (BufferPool.DefaultSize > 0)
            {
                var buffer = BufferPool.Take();
                result.SetBuffer(buffer.Array, buffer.Offset, buffer.Count);
            }
            
            return result;
        }
        public override SocketAsyncEventArgs Create()
        {
            var result = new SocketAsyncEventArgs();
            if (BufferPool.DefaultSize > 0)
            {
                var buffer = BufferPool.Create();
                result.SetBuffer(buffer.Array, buffer.Offset, buffer.Count);
            }
            return result;
        }
        public override void Reset(SocketAsyncEventArgs item)
        {
            if (item == null)
            {
                return;
            }
            item.BufferList?.Clear();
            Socket socket = item.AcceptSocket;
            if (socket != null)
            {
                item.AcceptSocket = null;

                try
                {
                    socket.Dispose();
                }
                catch 
                {
                    
                }
            }
        }
        public override void Cleanup(SocketAsyncEventArgs item)
        {
            item.Dispose();
        }
    }
}