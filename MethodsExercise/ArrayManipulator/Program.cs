using System;
using System.Linq;

namespace ArrayManipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            string input = string.Empty;

            while ((input = Console.ReadLine()) != "end")
            {
                string[] command = input.Split();
                if (command[0] == "exchange")
                {
                    int index = int.Parse(command[1]);

                    if (!(index >= 0 && index <= arr.Length - 1))
                    {
                        Console.WriteLine("Invalid index");
                        continue;
                    }
                    Exchange(arr, index);

                }

                else if (command[0] == "max")
                {
                    if (command[1] == "even")
                    {
                        if (MaxEven(arr) == -1)
                        {
                            Console.WriteLine("No matches");
                            continue;
                        }
                        Console.WriteLine(MaxEven(arr)); 
                    }
                    else
                    {
                        if (MaxOdd(arr) == -1)
                        {
                            Console.WriteLine("No matches");
                            continue;
                        }
                        Console.WriteLine(MaxOdd(arr));
                    }
                }

                else if (command[0] == "min")
                {
                    if (command[1] == "even")
                    {
                        if (MinEven(arr) == -1)
                        {
                            Console.WriteLine("No matches");
                            continue;
                        }

                        Console.WriteLine(MinEven(arr)); 
                    }
                    else
                    {
                        if (MinOdd(arr) == -1)
                        {
                            Console.WriteLine("No matches");
                            continue;
                        }
                        Console.WriteLine(MinOdd(arr));

                    }
                }

                else if (command[0] == "first")
                {
                    int count = int.Parse(command[1]);

                    if (count > arr.Length)
                    {
                        Console.WriteLine("Invalid count");
                        continue;
                    }

                    if (command[2] == "even")
                    {
                        ReturnFirstEven(arr, count);
                    }
                    else
                    {
                        ReturnFirstOdd(arr, count);
                    }
                }

                else if (command[0] == "last")
                {
                    int count = int.Parse(command[1]);

                    if (count > arr.Length)
                    {
                        Console.WriteLine("Invalid count");
                        continue;
                    }

                    if (command[2] == "even")
                    {
                        ReturnLastEven(arr, count);
                    }
                    else
                    {
                        ReturnLastOdd(arr, count);
                    }



                }



            }
                Console.WriteLine("[" + String.Join(", ", arr) + "]");

            static void Exchange(int[] arr, int index)
            {
                int[] firstArray = new int[arr.Length - index - 1];
                int[] secondArray = new int[index + 1];

                int firstArrCounter = 0;

                for (int i = index + 1; i < arr.Length; i++)
                {
                    firstArray[firstArrCounter] = arr[i];
                    firstArrCounter++;
                }

                for (int i = 0; i < index + 1; i++)
                {
                    secondArray[i] = arr[i];
                }

                for (int i = 0; i < firstArray.Length; i++)
                {
                    arr[i] = firstArray[i];
                }

                for (int i = 0; i < secondArray.Length; i++)
                {
                    arr[firstArray.Length + i] = secondArray[i];
                }
            }

            static int MaxEven(int[] arr)
            {
                int maxNumber = int.MinValue;
                int index = -1;

                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] % 2 == 0)
                    {
                        if (arr[i] >= maxNumber)
                        {
                            maxNumber = arr[i];
                            index = i;
                        }
                    }
                }

                return index;
            }

            static int MaxOdd(int[] arr)
            {
                int maxOdd = int.MinValue;
                int index = -1;

                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] % 2 != 0)
                    {
                        if (arr[i] >= maxOdd)
                        {
                            maxOdd = arr[i];
                            index = i;
                        }
                    }
                }

                return index;
            }

            static int MinEven(int[] arr)
            {
                int minNumber = int.MaxValue;
                int index = -1;

                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] % 2 == 0)
                    {
                        if (arr[i] <= minNumber)
                        {
                            minNumber = arr[i];
                            index = i;
                        }
                    }
                }

                return index;
            }

            static int MinOdd (int[] arr)
            {
                int minNumber = int.MaxValue;
                int index = -1;

                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] % 2 != 0)
                    {
                        if (arr[i] <= minNumber)
                        {
                            minNumber = arr[i];
                            index = i;
                        }
                    }
                }

                return index;
            }

            static void ReturnFirstEven (int[] arr, int count)
            {
                string numbers = string.Empty;
                int counter = 0;
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] % 2 == 0)
                    {
                        numbers += arr[i] + " ";
                        counter++;
                    }

                    if (counter == count)
                    {
                        break;
                    }
                }

                var result = numbers.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                if (counter == 0)
                {
                    Console.WriteLine("[]");
                }

                else
                {
                    Console.WriteLine("[" + String.Join( ", ", result ) + "]");
                }
                

            }

            static void ReturnFirstOdd(int[] arr, int count)
            {
                string numbers = string.Empty;
                int counter = 0;
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] % 2 != 0)
                    {
                        numbers += arr[i] + " ";
                        counter++;
                    }

                    if (counter == count)
                    {
                        break;
                    }
                }

                var result = numbers.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                if (counter == 0)
                {
                    Console.WriteLine("[]");
                }

                else
                {
                    Console.WriteLine("[" + String.Join(", ", result) + "]");
                }


            }

            static void ReturnLastEven(int[] arr, int count)
            {
                string numbers = string.Empty;
                int counter = 0;

                for (int i = arr.Length-1; i >= 0; i--)
                {
                    if (arr[i] % 2 == 0)
                    {
                        numbers += arr[i] + " ";
                        counter++;
                    }

                    if (counter == count)
                    {
                        break;
                    }
                }

                var result = numbers.Split(' ', StringSplitOptions.RemoveEmptyEntries).Reverse();

                if (counter == 0)
                {
                    Console.WriteLine("[]");
                }

                else
                {
                    Console.WriteLine("[" + String.Join(", ", result) + "]");
                }

            }

            static void ReturnLastOdd(int[] arr, int count)
            {
                string numbers = string.Empty;
                int counter = 0;

                for (int i = arr.Length - 1; i >= 0; i--)
                {
                    if (arr[i] % 2 != 0)
                    {
                        numbers += arr[i] + " ";
                        counter++;
                    }

                    if (counter == count)
                    {
                        break;
                    }
                }

                var result = numbers.Split(' ', StringSplitOptions.RemoveEmptyEntries).Reverse();

                if (counter == 0)
                {
                    Console.WriteLine("[]");
                }

                else
                {
                    Console.WriteLine("[" + String.Join(", ", result) + "]");
                }

            }
        }
    }
}
