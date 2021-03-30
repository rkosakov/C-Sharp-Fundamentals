using System;
using System.Linq;

namespace ArrayModifier
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            string input = string.Empty;
            while ((input = Console.ReadLine()) != "end")
            {
                string[] command = input.Split();

                if (command[0] == "swap")
                {
                    int index1 = int.Parse(command[1]);
                    int index2 = int.Parse(command[2]);
                    Swap(numbers, index1, index2);
                }
                else if (command[0] == "multiply")
                {
                    int index1 = int.Parse(command[1]);
                    int index2 = int.Parse(command[2]);
                    Multiply(numbers, index1, index2);
                }
                else if (command[0] == "decrease")
                {
                    Decrease(numbers);
                }
            }

            Console.WriteLine(String.Join(", ", numbers));

        }

        static void Swap(int[] numbers, int index1, int index2)
        {
            int temp = numbers[index2];
            numbers[index2] = numbers[index1];
            numbers[index1] = temp;
        }

        static void Multiply(int[] numbers, int index1, int index2)
        {
            int product = numbers[index1] * numbers[index2];
            numbers[index1] = product;
        }

        static void Decrease(int[] numbers)
        {
            for (int i = 0; i <= numbers.Length - 1; i++)
            {
                numbers[i]--;
            }
        }
    }
}
