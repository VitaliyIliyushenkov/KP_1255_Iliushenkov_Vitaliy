using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encoder
{
    internal class NegativeDecrypt : DecryptProcessor
    {
        public override char Process(char symbol)
        {
            return (char)(255 - symbol);
        }
    }
}
