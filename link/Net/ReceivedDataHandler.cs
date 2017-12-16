using System;

namespace Link.Net
{
    public delegate void ReceivedDataHandler(object sender, byte[] buffer, int offset, int length);
}

