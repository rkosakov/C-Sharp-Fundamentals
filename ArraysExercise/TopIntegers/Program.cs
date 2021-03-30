using System;
using System.Linq;
using System.Net.Http.Headers;

namespace TopIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                 .Split()
                 .Select(int.Parse)
                 .ToArray();
            for (int i = 0; i < numbers.Length; i++)
            {
                bool isTopInt = true;
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[i] <= numbers[j])
                    {
                        isTopInt = false;
                        break;
                    }
                }

                if (isTopInt)
                {
                    Console.Write(numbers[i] + " ");
                }
                
            }

        }
    }
}
