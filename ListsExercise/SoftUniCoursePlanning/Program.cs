using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;

namespace SoftUniCoursePlanning//not the full one
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = Console.ReadLine().Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries).ToList();
            string toExcercise = String.Empty;

            string input = String.Empty;

            while ((input = Console.ReadLine()) != "course start")
            {
                string[] elements = input.Split(':', StringSplitOptions.RemoveEmptyEntries).ToArray();

                if (elements[0] == "Add")
                {
                    if (list.Contains(elements[1]))
                    {
                        continue;
                    }
                    else
                    {
                        list.Add(elements[1]);
                    }
                }
                else if (elements[0] == "Insert")
                {
                    if (list.Contains(elements[1]))
                    {
                        continue;
                    }
                    else
                    {
                        int index = int.Parse(elements[2]);
                        list.Insert(index, elements[1]);
                    }
                }
                else if (elements[0] == "Remove")
                {
                    if (list.Contains(elements[1]))
                    {
                        int index = list.IndexOf(elements[1]);
                        if (list[index + 1] == $"{elements[1]}-Exercise")
                        {
                            list.RemoveRange(index, 2);
                        }
                        else
                        {
                            list.Remove(elements[1]);
                        }
                    }
                    else
                    {
                        continue;
                    }
                }
                else if (elements[0] == "Swap")
                {
                    if (list.Contains(elements[1]) && list.Contains(elements[2]))
                    {
                        int indexOfFirst = list.IndexOf(elements[1]);
                        int indexOfSecond = list.IndexOf(elements[2]);

                        if (list[indexOfFirst + 1] == (elements[1] + "-Exercise"))
                        {
                            list.Insert(indexOfSecond + 1, (elements[1] + "-Exercise"));
                        }

                        else if (list[indexOfSecond + 1] == (elements[1] + "-Exercise"))
                        {
                            list.Insert(indexOfFirst + 1, (elements[1] + "-Exercise"));
                        }

                        string temp = list[list.IndexOf(elements[2])];
                        list[list.IndexOf(elements[2])] = list[list.IndexOf(elements[1])];
                        list[list.IndexOf(elements[1])] = temp;
                    }
                    else
                    {
                        continue;
                    }
                }
                else if (elements[0] == "Exercise")
                {
                    if (list.Contains(elements[1]))
                    {
                        list.IndexOf(elements[1]);
                        toExcercise = elements[1];
                        string excercise = elements[1] + "-Exercise";
                        list.Insert((list.IndexOf(elements[1]) + 1), excercise);

                        if (list.Contains(toExcercise))
                        {
                            int indexOfTopic = list.IndexOf(toExcercise);
                            string topic = toExcercise + "-Exercise";

                            if (list[indexOfTopic + 1] != "topic")
                            {
                                int exIndex = list.FindLastIndex(i => i == "topic");
                                list.Insert(indexOfTopic + 1, list[exIndex]);
                            }
                        }
                    }
                    else
                    {
                        string excercise = elements[1] + "-Exercise";
                        list.Add(elements[1]);
                        list.Add(excercise);

                        if (list.Contains(toExcercise))
                        {
                            int indexOfTopic = list.IndexOf(toExcercise);
                            string topic = toExcercise + "-Exercise";

                            if (list[indexOfTopic + 1] != "topic")
                            {
                                int exIndex = list.FindLastIndex(i => i == "topic");
                                list.Insert(indexOfTopic + 1, list[exIndex]);
                            }
                        }
                    }
                }
            }
            for (int i = 1; i <= list.Count; i++)
            {
                Console.WriteLine($"{i}.{list[i - 1]}");
            }
        }
    }
}
