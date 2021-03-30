using System;

namespace CharactersInRange
{
    class Program
    {
        static void Main(string[] args)
        {
            char start = char.Parse(Console.ReadLine());
            char end = char.Parse(Console.ReadLine());
            if (end < start)
            {
                PrintChars(end, start);
            }

            else
            {
                PrintChars(start, end);
            }

        }

        static void PrintChars(char start, char end)
        {
            for (int i = start + 1; i < end; i++)
            {
                Console.Write((char)i + " ");
            }
        }
    }
}
