using System;

namespace Link.Net
{
    public delegate T PacketHandler<out T>(object sender, Packet packet);
}

