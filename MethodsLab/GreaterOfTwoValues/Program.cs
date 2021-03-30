using System;

namespace GreaterOfTwoValues
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();

            switch (type)
            {
                case "int":
                    int number1 = int.Parse(Console.ReadLine());
                    int number2 = int.Parse(Console.ReadLine());
                    Console.WriteLine(GetMax(number1, number2)); 
                    break;

                case "char":
                    char char1 = char.Parse(Console.ReadLine());
                    char char2 = char.Parse(Console.ReadLine());
                    Console.WriteLine(GetMax(char1, char2)); 
                    break;

                case "string":
                    string str1 = Console.ReadLine();
                    string str2 = Console.ReadLine();
                    Console.WriteLine(GetMax(str1, str2)); 
                    break;
            }


        }
        static int GetMax(int number1, int number2)
        {
            int compare = number1.CompareTo(number2);

            if (compare == 1)
            {
                return number1;
            }
            else
            {
                return number2;
            }
        }
        static char GetMax(char char1, char char2)
        {
            int compare = char1.CompareTo(char2);

            if (compare == 1)
            {
                return char1;
            }
            else
            {
                return char2;
            }
        }
        static string GetMax(string str1, string str2)
        {
            int compare = str1.CompareTo(str2);

            if (compare == 1)
            {
                return str1;
            }
            else
            {
                return str2;
            }
        }
    }
}
