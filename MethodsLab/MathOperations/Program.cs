using System;

namespace MathOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1 = int.Parse(Console.ReadLine());
            string @operator = Console.ReadLine();
            double num2 = int.Parse(Console.ReadLine());

            if (@operator == "/")
            {
                if (num1 % num2 == 0)
                {
                    Console.WriteLine($"{Calculate(num1, @operator, num2)}");
                }
                else
                {
                    Console.WriteLine($"{Calculate(num1, @operator, num2):f2}");
                }
            }

            else
            {
                Console.WriteLine($"{Calculate(num1, @operator, num2)}");
            }
        }

        static double Calculate(double num1, string @operator, double num2)
        {
            double result = 0;
            switch (@operator)
            {
                case "+":
                    result = num1 + num2;
                    break;
                case "-":
                    result = num1 - num2;
                    break;
                case "*":
                    result = num1 * num2;
                    break;
                case "/":
                    result = num1 / num2;
                    break;

            }
            return result;
        }
    }
}
