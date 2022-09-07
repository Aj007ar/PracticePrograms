using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProgram
{
    internal class CheckNumbers
    {
        public CheckNumbers()
        {
            Console.WriteLine("Enter Numbers");
            var num = Convert.ToInt32(Console.ReadLine());
            if (num > 0)
            {
                Console.WriteLine("Positive Number");
            }
            else if (num < 0)
            {
                Console.WriteLine("Negative Number");
            }
            else if (num == 0)
            {
                Console.WriteLine("number is zero");
            }
            else
            {
                Console.WriteLine("not a number");
            }
        }
    }
}
