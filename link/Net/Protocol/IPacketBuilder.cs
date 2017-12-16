using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Link.IO;

namespace Link.Net.Protocol
{
    public class PacketBuilder<Packet> : IPacketBuilder<Packet> where Packet : IDataSerializer
    {
        public PacketBaseInformation Information { get; private set; }
        public Func<Packet> Constructor { get; private set; }


        public void Setup(PacketBaseInformation information)
        {
            Information = information;
        }
        public void Setup(Func<Packet> constructor)
        {
            Constructor = constructor;
        }
        public void Setup(PacketBaseInformation information, Func<Packet> constructor)
        {
            Information = information;
            Constructor = constructor;
        }

        public static PacketBuilder<Packet> CreateDefault(PacketBaseInformation information)
        {
            var result = new PacketBuilder<Packet>();
            result.Setup(information);
            result.Setup(Helpers.FastConstructor<Packet>.Create);
            return result;
        }

        public Packet Create()
        {
            return Constructor();
        }
        IDataSerializer IPacketBuilder.Create()
        {
            return Create();
        }

        public IPacketContainer<Packet> CreateContainer()
        {
            if (Information == null || Constructor == null)
            {
                return null;
            }
            return new PacketContainer<Packet>(Create(), Information);
        }

        IPacketContainer IPacketBuilder.CreateContainer()
        {
            return CreateContainer();
        }
    }
    public interface IPacketBuilder<Packet> : IPacketBuilder where Packet : IDataSerializer
    {
        new Packet Create();
        new IPacketContainer<Packet> CreateContainer();
    }
    public interface IPacketBuilder
    {
        PacketBaseInformation Information { get; }
        IDataSerializer Create();
        IPacketContainer CreateContainer();
    }
}
