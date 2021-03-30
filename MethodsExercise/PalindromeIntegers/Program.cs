using System;
using System.Linq;

namespace PalindromeIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();

            while (number != "END")
            {
                Console.WriteLine(isPalindrome(number).ToString().ToLower());
                number = Console.ReadLine();
            }
        }

        static bool isPalindrome(string number)
        {
            var reverse = number.Reverse().ToArray();

            for (int i = 0; i < number.Length; i++)
            {
                if (!(number[i] == reverse[i]))
                {
                    return false;
                }

            }

            return true;
        }
    }
}
