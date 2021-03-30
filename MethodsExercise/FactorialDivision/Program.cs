using System;

namespace FactorialDivision
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            decimal result = Factorial(num1) / Factorial(num2);
            Console.WriteLine($"{result:f2}");

        }

        static decimal Factorial (int num)
        {
            decimal factorial = 1;

            for (int i = 1; i <= num; i++)
            {
                factorial *= i;
            }

            return factorial;
        }
    }
}
