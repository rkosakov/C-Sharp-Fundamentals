using System;

namespace SmallestOfThreeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());

            Console.WriteLine(FindSmallest(num1, num2, num3));
        }

        static int FindSmallest(int num1, int num2, int num3)
        {
            int minNum = Math.Min(Math.Min(num1, num2), num3);

            return minNum;
        }
    }
}
