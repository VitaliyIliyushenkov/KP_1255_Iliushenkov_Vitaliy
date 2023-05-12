using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encoder
{
    internal class Decryptor
    {
        public string Decrypt(string key, string textToDecrypt)
        {
            DecryptContainer container = new DecryptContainer(key);
            string textDecrypt = "";

            // Логика расшифровки
            foreach (char symbol in textToDecrypt)
            {
                char newSymbol = symbol;

                foreach (DecryptProcessor decryptor in container.decryptors)
                {
                    newSymbol = decryptor.Process(newSymbol);
                }
                textDecrypt += newSymbol;
            }
            return textDecrypt;
        }
    }
}
