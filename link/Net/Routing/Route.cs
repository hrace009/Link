using System;
using Link.IO;
using Link.Pools;

namespace Link.Net
{
    public abstract class Route
    {
        public virtual bool Send(uint packetId, IDataSerializer packet)
        {
            var ds = DataStreamPool.Instance.Take();
            var pck = new Packet(packetId, ds);
            pck.WritePacket(packet);
            bool res = Send(pck);
            DataStreamPool.Instance.Return(ds);
            return res;
        }
        public virtual bool Send(uint packetId, DataStream packetStream)
        {
            return Send(new Packet(packetId, packetStream));
        }
        public abstract bool Send(Packet packet);
    }
}

