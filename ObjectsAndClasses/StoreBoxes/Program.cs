using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Security.Principal;

namespace StoreBoxes
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<Box> boxes = new List<Box>();

            while (input != "end")
            {
                string[] elements = input.Split();

                string serialNumber = elements[0];
                string itemName = elements[1];
                int quantity = int.Parse(elements[2]);
                decimal itemPrice = decimal.Parse(elements[3]);

                Item item = new Item()
                {
                    Name = itemName,
                    Price = itemPrice
                };

                Box box = new Box()
                {
                    SerialNumber = serialNumber,
                    Item = item.Name,
                    ItemQuantity = quantity,
                    PriceForBox = item.Price
                };

                boxes.Add(box);
                input = Console.ReadLine();

            }

            foreach (Box box in boxes.OrderByDescending(price => price.PriceForBox * price.ItemQuantity))
            {
                Console.WriteLine($"{box.SerialNumber}");
                Console.WriteLine($"-- {box.Item} - ${box.PriceForBox:f2}: {box.ItemQuantity}");
                Console.WriteLine($"-- ${box.PriceForBox * box.ItemQuantity:f2}");
            }
            
        }
        
    }

    class Item
    {
        public string Name { get; set; }

        public decimal Price { get; set; }
    }

    class Box
    {
        public string SerialNumber { get; set; }

        public string Item { get; set; }

        public int ItemQuantity { get; set; }

        public decimal PriceForBox { get; set; }
    }

}
