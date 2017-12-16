using System;

namespace Link.Net
{
    public class PacketPolicy
    {
        private static PacketPolicy defaultPolicy = new PacketPolicy();
        public static PacketPolicy AllAcceptPolicy
        {
            get 
            {
                return defaultPolicy;
            }
        }

        public virtual PacketPolicyState CheckId(uint packetId)
        {
            return PacketPolicyState.Accept;
        }
        public virtual PacketPolicyState CheckLength(uint packetId, uint packetLength)
        {
            return PacketPolicyState.Accept;
        }
        public virtual PacketPolicyState CheckPacket(Packet packet)
        {
            return PacketPolicyState.Accept;
        }
    }
}

