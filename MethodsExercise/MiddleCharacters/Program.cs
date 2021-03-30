using System;

namespace MiddleCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            GetMiddleElement(text);
        }

        static void GetMiddleElement (string text)
        {
            int middleElement = text.Length / 2;

            if (text.Length % 2 == 0)
            {
                Console.Write(text[middleElement - 1]); 
                Console.WriteLine(text[middleElement]); 
            }
            else
            {
                Console.WriteLine(text[middleElement]);
            }
        }


    }
}
