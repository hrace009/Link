using System;
using Link.IO;

namespace Link.Net.Protocol
{
    public class PacketContainer<T> : IPacketContainer<T> where T : IDataSerializer
    {
        public PacketBaseInformation Information { get; private set; }
        public T Packet { get; private set; }

        IDataSerializer IPacketContainer.Packet => Packet;

        public PacketContainer()
        {

        }
        public PacketContainer(T packet, PacketBaseInformation information)
        {
            Information = information;
            Packet = packet;
        }

        public static PacketContainer<T> Create<TNew>(PacketBaseInformation information) where TNew : T
        {
            return new PacketContainer<T>(Helpers.FastConstructor<TNew>.Create(), information);
        }
    }
    public class PacketContainer : IPacketContainer
    {
        public PacketBaseInformation Information { get; private set; }
        public IDataSerializer Packet { get; private set; }

        IDataSerializer IPacketContainer.Packet => Packet;

        public PacketContainer()
        {

        }
        public PacketContainer(IDataSerializer packet, PacketBaseInformation information)
        {
            Information = information;
            Packet = packet;
        }
    }
    public interface IPacketContainer<out T> : IPacketContainer where T : IDataSerializer
    {
        new T Packet { get; }
    }
    public interface IPacketContainer
    {
        PacketBaseInformation Information { get; }
        IDataSerializer Packet { get; }
    }
}

