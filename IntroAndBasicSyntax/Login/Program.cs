﻿using System;

namespace Login
{
    class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            string password = string.Empty;

            for (int i = username.Length - 1; i >= 0; i--)
            {
                password += username[i];
            }

            string input = Console.ReadLine();
            int counter = 1;

            while (input != password)
            {
                if (counter >= 4)
                {
                    Console.WriteLine($"User {username} blocked!");
                    break;
                }
                Console.WriteLine("Incorrect password. Try again.");
                counter++;
                input = Console.ReadLine();
            }

            if (input == password)
            {
                Console.WriteLine($"User {username} logged in.");
            }
        }
    }
}
