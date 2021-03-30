using System;
using System.Collections.Generic;
using System.Linq;

namespace ListOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();

            string input = string.Empty;

            while ((input = Console.ReadLine()) != "End")
            {
                string[] command = input.Split();

                if (command[0] == "Add")
                {
                    int number = int.Parse(command[1]);

                    list.Add(number);
                }
                else if (command[0] == "Insert")
                {
                    int number = int.Parse(command[1]);
                    int index = int.Parse(command[2]);

                    if (index >= 0 && index <= list.Count - 1)
                    {
                        list.Insert(index, number);
                    }
                    else
                    {
                        Console.WriteLine("Invalid index");
                    }
                }
                else if (command[0] == "Remove")
                {
                    int index = int.Parse(command[1]);

                    if (index >= 0 && index <= list.Count - 1)
                    {
                        list.RemoveAt(index);
                    }
                    else
                    {
                        Console.WriteLine("Invalid index");
                    }
                }
                else if (command[0] == "Shift")
                {
                    int count = int.Parse(command[2]);

                    if (command[1] == "left")
                    {
                        for (int i = 1; i <= count; i++)
                        {
                            int firstNum = list[0];
                            list.Add(firstNum);
                            list.RemoveAt(0);
                        }
                    }
                    else
                    {
                        for (int i = 1; i <= count; i++)
                        {
                            int lastNum = list[list.Count - 1];
                            list.Insert(0, lastNum);
                            list.RemoveAt(list.Count - 1);
                        }
                    }
                }
            }

            Console.WriteLine(String.Join(' ', list));
        }
    }
}
