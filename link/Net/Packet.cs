using System;
using Link.IO;

namespace Link.Net
{
    public class Packet
    {
        public UInt32 Id { get; private set; }
        public DataStream Stream { get; private set; }
        
        public Packet(UInt32 id, DataStream stream)
        {
            Id = id;
            Stream = stream;
        }

        public static Packet Create(uint id, DataStream stream)
        {
            return new Packet(id, stream);
        }
        public static Packet Create(uint id, IDataSerializer packet)
        {
            var result = new Packet(id, Pools.DataStreamPool.Instance.Take());
            result.WritePacket(packet);
            return result;
        }

        public virtual T ReadPacket<T>() where T : IDataSerializer
        {
            Stream.Reset();
            T result;
            TryReadPacket(out result);
            return result;
        }
        public virtual bool TryReadPacket<T>(out T result) where T : IDataSerializer
        {
            Stream.Reset();
            return Stream.TryRead(out result);
        }
        public virtual bool TryReadPacket(IDataSerializer packet)
        {
            Stream.Reset();
            return Stream.TryRead(packet);
        }
        public Packet WritePacket(IDataSerializer packet, bool saveUnread = false)
        {
            if (!saveUnread)
            {
                Stream.Clear();
                Stream.Write(packet);
            }
            else
            {
                Stream.Flush();
                var count = Stream.Count;
                Stream.Write(packet);
                Stream.PushBack(Stream.Buffer, 0, count);
                Stream.Position = count;
                Stream.Flush();
            }
            return this;
        }
    }
}

