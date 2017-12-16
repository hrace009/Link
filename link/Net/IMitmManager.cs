using System;
using System.Collections.Generic;
using System.Text;

namespace Link.Net
{
    public interface IMitmManager<T> where T : MitmPair, new()
    {
        event MitmPairEventHandler<T> Accepting;
        event MitmPairEventHandler<T> Accepted;
        event MitmPairEventHandler<T> Closing;
        event MitmPairEventHandler<T> Closed;
        void AddListner(MitmListner<T> listner);
        void RemoveListner(MitmListner<T> listner);
        IEnumerable<T> Sessions { get; }
        IEnumerable<MitmListner<T>> Listners { get; }

        void StartAll();
        void StopAll();
    }
}
