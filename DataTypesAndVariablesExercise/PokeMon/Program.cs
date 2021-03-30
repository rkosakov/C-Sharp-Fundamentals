using System;
using System.Numerics;

namespace PokeMon
{
    class Program
    {
        static void Main(string[] args)
        {
            int power = int.Parse(Console.ReadLine()); //n
            int distance = int.Parse(Console.ReadLine()); //m
            int exhaustion = int.Parse(Console.ReadLine()); //y
            int target = 0;
            double percentage = (double) power * 0.50;
            while (power >= distance)
            {
                if (power == percentage && exhaustion > 0)
                {
                    
                    power /= exhaustion;

                    if (power < distance)
                    {
                        break;
                    }
                }
                power -= distance;
                target++;
            }

            Console.WriteLine(power);
            Console.WriteLine(target);
        }
    }
}
