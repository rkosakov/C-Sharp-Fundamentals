using System;
using System.Collections.Generic;
using System.Linq;

namespace BombNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();
            string[] elements = Console.ReadLine().Split();
            int number = int.Parse(elements[0]);
            int power = int.Parse(elements[1]);

            int numberIndex = list.IndexOf(number);

            while (numberIndex != -1)
            {
                int startIndex = numberIndex - power;
                int endIndex = numberIndex + power;

                if (startIndex < 0)
                {
                    startIndex = 0;
                }

                if (endIndex > list.Count - 1)
                {
                    endIndex = list.Count - 1;
                }
                list.RemoveRange(startIndex, endIndex - startIndex + 1);
                numberIndex = list.IndexOf(number);
            }

            Console.WriteLine(list.Sum());
        }
    }
}
