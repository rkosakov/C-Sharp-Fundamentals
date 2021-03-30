using System;
using System.Linq;

namespace ArrayRotation
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int rotaion = int.Parse(Console.ReadLine());

            for (int i = 1; i <= rotaion; i++)
            {
                int firstElement = numbers[0];
                int[] temp = new int[numbers.Length];

                for (int j = 0; j < numbers.Length - 1; j++)
                {
                    temp[j] = numbers[j + 1];

                }
                temp[temp.Length - 1] = firstElement;
                numbers = temp;
            }
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
