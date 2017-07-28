using System;
using Link.IO;
using Link.Pools;

namespace Link.Net
{
    public class PacketWriter
    {
        private DataStream networkStream;
        private DataStream packetStream;

        public DataStream NetworkStream
        {
            get
            {
                return networkStream;
            }
        }
        public DataStream PacketStream
        {
            get
            {
                return packetStream;
            }
        }

        public PacketWriter(DataStream networkStream = null, DataStream packetStream = null)
        {
            if (networkStream == null)
            {
                networkStream = DataStreamPool.Instance.Take();
            }
            if (packetStream == null)
            {
                packetStream = DataStreamPool.Instance.Take();
            }

            this.networkStream = networkStream;
            this.packetStream = packetStream;
        }

        public void Clear()
        {
            networkStream.Clear();
        }

        public void Write(uint packetId, IDataSerializer packet)
        {
            packetStream.Clear();
            packetStream.Write(packet);
            Write(packetId, packetStream);
        }
        public void Write(Packet packet)
        {
            Write(packet.Id, packet.Stream);
        }
        public void Write(uint packetId, DataStream packetStream)
        {
            networkStream.WriteCompactUInt32(packetId);
            networkStream.WriteCompactUInt32(packetStream.Count);
            networkStream.PushBack(packetStream.Buffer, 0, packetStream.Count);
        }

        public ArraySegment<byte> GetBuffer()
        {
            return new ArraySegment<byte>(networkStream.Buffer, 0, networkStream.Count);
        }
    }
}

