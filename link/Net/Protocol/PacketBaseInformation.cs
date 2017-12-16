using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Link.Net.Protocol
{
    public class PacketBaseInformation
    {
        public uint Id { get; private set; }
        public int MaximumSize { get; private set; }

        public const int UlimitSize = -1;

        public PacketBaseInformation(uint id, int maximumSize = UlimitSize)
        {
            Id = id;
            MaximumSize = maximumSize;
        }

        public static PacketBaseInformation Create(uint id, int maximumSize = UlimitSize)
        {
            return new PacketBaseInformation(id, maximumSize);
        }

        public static readonly PacketBaseInformation Default = Create(0xFFFFFFFF);
    }
}
