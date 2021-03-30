using System;

namespace VendingMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            string coins = Console.ReadLine();//0.1, 0.2, 0.5, 1, and 2 
            double sum = 0;

            while (coins != "Start")
            {
                double money = double.Parse(coins);

                if (money != 0.1 && money != 0.2 && money != 0.5 && money != 1 && money != 2)
                {
                    Console.WriteLine($"Cannot accept {money}");
                }
                else
                {
                    sum += money;
                }
                coins = Console.ReadLine();
            }

            string item = Console.ReadLine();
            //“Nuts”, “Water”, “Crisps”, “Soda”, “Coke”. The prices are: 2.0, 0.7, 1.5, 0.8, 1.0 

            while (item != "End")
            {
                double price = 0;
                switch (item)
                {
                    case "Nuts":
                        price = 2;
                        break;
                    case "Water":
                        price = 0.7;
                        break;
                    case "Crisps":
                        price = 1.5;
                        break;
                    case "Soda":
                        price = 0.8;
                        break;
                    case "Coke":
                        price = 1.0;
                        break;
                    default:
                        Console.WriteLine("Invalid product");
                        item = Console.ReadLine();
                        continue;
                }

                if (sum >= price)
                {
                    sum -= price;
                    Console.WriteLine($"Purchased {item.ToLower()}");
                }
                else
                {
                    Console.WriteLine("Sorry, not enough money");
                }
                item = Console.ReadLine();
            }

            Console.WriteLine($"Change: {sum:f2}");
        }
    }
}
