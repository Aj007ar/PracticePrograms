using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProgram
{
    internal class ArmstrongNumber
    {
        public void Armstrong()
        {
            int Tnum, temp;
            int sum = 0;
            Console.WriteLine("Enter number");
            int num = Convert.ToInt32(Console.ReadLine());
            Tnum = num;
            while (num > 0)
            {
                temp = num % 10;
                sum += (temp*temp*temp);
                num /= 10;
            }
            if (Tnum == num)
            {
                Console.WriteLine("Number is Armstrong");
            }
            else
            {
                Console.WriteLine("Number is not Armstrong");
            }
        }
    }
    
}
