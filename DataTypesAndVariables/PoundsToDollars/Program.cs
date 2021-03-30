using System;

namespace PoundsToDollars
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal input = decimal.Parse(Console.ReadLine());

            decimal result = (decimal) 1.31 * input;

            Console.WriteLine($"{result:f3}");
        }
    }
}
