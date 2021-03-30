using System;

namespace TriplesOfLatinLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    for (int k = 0; k < n; k++)
                    {
                        char char1 = (char)('a' + i);
                        char char2 = (char)('a' + j);
                        char char3 = (char)('a' + k);
                        Console.WriteLine($"{char1}{char2}{char3}");
                    }
                }
            }
        }
    }
}
