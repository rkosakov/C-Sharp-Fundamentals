using System;
using System.Collections.Generic;

namespace ListOfProducts
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<string> product = new List<string>();

            for (int i = 0; i < n; i++)
            {
                string item = Console.ReadLine();
                product.Add(item);
            }

            product.Sort();

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"{i}.{product[i - 1]}");
            }
        }
    }
}
