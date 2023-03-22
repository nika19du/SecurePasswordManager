using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace WF
{
    public class Random
    {
        public int Next(int n)
        {
            RNGCryptoServiceProvider provider = new RNGCryptoServiceProvider();
            var byteArray = new byte[4];
            provider.GetBytes(byteArray);

            var randomInteger = BitConverter.ToUInt32(byteArray, 0);
            return (int)(randomInteger%n);
        }
    }
}
