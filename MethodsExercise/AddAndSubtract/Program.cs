using System;

namespace AddAndSubtract
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());
            Console.WriteLine(Subract(num1, num2, num3));
        }

        static int Sum(int num1, int num2)
        {
            return num1 + num2;
        }

        static int Subract(int num1, int num2, int num3)
        {
            return Sum(num1, num2) - num3;
        }
    }
}
