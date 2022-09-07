namespace PracticeProgram
{
    internal class Program
    {
        public void Select()
        {
            Console.WriteLine("1.Swap Number \n2.Check Lower or Upper Case \n3.Check Palindrome \n4.Number Armstrong or Not \n5.Product of two numbers using recursion");
            Console.WriteLine("6.Check Vowel\n7.check Numbers\n8.Check Largest Among three\n9.Print A-Z alphabete\n0.Exit");
            var option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    SwapNumber swap = new SwapNumber();
                    swap.Swap();
                    Select();
                    break;
                case 2:
                    CheckLowerUpper check = new CheckLowerUpper();
                    check.LowerUpper();
                    Select();
                    break;
                case 3:
                    PalindromeCheck palindrome = new PalindromeCheck();
                    palindrome.Palindrome();
                    Select();
                    break;
                case 4:
                    ArmstrongNumber armstrong = new ArmstrongNumber();
                    armstrong.Armstrong();
                    Select();
                    break;
                case 5:
                    FindProduct find = new FindProduct();
                    find.findProduct(10, 15);
                    Select();
                    break;
                case 6:
                    CheckVowel vowel = new CheckVowel();
                    Select();
                    break;
                case 7:
                    CheckNumbers numbers = new CheckNumbers();
                    Select();
                    break;
                case 8:
                    LargestFromThree largest = new LargestFromThree();
                    largest.CheckLargest();
                    Select();
                    break;
                case 9:
                    PrintAlphabete print = new PrintAlphabete();
                    Select();
                    break;
                case 0: break;
            }
        }
        static void Main(string[] args)
        {
            Program program = new Program();
            program.Select();
        }
    }
}