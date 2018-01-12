using System;
using System.Diagnostics;
using Link.Net;
using Link.Net.Protocol.Core;
using Link.Modules;
using Link.Net.Protocol;
using System.Threading;
using System.Collections.Generic;
using Link.IO;
using Link.Pools;
using System.Threading.Tasks;
using System.Linq;

namespace LinkDebug
{
    static class Helper
    {
        public static string ToStringFull(this DateTime datetime)
        {
            return $"{datetime.ToString("u")}:{datetime.Millisecond.ToString("000")}";
        }
        public static string ToHexString(this byte[] bytes)
        {
            return BitConverter.ToString(bytes);
        }
    }
    struct LogContainer
    {
        public string Name { get; private set; }
        public LogContainer(string name, PacketHandlerTable handler)
        {
            Name = name;
            handler.Get().Add(ProcessPacket, PacketHandlerPriority.System);
        }
        public void ProcessPacket(object sender, PacketEventArgs e)
        {
            var packet = e.Packet;
            var now = DateTime.Now;
            Console.WriteLine("[{4} {5}][{0}][{1}] 0x{2:X2} ({3} bytes)",
                now.ToStringFull(),
                Name,
                packet.Id,
                packet.Stream.Count,
                e.IsComplete ? "+" : " ",
                e.Chain.IsInput ? "<" : ">");
        }
    }
    public static class MainClass
    {
        public static void Main(string[] args)
        {
            var active = new TcpSocketListner();
            var passive = new TcpSocketOpener(args.Length > 0 ? args[0] : "link1.pwonline.ru");

            var mitm = new MitmListner<MitmPair>(active, passive);
            mitm.Accepting += Mitm_MitmPairAccepted;
            mitm.Start();

            Thread.Sleep(Timeout.Infinite);
        }

        static void TestClient_StateChanged(object sender, EventArgs e)
        {
            var session = (Session)sender;

            Console.WriteLine(session.State);
        }

        static List<LogContainer> loggers = new List<LogContainer>();
        static void StartLogging(string name, Session session)
        {
            loggers.Add(new LogContainer(name, session.Handler));
        }
        static int id = 0;
        static void Mitm_MitmPairAccepted(object sender, MitmPair pair)
        {
            pair.Proto.Register(Link.Net.Protocol.Known.Default.ProtoBuilderDefault.Instance);
            pair.Client.Modules.Register<KeyExchangeModule>();
            pair.Server.Modules.Register<KeyExchangeModule>();

            var name = (++id) + "";
            StartLogging(name + "-c", pair.Client);
            StartLogging(name + "-s", pair.Server);
        }

        static void PacketReceived(object sender, Packet packet)
        {
            Console.WriteLine("Receive 0x{0:X2}, length = {1}", packet.Id, packet.Stream.Count);
        }
    }
}
