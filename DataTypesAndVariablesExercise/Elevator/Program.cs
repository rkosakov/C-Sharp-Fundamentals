using System;

namespace Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());
            int space = int.Parse(Console.ReadLine());

            int courses = people / space;

            if (people % space != 0)
            {
                courses++;
            }

            Console.WriteLine(courses);
        }
    }
}
