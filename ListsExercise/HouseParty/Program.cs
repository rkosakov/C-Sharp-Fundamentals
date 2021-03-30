using System;
using System.Collections.Generic;

namespace HouseParty
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<string> names = new List<string>();

            string text = Console.ReadLine();

            for (int i = 1; i <= n; i++)
            {

                string[] elements = text.Split();

                if (elements.Length == 3)
                {
                    if (names.Contains(elements[0]))
                    {
                        Console.WriteLine($"{elements[0]} is already in the list!");
                    }
                    else
                    {
                        names.Add(elements[0]);
                    }
                }
                else
                {
                    if (names.Contains(elements[0]))
                    {
                        names.Remove(elements[0]);
                    }
                    else
                    {
                        Console.WriteLine($"{elements[0]} is not in the list!");
                    }
                }
                if (i != n)
                {
                    text = Console.ReadLine();
                }
            }

            Console.WriteLine(String.Join(Environment.NewLine, names));
        }
    }
}
