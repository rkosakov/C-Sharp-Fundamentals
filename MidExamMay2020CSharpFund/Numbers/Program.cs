using System;
using System.Collections.Generic;
using System.Linq;

namespace Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            int sum = 0;

            for (int i = 0; i < numbers.Count; i++)
            {
                sum += numbers[i];
            }

            double average = sum * 1.0 / numbers.Count;
            List<int> biggerThanAverage = new List<int>();

            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] > average)
                {
                    biggerThanAverage.Add(numbers[i]);
                }
            }

            if (biggerThanAverage.Count <= 5 && biggerThanAverage.Count > 0)
            {
                biggerThanAverage.Sort();
                biggerThanAverage.Reverse();
                Console.WriteLine(String.Join(' ', biggerThanAverage));
            }
            else if (biggerThanAverage.Count > 5)
            {
                while (biggerThanAverage.Count != 5)
                {
                    biggerThanAverage.RemoveAt(0);
                }

                biggerThanAverage.Sort();
                biggerThanAverage.Reverse();
                Console.WriteLine(String.Join(' ', biggerThanAverage));
            }
            else if (biggerThanAverage.Count == 0)
            {
                Console.WriteLine("No");
            }
        }
    }
}
