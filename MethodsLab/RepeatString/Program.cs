using System;
using System.Text;

namespace RepeatString
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            int times = int.Parse(Console.ReadLine());
            Console.WriteLine(PrintString(text, times));
        }

        static string PrintString (string text, int times)
        {
            StringBuilder result = new StringBuilder();

            for (int i = 1; i <= times; i++)
            {
                result.Append(text);
                
            }
            return result.ToString();
            
        }
    }
}
