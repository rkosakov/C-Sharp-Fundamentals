using System;

namespace Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            string type = Console.ReadLine();
            string day = Console.ReadLine();

            double totalPrice = 0;
            double discount = 0;

            if (day == "Friday")
            {
                if (type == "Students")
                {
                    if (number >= 30)
                    {
                        discount = 8.45 * 0.15;

                        totalPrice = (number * 8.45) - (number * discount);
                    }
                    else
                    {
                        totalPrice = number * 8.45;
                    }
                }
                else if (type == "Business")
                {
                    if (number >= 100)
                    {
                        number -= 10;
                        totalPrice = number * 10.90;
                    }
                    else
                    {
                        totalPrice = number * 10.90;
                    }
                }
                else if (type == "Regular")
                {
                    if (number >= 10 && number <= 20)
                    {
                        discount = 15 * 0.05;
                        totalPrice = (number * 15) - (number * discount);
                    }
                    else
                    {
                        totalPrice = number * 15;
                    }
                }
            }
            if (day == "Saturday")
            {
                if (type == "Students")
                {
                    if (number >= 30)
                    {
                        discount = 9.80 * 0.15;

                        totalPrice = (number * 9.80) - (number * discount);
                    }
                    else
                    {
                        totalPrice = number * 9.80;
                    }
                }
                else if (type == "Business")
                {
                    if (number >= 100)
                    {
                        number -= 10;
                        totalPrice = number * 15.60;
                    }
                    else
                    {
                        totalPrice = number * 15.60;
                    }
                }
                else if (type == "Regular")
                {
                    if (number >= 10 && number <= 20)
                    {
                        discount = 20 * 0.05;
                        totalPrice = (number * 20) - (number * discount);
                    }
                    else
                    {
                        totalPrice = number * 20;
                    }
                }
            }
            if (day == "Sunday")
            {
                if (type == "Students")
                {
                    if (number >= 30)
                    {
                        discount = 10.46 * 0.15;

                        totalPrice = (number * 10.46) - (number * discount);
                    }
                    else
                    {
                        totalPrice = number * 10.46;
                    }
                }
                else if (type == "Business")
                {
                    if (number >= 100)
                    {
                        number -= 10;
                        totalPrice = number * 16;
                    }
                    else
                    {
                        totalPrice = number * 16;
                    }
                }
                else if (type == "Regular")
                {
                    if (number >= 10 && number <= 20)
                    {
                        discount = 22.50 * 0.05;
                        totalPrice = (number * 22.50) - (number * discount);
                    }
                    else
                    {
                        totalPrice = number * 22.50;
                    }
                }
            }

            Console.WriteLine($"Total price: {totalPrice:f2}");

            
        }
    }
}
