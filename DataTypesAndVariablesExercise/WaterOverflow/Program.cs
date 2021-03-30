using System;
using System.Collections.Generic;

namespace WaterOverflow
{
    class Program
    {
        static void Main(string[] args)
        {
            byte n = byte.Parse(Console.ReadLine());
            short sum = 0;

            for (int i = 1; i <= n; i++)
            {
                short amount = short.Parse(Console.ReadLine());

                if (amount + sum > 255)
                {
                    Console.WriteLine("Insufficient capacity!");
                }
                else
                {

                    sum += amount;
                }

            }
            Console.WriteLine(sum);
        }
    }
}
