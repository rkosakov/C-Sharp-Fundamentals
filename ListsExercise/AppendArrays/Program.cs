using System;
using System.Collections.Generic;
using System.Linq;

namespace AppendArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = Console.ReadLine().Split('|', StringSplitOptions.RemoveEmptyEntries).ToList();

            list.Reverse();
            List<string> reversed = new List<string>();

            for (int i = 0; i < list.Count; i++)
            {
                string[] splitted = list[i].Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();
                reversed.AddRange(splitted);

                
            }

            


            Console.WriteLine(String.Join(' ', reversed));


        }
    }
}
