using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Link.IO;

namespace Link.Net.Protocol
{
    public class PacketProto : Packet
    {
        public ProtoTable ProtoTable { get; private set; }
        public PacketProto(uint id, DataStream stream, ProtoTable proto) : base(id, stream)
        {
            ProtoTable = proto;
        }
        public override bool TryReadPacket<T>(out T result)
        {
            result = ProtoTable.Get<T>();
            if (result == null)
            {
                return base.TryReadPacket(out result);
            }
            return TryReadPacket(result);
        }
    }
}
