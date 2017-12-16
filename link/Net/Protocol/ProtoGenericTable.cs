using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Link.IO;

namespace Link.Net.Protocol
{
    public class ProtoGenericTable<Proto, Packet> where Proto : ProtoTable where Packet : IDataSerializer
    {
        public static IPacketBuilder<Packet> Builder;
    }
    public abstract class ProtoGenericTable<Proto> : ProtoDictionaryTable where Proto : ProtoTable
    {
        public void Register<TBase, TPacket>(uint packetId, int maxSize = -1) where TPacket : TBase where TBase : IDataSerializer
        {
            Register<TBase, TPacket>(new PacketBaseInformation(packetId, maxSize));
        }
        public void Register<TBase, TPacket>(PacketBaseInformation information) where TPacket : TBase where TBase : IDataSerializer
        {
            var baseBuilder = new PacketBuilder<TBase>();
            var packetBuilder = new PacketBuilder<TPacket>();

            baseBuilder.Setup(information, () => Helpers.FastConstructor<TPacket>.Create());
            packetBuilder.Setup(information, Helpers.FastConstructor<TPacket>.Create);


            lock (lockObject)
            {
                ProtoGenericTable<Proto, TBase>.Builder = baseBuilder;
                ProtoGenericTable<Proto, TPacket>.Builder = packetBuilder;

                TypeTable[typeof(TBase)] = baseBuilder;
                TypeTable[typeof(TPacket)] = packetBuilder;
                IdTable[information.Id] = baseBuilder;
            }
        }
        public void Register<TBase, TStructure>() where TStructure : TBase where TBase : IDataSerializer
        {
            var baseBuilder = new PacketBuilder<TBase>();
            var structureBuilder = new PacketBuilder<TStructure>();

            baseBuilder.Setup(() => Helpers.FastConstructor<TStructure>.Create());
            structureBuilder.Setup(Helpers.FastConstructor<TStructure>.Create);

            lock (lockObject)
            {
                ProtoGenericTable<Proto, TBase>.Builder = baseBuilder;
                ProtoGenericTable<Proto, TStructure>.Builder = structureBuilder;

                TypeTable[typeof(TBase)] = baseBuilder;
                TypeTable[typeof(TStructure)] = structureBuilder;
            }
        }
        public override void Register<T>(IPacketBuilder<T> builder)
        {
            if (builder == null)
            {
                return;
            }
            ProtoGenericTable<Proto, T>.Builder = builder;
            Register(typeof(T), builder);
        }

        public override IPacketContainer<Packet> GetContainer<Packet>()
        {
            if (ProtoGenericTable<Proto, Packet>.Builder != null)
            {
                return ProtoGenericTable<Proto, Packet>.Builder.CreateContainer();
            }
            return null;
        }
        public override IPacketBuilder<Packet> GetBuilder<Packet>()
        {
            return ProtoGenericTable<Proto, Packet>.Builder;
        }
        public override PacketBaseInformation GetInfo<Packet>()
        {
            return ProtoGenericTable<Proto, Packet>.Builder?.Information;
        }
        public override PacketBaseInformation GetInfo<Packet>(Packet packet)
        {
            if (packet == null)
            {
                return GetInfo<Packet>();
            }
            else
            {
                return GetInfo(packet.GetType());
            }
        }
        public override Structure Get<Structure>()
        {
            return base.Get<Structure>();
        }
    }
}
