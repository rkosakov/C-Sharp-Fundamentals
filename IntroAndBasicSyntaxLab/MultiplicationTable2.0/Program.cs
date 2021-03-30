using System;

namespace MultiplicationTable2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());

            if (y > 10)
            {
                Console.WriteLine($"{n} X {y} = {n * y}");
            }
            else
            {
                for (int i = y; i <= 10; i++)
                {
                    
                        Console.WriteLine($"{n} X {i} = {n * i}");
                    
                }
            }
        }
    }
}
