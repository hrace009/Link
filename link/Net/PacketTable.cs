using System;
using System.Collections.Generic;
using Link.Net.Protocol;
using Link.IO;

namespace Link.Net
{
    public abstract class PacketTable<T, TI> where T : new()
    {
        public T Items { get; private set; }
        public Dictionary<uint, T> ItemsTable { get; private set; }

        public ProtoTable Proto { get; set; }

        public PacketTable()
        {
            Items = new T();
            ItemsTable = new Dictionary<uint, T>();
        }

        public T Get()
        {
            return Items;
        }
        public T Get<TPacket>() where TPacket : IDataSerializer
        {
            var info = Proto?.GetInfo<TPacket>();
            if (info == null)
            {
                if (default(T) == null)
                {
                    return default(T);
                }
                throw new NullReferenceException("Unknown packet");
            }
            return Get(info.Id);
        }
        public T Get(Type packetType)
        {
            var info = Proto?.GetInfo(packetType);
            if (info == null)
            {
                if (default(T) == null)
                {
                    return default(T);
                }
                throw new NullReferenceException("Unknown packet");
            }
            return Get(info.Id);
        }
        public T Get(uint packetId)
        {
            T list;
            if (!ItemsTable.TryGetValue(packetId, out list))
            {
                list = new T();
                ItemsTable[packetId] = list;
            }
            return list;
        }
        public abstract IEnumerable<TI> Enumerate(uint packetId);
        public abstract void Clear();
        public abstract void Clear(uint packetId);
    }
    public class PacketTable<TI> : PacketTable<List<TI>, TI>
    {
        public override IEnumerable<TI> Enumerate(uint packetId)
        {
            foreach (var item in Items)
            {
                yield return item;
            }
            List<TI> list;
            if (ItemsTable.TryGetValue(packetId, out list))
            {
                foreach (var item in list)
                {
                    yield return item;
                }
            }
        }
        public override void Clear()
        {
            Items.Clear();
            ItemsTable.Clear();
        }
        public override void Clear(uint packetId)
        {
            ItemsTable.Remove(packetId);
        }
    }
}
