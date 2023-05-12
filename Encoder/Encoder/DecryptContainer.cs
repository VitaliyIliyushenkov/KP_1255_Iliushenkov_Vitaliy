using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Encoder
{
    internal class DecryptContainer
    {
        public DecryptContainer(string key)
        {
            // Заполнение списка decryptors по строке-ключу
            foreach (char item in key.Reverse()) 
            {
                switch (item)
                {
                    case 'I':
                        decryptors.Add( new DecrementDecrypt()); 
                        break;
                    case 'D':
                        decryptors.Add( new IncrementDecrypt());
                        break;
                    case 'Z':
                        decryptors.Add( new ZeroDecrypt());
                        break;
                    case 'N':
                        decryptors.Add( new NegativeDecrypt());
                        break;
                }
            }
        }
        public List<DecryptProcessor> decryptors = new List<DecryptProcessor>();
    }
}
