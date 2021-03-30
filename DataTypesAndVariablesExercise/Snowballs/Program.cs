using System;
using System.Numerics;

namespace Snowballs
{
    class Program
    {
        static void Main(string[] args)
        {
            byte n = byte.Parse(Console.ReadLine());
            BigInteger maxSnowballValue = 0;
            ushort maxSnowballSnow = 0;
            ushort maxSnowballTime = 0;
            byte maxSnowballQuality = 0;

            for (int i = 1; i <= n; i++)
            {
                ushort snowballSnow = ushort.Parse(Console.ReadLine());
                ushort snowballTime = ushort.Parse(Console.ReadLine());
                byte snowballQuality = byte.Parse(Console.ReadLine());

                if (snowballTime > 0)
                {

                    BigInteger snowballValue = BigInteger.Pow((snowballSnow / snowballTime), snowballQuality);

                    if (maxSnowballValue <= snowballValue)
                    {
                        maxSnowballValue = snowballValue;
                        maxSnowballSnow = snowballSnow;
                        maxSnowballTime = snowballTime;
                        maxSnowballQuality = snowballQuality;
                    }
                }
            }
            Console.WriteLine($"{maxSnowballSnow} : {maxSnowballTime} = {maxSnowballValue} ({maxSnowballQuality})");
        }
    }
}
