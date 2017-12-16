using System;
using Link.Net;
using Link.Net.Protocol;
using Link.IO;
using Link.Security;
using Link.Net.Protocol.Core;

namespace Link.Modules
{
    public class KeyExchangeModule : ProtoModuleBase
    {
        public MD5Hash MD5Hash { get; private set; }
        public bool IsClient { get; private set; }

        public KeyExchangeModule()
        {
            MD5Hash = new MD5Hash();
        }


        public override void RegisterHandlers()
        {
            Register<Response>(ResponseReceive, PacketHandlerPriority.High);
            Register<KeyExchange>(KeyExchangeReceive, PacketHandlerPriority.System);
        }

        protected virtual void ResponseReceive(object sender, PacketEventArgs e)
        {
            if (!e.IsComplete)
            {
                var response = e.Read<Response>();
                MD5Hash.SetHash(response.Identity.Data, response.Key.Data);

                IsClient = !e.Chain.IsInput;
            }
        }

        protected virtual void KeyExchangeReceive(object sender, PacketEventArgs e)
        {
            if (!e.IsComplete)
            {
                var keyExchange = e.Read<KeyExchange>();
                var key = MD5Hash.GetKey(keyExchange.Nonce.Data);

                var rc4Encryption = new Rc4Encryption(key);

                if (e.Chain.IsInput)
                {
                    if (!IsClient)
                    {
                        Session.Connection.EncodeStack.Setup(new MppcPacker());
                    }
                    Session.Connection.EncodeStack.Setup(rc4Encryption);
                }
                else
                {
                    Session.Connection.DecodeStack.Setup(rc4Encryption);
                    if (IsClient)
                    {
                        Session.Connection.DecodeStack.Setup(new MppcUnpacker());
                    }
                }
            }
        }
    }
}

