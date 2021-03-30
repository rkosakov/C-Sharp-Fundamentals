using System;
using System.Globalization;

namespace StrongNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int tempNum = num;

            string numStr = string.Empty;
            numStr += num;
            int sum = 0;

            for (int i = 0; i < numStr.Length; i++)
            {
                int currentDigit = tempNum % 10;
                tempNum = (tempNum - currentDigit) / 10;

                int factorial = 1;

                for (int j = 1; j <= currentDigit; j++)
                {
                    factorial *= j;
                }

                sum += factorial;
            }

            if (num == sum)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
