using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encoder
{
    internal class Encryptor
    {
        public delegate char EncyrptFunction(char symbol);

        public Encryptor(EncyrptFunction func, string name, string key)
        {
            encryptFunc = func;
            this.key = key;
        }

        public char encrypt(char symbol)
        {
            return encryptFunc(symbol);
        }

        EncyrptFunction encryptFunc;
        public string key;
    }
}
