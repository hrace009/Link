using System;
using System.Text;

namespace Link.IO
{
    public class Octets : Vector<byte>
    {
        public static readonly Encoding DefaultEncoding = Encoding.Unicode;

        public Octets()
        {
            
        }
        public Octets(byte[] data)
        {
            Data = data;
        }
        public Octets(string s)
        {
            SetString(DefaultEncoding, s);
        }

        public string ToString(Encoding encoding)
        {
            if (Data == null)
            {
                return string.Empty;
            }
            return encoding.GetString(Data);
        }
        public void SetString(Encoding encoding, string text)
        {
            Data = encoding.GetBytes(text);
        }
        public static Octets FromString(Encoding encoding, string text)
        {
            var result = new Octets();
            result.SetString(encoding, text);
            return result;
        }


        public string ToUnicodeString()
        {
            return ToString(Encoding.Unicode);
        }
        public void SetUnicodeString(string text)
        {
            SetString(Encoding.Unicode, text);
        }
        public static Octets FromUnicodeString(string text)
        {
            return FromString(Encoding.Unicode, text);
        }


        public string ToAsciiString()
        {
            return ToString(Encoding.ASCII);
        }
        public void SetAsciiString(string text)
        {
            SetString(Encoding.ASCII, text);
        }
        public static Octets FromAsciiString(string text)
        {
            return FromString(Encoding.ASCII, text);
        }
        
        public string ToUtf8String()
        {
            return ToString(Encoding.UTF8);
        }
        public void SetUtf8String(string text)
        {
            SetString(Encoding.UTF8, text);
        }
        public static Octets FromUtf8String(string text)
        {
            return FromString(Encoding.UTF8, text);
        }

        public override string ToString()
        {
            return ToString(DefaultEncoding);
        }

        public static implicit operator string(Octets octets)
        {
            return octets.ToString(DefaultEncoding);
        }
        public static implicit operator Octets(string s)
        {
            return FromString(DefaultEncoding, s);
        }

        public static implicit operator byte[](Octets octets)
        {
            return octets.Data;
        }
        public static implicit operator Octets(byte[] bytes)
        {
            return new Octets(bytes);
        }

        public override DataStream Serialize(DataStream ds)
        {
            return ds.Write(Data, true);
        }
        public override bool TryDeserialize(DataStream ds)
        {
            byte[] data;
            if (ds.TryRead(out data))
            {
                Data = data;
                return true;
            }
            return false;
        }
    }
}

