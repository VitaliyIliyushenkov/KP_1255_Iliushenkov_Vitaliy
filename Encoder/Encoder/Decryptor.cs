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

            int i = container.decryptors.Count -1;
            foreach (char symbol in textToDecrypt)
            {
                char newSymbol = symbol;
                newSymbol = container.decryptors[i].Process(newSymbol);

                textDecrypt += newSymbol;
                if (i == 0)
                    i = container.decryptors.Count - 1;
                else
                    i--;
            }
            return textDecrypt;
        }
    }
}
