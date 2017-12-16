using System;
using Link.IO;

namespace Link.Net
{
    public class RpcContainer<T> : RpcContainer
        where T : IDataSerializer
    {
        public RpcContainer() : this(Helpers.FastConstructor<T>.Create())
        {
            
        }
        public RpcContainer(T content)
        {
            Content = content;
        }
        public T Content;
        public new IDataSerializer DataSerializer
        {
            get
            {
                return Content;
            }
            set
            {
                Content = (T)value;
            }
        }

    }
    public class RpcContainer : IDataSerializer
    {
        public uint Id;
        public IDataSerializer DataSerializer { get; set; }

        public RpcContainer()
        {
            
        }
        public RpcContainer(IDataSerializer dataSerializer)
        {
            DataSerializer = dataSerializer;
        }

        public DataStream Serialize(DataStream ds)
        {
            ds.Write(Id);
            ds.Write(DataSerializer);
            return ds;

        }
        public bool TryDeserialize(DataStream ds)
        {
            return ds.TryRead(out Id) && ds.TryRead(DataSerializer);

        }
    }
}

