using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProgram
{
    internal class PrintAlphabete
    {
        public PrintAlphabete()
        {
            char c;
            for (c = 'a'; c <= 'z'; c++)
            {
                Console.Write(c + " ");
            }
        }
    }
}
