﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace ChangeList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();

            string input = String.Empty;

            while ((input = Console.ReadLine()) != "end")
            {
                string[] command = input.Split();

                if (command[0] == "Delete")
                {
                    int number = int.Parse(command[1]);
                    list.RemoveAll(x => x == number);
                }
                else if (command[0] == "Insert")
                {
                    int number = int.Parse(command[1]);
                    int index = int.Parse(command[2]);

                    list.Insert(index, number);
                }
            }

            Console.WriteLine(String.Join(' ', list));
        }
    }
}
