using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProgram
{
    internal class PalindromeCheck
    {
        public void Palindrome()
        {
            int reverse = 0;
            int temp = 0;
            int tnum = 0;
            int num=0;
            Console.WriteLine("Enter Number for checking palindrome or Not: ");
            tnum = num =int.Parse(Console.ReadLine());

            while (num > 0)
            {
                temp = num % 10;
                reverse = reverse * 10 + temp;
                num /= 10;
            }
            if (reverse == tnum)
            {
                Console.WriteLine("Number Is Palindrome");
            }
            else
            {
                Console.WriteLine("Number is not Palindrome");
            }
        }
    }
}
