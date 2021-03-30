using System;
using System.Collections.Generic;
using System.Linq;

namespace ListManipulationBasics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();

            string command = String.Empty;

            while ((command = Console.ReadLine()) != "end")
            {
                string[] elements = command.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                if (elements[0] == "Add")
                {
                    int number = int.Parse(elements[1]);
                    Add(list, number);
                }
                else if (elements[0] == "Remove")
                {
                    int number = int.Parse(elements[1]);
                    Remove(list, number);
                }
                else if (elements[0] == "RemoveAt")
                {
                    int index = int.Parse(elements[1]);
                    RemoveAt(list, index);
                }
                else if (elements[0] == "Insert")
                {
                    int index = int.Parse(elements[2]);
                    int number = int.Parse(elements[1]);
                    Insert(list, number, index);
                }
            }

            Console.WriteLine(String.Join(' ', list));
        }

        static void Add(List<int> list, int number)
        {
            list.Add(number);
        }

        static void Remove(List<int> list, int number)
        {
            list.Remove(number);
        }

        static void RemoveAt(List<int> list, int index)
        {
            list.RemoveAt(index);
        }

        static void Insert(List<int> list, int number, int index)
        {
            list.Insert(index, number);
        }
    }
}
