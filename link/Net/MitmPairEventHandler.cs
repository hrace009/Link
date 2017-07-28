using System;

namespace Link.Net
{
    public delegate void MitmPairEventHandler<T>(object sender, T pair) where T : MitmPair;
    public delegate void MitmPairEventHandler(object sender, MitmPair pair);
}

