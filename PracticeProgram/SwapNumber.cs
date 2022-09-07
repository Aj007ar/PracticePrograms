using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProgram
{
    internal class SwapNumber
    {
       public void Swap()
        {
            Console.WriteLine("Enter 1st Number: ");
            var a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter 2nd Number: ");
            var b = Convert.ToInt32(Console.ReadLine());
            //swapping numbers
            a = a + b;
            b = a - b;
            a = a - b;
            Console.WriteLine("After Swapping \n1st Number= "+a +" \n2nd Number= "+b);
        }
    }
}
