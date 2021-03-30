using System;
using System.Collections.Generic;
using System.Linq;

namespace RemoveNegativesAndReverse
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();

            for (int i = 0; i <= list.Count - 1; i++)
            {
                list.RemoveAll(i => i < 0);
            }

            if (list.Count == 0)
            {
                Console.WriteLine("empty");
            }

            list.Reverse();

            Console.WriteLine(String.Join(' ', list));
        }
    }
}
