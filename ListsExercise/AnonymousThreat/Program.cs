using System;
using System.Collections.Generic;
using System.Linq;

namespace AnonymousThreat
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = Console.ReadLine().Split().ToList();

            string input = string.Empty;

            while ((input = Console.ReadLine()) != "3:1")
            {
                string[] command = input.Split();

                if (command[0] == "merge")
                {
                    int startIndex = int.Parse(command[1]);
                    int endIndex = int.Parse(command[2]);

                    Merge(list, startIndex, endIndex);


                }
                else if (command[0] == "divide")
                {
                    int index = int.Parse(command[1]);
                    int partition = int.Parse(command[2]);

                    Divide(list, index, partition);

                }
            }

            Console.WriteLine(String.Join(" ",list));

        }

        static void Merge(List<string> list, int startIndex, int endIndex)
        {
            if (startIndex < 0)
            {
                startIndex = 0;
            }
            if (endIndex > list.Count - 1)
            {
                endIndex = list.Count - 1;
            }

            for (int i = startIndex + 1; i <= endIndex; i++)
            {
                list[startIndex] += list[startIndex + 1];
                list.RemoveAt(startIndex + 1);
            }
        }

        static void Divide(List<string> list, int index, int partition)
        {
            string partitionData = list[index];
            list.RemoveAt(index);
            int partSize = partitionData.Length / partition;
            int reminder = partitionData.Length % partition;

            List<string> tmpData = new List<string>();

            for (int i = 0; i < partition; i++)
            {
                string tmpString = null;

                for (int p = 0; p < partSize; p++)
                {
                    tmpString += partitionData[(i * partSize) + p];
                }

                if (i == partition - 1 && reminder != 0)
                {
                    tmpString += partitionData.Substring(partitionData.Length - reminder);
                }

                tmpData.Add(tmpString);
            }

            list.InsertRange(index, tmpData);

        }


    }
}
