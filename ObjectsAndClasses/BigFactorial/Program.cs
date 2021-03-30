﻿using System;
using System.Numerics;

namespace BigFactorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(Factorial.CalculateFactorial(n));
        }
        

       
    }

    class Factorial
    {

        public static BigInteger CalculateFactorial(int n)
        {
            BigInteger factorial = 1;
            for (int i = 1; i <= n; i++)
            {
                factorial *= i;
            }

            return factorial;
        }
    }
}
