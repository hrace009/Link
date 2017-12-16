using System;
using Link.IO;

namespace Link.Net
{
    public class PacketEventArgs
    {
        public Packet Packet { get; set; }
        public RouteSession Chain { get; set; }
        public bool IsComplete { get; set; }
        public bool IsSended { get; set; }
        public PacketEventArgs()
        {
            
        }
        public PacketEventArgs(Packet packet, RouteSession chain, bool isComplete = false, bool isSended = false)
        {
            Packet = packet;
            Chain = chain;
            IsComplete = isComplete;
            IsSended = isSended;
        }

        public T Read<T>() where T : IDataSerializer
        {
            return Packet.ReadPacket<T>();
        }
        public void Write(IDataSerializer packet)
        {
            Packet.WritePacket(packet);
        }
    }
}

