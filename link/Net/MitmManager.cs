using System;
using System.Collections.Generic;
using System.Text;
using Link.Threading;

namespace Link.Net
{
    public class MitmManager<T> : IMitmManager<T> where T : MitmPair, new()
    {
        protected ConcurentSet<MitmListner<T>> listners = new ConcurentSet<MitmListner<T>>();
        protected ConcurentSet<T> sessions = new ConcurentSet<T>();

        public IEnumerable<T> Sessions
        {
            get
            {
                foreach (var item in sessions)
                {
                    yield return item;
                }
            }
        }

        public IEnumerable<MitmListner<T>> Listners
        {
            get
            {
                foreach (var item in listners)
                {
                    yield return item;
                }
            }
        }
        
        public event MitmPairEventHandler<T> Accepting;
        public event MitmPairEventHandler<T> Accepted;
        public event MitmPairEventHandler<T> Closing;
        public event MitmPairEventHandler<T> Closed;

        public void AddListner(MitmListner<T> listner)
        {
            if (!listners.Add(listner))
            {
                return;
            }
            listner.Accepted += Listner_MitmPairAccepted;
            listner.Accepting += Listner_MitmPairAccepting;
        }
        public void RemoveListner(MitmListner<T> listner)
        {
            if (!listners.Remove(listner))
            {
                return;
            }
            listner.Accepted -= Listner_MitmPairAccepted;
            listner.Accepting -= Listner_MitmPairAccepting;
        }

        private void Listner_MitmPairAccepting(object sender, T pair)
        {
            pair.Closing += Pair_Closing;
            pair.Closed += Pair_Closed;

            Accepting?.Invoke(this, pair);
        }

        private void Listner_MitmPairAccepted(object sender, T pair)
        {
            sessions.Add(pair);
            Accepted?.Invoke(this, pair);
        }

        private void Pair_Closing(object sender, EventArgs e)
        {
            var pair = (T)sender;
            Closing?.Invoke(this, pair);
        }

        private void Pair_Closed(object sender, EventArgs e)
        {
            var pair = (T)sender;
            sessions.Remove(pair);
            Closed?.Invoke(this, pair);
        }

        public void StartAll()
        {
            lock (listners.Lock)
            {
                foreach (var listner in listners)
                {
                    if (!listner.ActiveFactory.Started)
                    {
                        listner.Start();
                    }
                }
            }
        }

        public void StopAll()
        {
            lock (listners.Lock)
            {
                foreach (var listner in listners)
                {
                    if (listner.ActiveFactory.Started)
                    {
                        listner.Stop();
                    }
                }
            }
        }
        public void DisconectAll()
        {
            lock (sessions.Lock)
            {
                foreach (var session in sessions)
                {
                    session.Close();
                }
            }
        }
    }
}
