using System;

namespace TownInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            string town = Console.ReadLine();
            int population = int.Parse(Console.ReadLine());
            double sqkm = double.Parse(Console.ReadLine());

            Console.WriteLine($"Town {town} has population of {population} and area {sqkm} square km.");
        }
    }
}
