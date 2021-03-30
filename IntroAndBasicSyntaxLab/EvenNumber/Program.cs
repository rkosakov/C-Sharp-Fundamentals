using System;

namespace EvenNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int k = Math.Abs(n);

            while (k % 2 != 0)
            {
                Console.WriteLine("Please write an even number.");
                n = int.Parse(Console.ReadLine());
                k = Math.Abs(n);
            }
            Console.WriteLine($"The number is: {k}");
        }
    }
}
