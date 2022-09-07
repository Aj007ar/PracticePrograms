using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProgram
{
    internal class CheckLowerUpper
    {
        public void LowerUpper()
        {
            Console.WriteLine("\n\nEnter Alphabetes ");
            var alpha = Convert.ToChar(Console.ReadLine());
            while (alpha < 'a' || alpha > 'z')
            {
                Console.WriteLine("Please enter Alphabetes only");
                alpha = Convert.ToChar(Console.ReadLine());
            }
            if(alpha>='a' && alpha <= 'z')
            {
                Console.WriteLine("Lower case");
            }
            else if (alpha >= 'A' && alpha <= 'Z')
            {
                Console.WriteLine("Upper Case");
            }
            else
            {
                Console.WriteLine("invalid input");
            }
        }
    }
}
