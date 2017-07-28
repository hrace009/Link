using System;
using Link.Security;
using Link.Net;
using Link.Net.Protocol.Core;
using Link.IO;

namespace Link.Modules
{
    public class AuthModule : ProtoModuleBase
    {
        public string Login { get; set; }
        public string Password { get; set; }
        public bool Force { get; set; }
        public bool KeyExchanging { get; set; }

        public MD5Hash MD5Hash { get; private set; }
        public AuthModule()
        {
            MD5Hash = new MD5Hash();
            KeyExchanging = true;
        }

        public virtual void SetAuthData(string login, string password, bool force = true)
        {
            Login = login;
            Password = password;
            Force = force;
        }

        public override void RegisterHandlers()
        {
            Register<Challenge>(ChallengeReceive);
            Register<KeyExchange>(KeyExchangeReceive);
        }

        protected virtual void KeyExchangeReceive(object sender, PacketEventArgs e)
        {
            if (KeyExchanging && !e.IsComplete && e.Chain.IsInput)
            {
                var exchange = Proto.Get<KeyExchange>();
                exchange.Nonce.Data = new byte[16];
                exchange.KickUser = Force;
                new Random().NextBytes(exchange.Nonce.Data);

                e.Chain.Redirect.SendPacket(exchange);
            }
        }
        protected virtual void ChallengeReceive(object sender, PacketEventArgs e)
        {
            if (!e.IsComplete)
            {
                var challenge = e.Read<Challenge>();

                var hash = MD5Hash.GetHash(Login, Password, challenge.Nonce);

                var response = Proto.Get<Response>();
                response.Identity.SetAsciiString(Login);
                response.Key.Data = hash;
                response.UseToken = false;
                response.CliFingerprint.Data = new byte[]{ 0xFF, 0xFF, 0xFF, 0xFF };

                e.Chain.Redirect.SendPacket(response);
            }
        }
    }
}

