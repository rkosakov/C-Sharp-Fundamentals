using System;

namespace PadawanEquipment
{
    class Program
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());
            int students = int.Parse(Console.ReadLine());
            double sabrePrice = double.Parse(Console.ReadLine());
            double robePrice = double.Parse(Console.ReadLine());
            double beltsPrice = double.Parse(Console.ReadLine());

            double sabresMore = 0.10 * students;
            double sabresNeeded = Math.Ceiling(sabresMore) + students;
            int beltsLess = students / 6;
            int beltsNeeded = students - beltsLess;

            double totalExp = sabrePrice * sabresNeeded + robePrice * students + beltsPrice * beltsNeeded;

            if (money >= totalExp)
            {
                Console.WriteLine($"The money is enough - it would cost {totalExp:f2}lv.");
            }
            else
            {
                Console.WriteLine($"Ivan Cho will need {(totalExp-money):f2}lv more.");
            }




        }
    }
}
