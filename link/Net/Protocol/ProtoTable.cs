using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Link.IO;

namespace Link.Net.Protocol
{
    public abstract class ProtoTable
    {
        public virtual PacketBaseInformation GetInfo<Packet>() where Packet : IDataSerializer
        {
            return GetInfo(typeof(Packet));
        }
        public virtual PacketBaseInformation GetInfo<Packet>(Packet packet) where Packet : IDataSerializer
        {
            if (packet == null)
            {
                return GetInfo(typeof(Packet));
            }
            else
            {
                return GetInfo(packet.GetType());
            }
        }
        public abstract PacketBaseInformation GetInfo(Type type);
        public abstract PacketBaseInformation GetInfo(uint packetId);

        public virtual IPacketBuilder<Packet> GetBuilder<Packet>() where Packet : IDataSerializer
        {
            var result = GetBuilder(typeof(Packet));
            if (result is IPacketBuilder<Packet>)
            {
                return (IPacketBuilder<Packet>)result;
            }
            else
            {
                return null;
            }
        }
        public abstract IPacketBuilder GetBuilder(Type type);
        public abstract IPacketBuilder GetBuilder(uint packetId);

        public virtual Structure Get<Structure>() where Structure : IDataSerializer
        {
            var result = Get(typeof(Structure));
            if (result is Structure)
            {
                return (Structure)result;
            }
            else
            {
                return default(Structure);
            }
        }
        public abstract IDataSerializer Get(Type type);


        public virtual IPacketContainer<Packet> GetContainer<Packet>() where Packet : IDataSerializer
        {
            var result = GetContainer(typeof(Packet));
            if (result is IPacketContainer<Packet>)
            {
                return (IPacketContainer<Packet>)result;
            }
            else
            {
                return null;
            }
        }
        public abstract IPacketContainer GetContainer(Type type);
        public abstract IPacketContainer GetContainer(uint packetId);
    }
}
