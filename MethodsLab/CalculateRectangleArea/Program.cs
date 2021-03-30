using System;

namespace CalculateRectangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int result = CalculateArea(a, b);
            Console.WriteLine(result);
        }

        static int CalculateArea(int a, int b)
        {
            return a * b;
        }
    }
}
