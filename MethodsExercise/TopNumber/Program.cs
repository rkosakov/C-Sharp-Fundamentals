using System;
using System.Diagnostics;

namespace TopNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int end = int.Parse(Console.ReadLine());
            TopNumber(end);
            
        }

        static bool IsDigitSumDevisibleBy8(int number)
        {
            int sum = 0;
            while (number > 0)
            {
                sum += number % 10;
                number /= 10;
            }

            if (sum % 8 == 0)
            {
                return true;
            }
            return false;
        }

        static bool HasOddDigits(int number)
        {
            while (number > 0)
            {
               int currentDigit =  number % 10;
                number /= 10;

                if (currentDigit % 2 != 0)
                {
                    return true;
                }
            }

            return false;
        }

        static void TopNumber(int end)
        {
            for (int i = 1; i <= end; i++)
            {
                if (IsDigitSumDevisibleBy8(i) && HasOddDigits(i))
                {
                    Console.WriteLine(i);
                }
            }
        }

    }
}
