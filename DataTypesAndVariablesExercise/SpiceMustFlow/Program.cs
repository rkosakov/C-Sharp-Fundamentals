using System;
using System.Diagnostics.Tracing;

namespace SpiceMustFlow
{
    class Program
    {
        static void Main(string[] args)
        {
            int initialYield = int.Parse(Console.ReadLine());
            byte couter = 0;
            int production = 0;

            while (initialYield >= 100)
            {
                couter++;
                production += (initialYield - 26);
                initialYield -= 10;
            }
            if (couter == 0 && initialYield < 100)
            {
                Console.WriteLine(couter);
                Console.WriteLine(production);
            }
            else
            {
                production -= 26;
                Console.WriteLine(couter);
                Console.WriteLine(production);
            }


        }
    }
}
