using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encoder
{
    internal class IncrementDecrypt : DecryptProcessor
    {
        public override char Process(char symbol)
        {
           return (char)(symbol + 1);
        }
    }
}
