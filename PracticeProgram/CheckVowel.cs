using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProgram
{
    internal class CheckVowel
    {
        public CheckVowel()
        {
            Console.WriteLine("Enter Alphabete");
            var check = Convert.ToChar(Console.ReadLine());

            if (check == 'a' || check == 'e' || check == 'i' || check == 'o' || check == 'u')
            {
                Console.WriteLine("Alphabete is Vowel");
            }
            else
            {
                Console.WriteLine("Not vowel");
            }
        }

    }
}
