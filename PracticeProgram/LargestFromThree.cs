using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProgram
{
    internal class LargestFromThree
    {
        public void CheckLargest()
        {
            Console.WriteLine("enetr 1st numbers");
            var a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enetr 2nd numbers");
            var b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enetr 3rd numbers");
            var c = Convert.ToInt32(Console.ReadLine());
            if (a >= b && a >= c)
            {
                Console.WriteLine(a + " is largest ");
            }
            else if (b >= a && b >= c)
            {
                Console.WriteLine(b + " is Largest");
            }
            else
            {
                Console.WriteLine(c +" is Largest");
            }
        }
    }
}
