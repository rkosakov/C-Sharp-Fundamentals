using System;
using System.Collections.Generic;
using System.Linq;

namespace ListManipulationAdvanced
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();

            string command = string.Empty;
            bool shouldPrintArray = false;

            while ((command = Console.ReadLine()) != "end")
            {
                string[] elements = command.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                if (elements[0] == "Contains")
                {
                    int number = int.Parse(elements[1]);
                    Contains(list, number);
                }
                else if (elements[0] == "PrintEven")
                {
                    PrintEven(list);
                }
                else if (elements[0] == "PrintOdd")
                {
                    PrintOdd(list);
                }
                else if (elements[0] == "GetSum")
                {
                    GetSum(list);
                }
                else if (elements[0] == "Filter")
                {
                    string @operator = elements[1];
                    int num = int.Parse(elements[2]);
                    Filter(list, @operator, num);
                }
                else if (elements[0] == "Add")
                {
                    int number = int.Parse(elements[1]);
                    Add(list, number);
                    shouldPrintArray = true;
                }
                else if (elements[0] == "Remove")
                {
                    int number = int.Parse(elements[1]);
                    Remove(list, number);
                    shouldPrintArray = true;
                }
                else if (elements[0] == "RemoveAt")
                {
                    int index = int.Parse(elements[1]);
                    RemoveAt(list, index);
                    shouldPrintArray = true;
                }
                else if (elements[0] == "Insert")
                {
                    int index = int.Parse(elements[2]);
                    int number = int.Parse(elements[1]);
                    Insert(list, number, index);
                    shouldPrintArray = true;
                }
            }

            if (shouldPrintArray)
            {
                Console.WriteLine(String.Join(' ', list));
            }
        }
        static void Contains(List<int> list, int number)
        {
            bool isContained = list.Contains(number);

            if (isContained)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No such number");
            }
        }

        static void PrintEven(List<int> list)
        {
            List<int> evenList = new List<int>();

            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] % 2 == 0)
                {
                    evenList.Add(list[i]);
                }
            }

            Console.WriteLine(String.Join(' ', evenList));
        }

        static void PrintOdd(List<int> list)
        {
            List<int> oddList = new List<int>();

            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] % 2 != 0)
                {
                    oddList.Add(list[i]);
                }
            }

            Console.WriteLine(String.Join(' ', oddList));
        }

        static void GetSum(List<int> list)
        {
            int sum = 0;

            for (int i = 0; i < list.Count; i++)
            {
                sum += list[i];
            }

            Console.WriteLine(sum);
        }

        static void Filter(List<int> list, string @operator, int num)
        {
            List<int> filtered = new List<int>();

            if (@operator == "<")
            {
                foreach (int number in list)
                {
                    if (number < num)
                    {
                        filtered.Add(number);
                    }
                }
            }
            else if (@operator == ">")
            {
                foreach (int number in list)
                {
                    if (number > num)
                    {
                        filtered.Add(number);
                    }
                }
            }
            else if (@operator == ">=")
            {
                foreach (int number in list)
                {
                    if (number >= num)
                    {
                        filtered.Add(number);
                    }
                }
            }
            else if (@operator == "<=")
            {
                foreach (int number in list)
                {
                    if (number <= num)
                    {
                        filtered.Add(number);
                    }
                }
            }

            Console.WriteLine(String.Join(' ', filtered));
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

