using System;
using System.Collections.Generic;
using System.Text;

using System.Net;
using System.Net.Sockets;
using System.Runtime.Remoting;
using System.Runtime.Serialization;

namespace BlueFlame.Classes.MySql
{
    public class MySqlObjectId 
    {       
        private Int32 _address;
        private static Int32 _counter = 0;
        private static UInt64 _timestamp = (UInt64)DateTime.Now.ToBinary();

        private static object _sync;

        private char[] internalString;

        public MySqlObjectId()
        {
            _sync = new object();
            _address = 0;
            
            // getting IPv4 address for first part
            foreach (IPAddress ip in Dns.GetHostAddresses(Dns.GetHostName()))
                if (ip.AddressFamily == AddressFamily.InterNetwork) _address = ConvertAddress(ip);

            lock (_sync) 
            { 
                _counter++;
                if (_counter == 0) _timestamp = (UInt64)DateTime.Now.ToBinary();
                SetInternalString();
            }
        }

        private void SetInternalString()
        {
            internalString = new char[32];

            // Convert all the numbers to a hexadecimal string
            string address = _address.ToString("x");
            string counter = _counter.ToString("x");
            string timestamp = _timestamp.ToString("x");

            // fill the strings with placeholders
            while ((8 - address.Length) > 0) address = address.Insert(0, "0");
            while ((8 - counter.Length) > 0) counter = counter.Insert(0, "0");
            while ((16 - timestamp.Length) > 0) timestamp = timestamp.Insert(0, "0");

            for (int i = 0; i < 8; i++)
                internalString[i] = address[i];
            for (int i = 8; i < 16; i++)
                internalString[i] = counter[i - 8];
            for (int i = 16; i < 32; i++)
                internalString[i] = timestamp[i - 16];
        }

        //  System.Net.IPAddress.Address is deprecated
        public static Int32 ConvertAddress(IPAddress ip)
        {
            // Only accept IPv4 addresses (32Bit Address)
            if (ip.AddressFamily != AddressFamily.InterNetwork) return 0;

            Int32 address = 0;
            foreach (byte addressByte in ip.GetAddressBytes())
            {
                int byteAsLong = (int)addressByte;
                if (byteAsLong < 0) byteAsLong += 256;
                address <<= 8;
                address |= byteAsLong;
            }
            return address;
        }       

        public override string ToString()
        {
            return new string(internalString);
        }
    }
}
