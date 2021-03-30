using System;

namespace MultiplyEvensByOdds
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            number = Math.Abs(number);
            Console.WriteLine(GetMultipleOfEvenAndOdds(number));
        }

        static int GetSumOfEvenDigits(int number, int isEven)
        {
            string num = number.ToString();
            int sum = 0;

            for (int i = 0; i < num.Length; i++)
            {
                int currentInt = int.Parse(num[i].ToString());

                if (currentInt % 2 == isEven)
                {
                    sum += currentInt;
                }
            }

            return sum;
        }
        static int GetSumOfOddDigits(int number, int isEven)
        {
            string num = number.ToString();
            int sum = 0;

            for (int i = 0; i < num.Length; i++)
            {
                int currentInt = int.Parse(num[i].ToString());

                if (currentInt % 2 == isEven)
                {
                    sum += currentInt;
                }
            }

            return sum;
        }

        static int GetMultipleOfEvenAndOdds(int number)
        {
            return GetSumOfEvenDigits(number, 0) * GetSumOfOddDigits(number, 1);
        }
    }
}
