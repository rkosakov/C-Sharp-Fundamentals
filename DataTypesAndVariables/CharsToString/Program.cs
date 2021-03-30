using System;

namespace CharsToString
{
    class Program
    {
        static void Main(string[] args)
        {
            char char1 = char.Parse(Console.ReadLine());
            char char2 = char.Parse(Console.ReadLine());
            char char3 = char.Parse(Console.ReadLine());

            string str1 = char1.ToString();
            string str2 = char2.ToString();
            string str3 = char3.ToString();

            Console.WriteLine(str1 + str2 + str3);
        }
    }
}
