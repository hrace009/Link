using Link.Net;

namespace Link.IO
{
    public interface IDataSerializer
    {
        bool TryDeserialize(DataStream ds);
        DataStream Serialize(DataStream ds);
    }
}
