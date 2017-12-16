using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Link.IO;

namespace Link.Net.Protocol
{
    public class ProtoListTable : ProtoTable
    {
        private readonly List<ProtoTable> ProtoList = new List<ProtoTable>();
        
        private readonly object lockObject = new object();
        public object LockObject
        {
            get
            {
                return lockObject;
            }
        }

        public int Count
        {
            get
            {
                return ProtoList.Count;
            }
        }

        public ProtoListTable()
        {

        }
        public ProtoListTable(ProtoTable proto)
        {
            Register(proto);
        }
        public ProtoListTable(params ProtoTable[] protos) : this((IEnumerable<ProtoTable>)protos)
        {
        }
        public ProtoListTable(IEnumerable<ProtoTable> protos)
        {
            foreach (var proto in protos)
            {
                Register(proto);
            }
        }

        public ProtoTable Register<T>(int index = -1) where T : ProtoTable, new()
        {
            return Register(new T(), index);
        }
        public ProtoTable Register(ProtoTable table, int index = -1)
        {
            lock (lockObject)
            {
                if (index < 0) index = Count;
                if (index > Count) index = Count;

                ProtoList.Insert(index, table);
                return table;
            }
        }
        

        public override IPacketContainer<Packet> GetContainer<Packet>()
        {
            lock (lockObject)
            {
                foreach (var x in ProtoList)
                {
                    var res = x.GetContainer<Packet>();
                    if (res != null)
                    {
                        return res;
                    }
                }
            }
            return null;
        }

        public override IPacketContainer GetContainer(Type type)
        {
            lock (lockObject)
            {
                foreach (var x in ProtoList)
                {
                    var res = x.GetContainer(type);
                    if (res != null)
                    {
                        return res;
                    }
                }
            }
            return null;
        }
        
        public override IPacketContainer GetContainer(uint packetId)
        {
            lock (lockObject)
            {
                foreach (var x in ProtoList)
                {
                    var res = x.GetContainer(packetId);
                    if (res != null)
                    {
                        return res;
                    }
                }
            }
            return null;
        }

        public override IDataSerializer Get(Type type)
        {
            lock (lockObject)
            {
                foreach (var x in ProtoList)
                {
                    var res = x.Get(type);
                    if (res != null)
                    {
                        return res;
                    }
                }
            }
            return null;
        }
        public override Structure Get<Structure>()
        {
            lock (lockObject)
            {
                foreach (var x in ProtoList)
                {
                    var res = x.Get<Structure>();
                    if (res != null)
                    {
                        return res;
                    }
                }
            }
            return default(Structure);
        }

        public override IPacketBuilder<Packet> GetBuilder<Packet>()
        {
            lock (lockObject)
            {
                foreach (var x in ProtoList)
                {
                    var res = x.GetBuilder<Packet>();
                    if (res != null)
                    {
                        return res;
                    }
                }
            }
            return null;
        }

        public override IPacketBuilder GetBuilder(Type type)
        {
            lock (lockObject)
            {
                foreach (var x in ProtoList)
                {
                    var res = x.GetBuilder(type);
                    if (res != null)
                    {
                        return res;
                    }
                }
            }
            return null;
        }

        public override IPacketBuilder GetBuilder(uint packetId)
        {
            lock (lockObject)
            {
                foreach (var x in ProtoList)
                {
                    var res = x.GetBuilder(packetId);
                    if (res != null)
                    {
                        return res;
                    }
                }
            }
            return null;
        }

        public override PacketBaseInformation GetInfo<Packet>()
        {
            lock (lockObject)
            {
                foreach (var x in ProtoList)
                {
                    var res = x.GetInfo<Packet>();
                    if (res != null)
                    {
                        return res;
                    }
                }
            }
            return null;
        }
        public override PacketBaseInformation GetInfo<Packet>(Packet packet)
        {
            lock (lockObject)
            {
                foreach (var x in ProtoList)
                {
                    var res = x.GetInfo(packet);
                    if (res != null)
                    {
                        return res;
                    }
                }
            }
            return null;
        }

        public override PacketBaseInformation GetInfo(Type type)
        {
            lock (lockObject)
            {
                foreach (var x in ProtoList)
                {
                    var res = x.GetInfo(type);
                    if (res != null)
                    {
                        return res;
                    }
                }
            }
            return null;
        }

        public override PacketBaseInformation GetInfo(uint packetId)
        {
            lock (lockObject)
            {
                foreach (var x in ProtoList)
                {
                    var res = x.GetInfo(packetId);
                    if (res != null)
                    {
                        return res;
                    }
                }
            }
            return null;
        }
    }
}
