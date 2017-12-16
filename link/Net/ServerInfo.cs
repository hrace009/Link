using System;

namespace Link.Net
{
    public class ServerInfo
    {
        public string Name { get; private set; }
        public string Host { get; private set; }
        public int Port { get; private set; }

        private static readonly ServerInfo serverInfoLocal = new ServerInfo("127.0.0.1", 29000);
        public static ServerInfo Local
        {
            get
            {
                return serverInfoLocal;
            }
        }

        public ServerInfo() : this("127.0.0.1", 29000)
        {
        }
        public ServerInfo(string host, int port) : this(host, port, string.Empty)
        {
        }
        public ServerInfo(string host, int port, string name)
        {
            Name = name;
            Host = host;
            Port = port;
        }
        public override bool Equals(object obj)
        {
            if (obj is ServerInfo)
            {
                var gs = obj as ServerInfo;
                return gs.Host == Host && Port == gs.Port;
            }
            return base.Equals(obj);
        }
        public override int GetHashCode()
        {
            return Name.GetHashCode() ^ Host.GetHashCode() ^ Port.GetHashCode();
        }
        public static ServerInfo Parse(string server)
        {
            var res = new ServerInfo();

            string[] args = server.Replace(" ", string.Empty).Split(':', ';', '=', '\t');
            if (args.Length == 0)
            {
                res.Host = "127.0.0.1";
                res.Port = 29000;
                return res;
            }
            if (args.Length == 1)
            {
                res.Host = args[0];
                res.Port = 29000;
                return res;
            }

            int port;

            if (int.TryParse(args[0], out port))
            {
                res.Port = port;
                res.Host = args[1];
            }
            else
            {
                if (int.TryParse(args[1], out port))
                {
                    res.Port = port;
                    res.Host = args[0];
                }
                else
                {
                    res.Host = args[0];
                    res.Port = 29000;
                }
            }
            return res;
        }

        public override string ToString()
        {
            string srvName = string.IsNullOrEmpty(Name) ? "" : Name + " ";
            return String.Format("{0}{1}:{2}", srvName, Host, Port);
        }
        public string ToShortString()
        {
            return string.IsNullOrEmpty(Name) ? String.Format("{0}:{1}", Host, Port) : Name;
        }
    }
}

