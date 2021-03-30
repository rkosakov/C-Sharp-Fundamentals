using System;

namespace SoftUniReception
{
    class Program
    {
        static void Main(string[] args)
        {
            int employee1 = int.Parse(Console.ReadLine());
            int employee2 = int.Parse(Console.ReadLine());
            int employee3 = int.Parse(Console.ReadLine());

            int students = int.Parse(Console.ReadLine());
            int totalAnswers = employee1 + employee2 + employee3;
            int hours = 0;
            int hoursCount = 1;

            while (students >= 0)
            {

                if (hoursCount % 4 == 0)
                {
                    hours++;
                    hoursCount++;
                }
                else
                {
                    students -= totalAnswers;
                    hours++;
                    hoursCount++;
                }
            }
            Console.WriteLine($"Time needed: {hours}h.");
        }
    }
}
