using System;

namespace BeerKegs
{
    class Program
    {
        static void Main(string[] args)
        {
            byte n = byte.Parse(Console.ReadLine());
            float maxVolume = float.MinValue;
            string maxModel = string.Empty;

            for (int i = 1; i <= n; i++)
            {
                string model = Console.ReadLine();
                float radius = float.Parse(Console.ReadLine());
                int height = int.Parse(Console.ReadLine());

                float volume = (float) (Math.PI * Math.Pow(radius, 2) * height);

                if (volume > maxVolume)
                {
                    maxVolume = volume;
                    maxModel = model;
                }
            }

            Console.WriteLine(maxModel);
        }
    }
}
