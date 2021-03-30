using System;
using System.Linq;

namespace Zig_ZagArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr1 = new int[n];
            int[] arr2 = new int[n];

            for (int i = 1; i <= n; i++)
            {
                int[] currentRow = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();

                if (i % 2 == 0)
                {
                    arr1[i - 1] = currentRow[0];
                    arr2[i - 1] = currentRow[1];
                }
                else
                {
                    arr1[i - 1] = currentRow[1];
                    arr2[i - 1] = currentRow[0];
                }
            }

            Console.WriteLine(string.Join(" ", arr2));
            Console.WriteLine(string.Join(" ", arr1));

        }
    }
}
