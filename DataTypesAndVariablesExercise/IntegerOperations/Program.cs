using System;

namespace IntegerOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());
            int number3 = int.Parse(Console.ReadLine());
            int number4 = int.Parse(Console.ReadLine());

            int n = number1 + number2;
            int n1 = n / number3;
            int result = n1 * number4;
            Console.WriteLine(result);
        }
    }
}
