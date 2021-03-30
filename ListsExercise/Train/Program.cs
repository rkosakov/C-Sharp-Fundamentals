using System;
using System.Collections.Generic;
using System.Linq;

namespace Train
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();
            int maxCapacity = int.Parse(Console.ReadLine());

            string input = String.Empty;

            while ((input = Console.ReadLine()) != "end")
            {
                string[] command = input.Split();

                if (command[0] == "Add")
                {
                    int number = int.Parse(command[1]);
                    list.Add(number);
                }
                else 
                {
                    int number = int.Parse(command[0]);

                    for (int i = 0; i < list.Count; i++)
                    {
                        if (list[i] + number <= maxCapacity)
                        {
                            list[i] += number;
                            break;
                        }
                    }
                }
            }

            Console.WriteLine(String.Join(' ', list));

        }
    }
}
