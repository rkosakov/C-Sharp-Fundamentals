using System;

namespace Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());

            CalculateOrder(product, quantity);

        }

        static void CalculateOrder(string product, int quantity)
        {
            double total = 0;
            switch (product)
            {
                case "coffee":
                    total = 1.50 * quantity;
                    break;
                case "water":
                    total = 1 * quantity;
                    break;
                case "coke":
                    total = 1.40 * quantity;
                    break;
                case "snacks":
                    total = 2 * quantity;
                    break;
            }

            Console.WriteLine($"{total:f2}");
        }
    }
}
