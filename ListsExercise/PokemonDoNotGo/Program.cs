using System;
using System.Collections.Generic;
using System.Linq;

namespace PokemonDoNotGo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();

            int index = int.Parse(Console.ReadLine());
            List<int> removed = new List<int>();
            int removedItem = 0;

            while (list.Count != 0)
            {
                if (index >= 0 && index < list.Count)
                {
                    removedItem = list[index];
                    removed.Add(list[index]);
                    list.RemoveAt(index);

                    IncreaseDecrease(list, removedItem);
                   
                }
                else if (index < 0)
                {
                    removedItem = list[0];
                    removed.Add(removedItem);
                    list[0] = list[list.Count - 1];
                    IncreaseDecrease(list, removedItem);
                }
                else if (index > list.Count - 1)
                {
                    removedItem = list[list.Count - 1];
                    removed.Add(removedItem);
                    list[list.Count - 1] = list[0];
                    IncreaseDecrease(list, removedItem);


                }
                if (list.Count != 0)
                {
                    index = int.Parse(Console.ReadLine());
                }
                else
                {
                    break;
                }
            }

            Console.WriteLine(removed.Sum());
        }

        static List<int> IncreaseDecrease(List<int> list, int removedItem)
        {
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] <= removedItem)
                {
                    list[i] += removedItem;
                }
                else if (list[i] > removedItem)
                {
                    list[i] -= removedItem;
                }
            }

            return list;
        }
    }
}
