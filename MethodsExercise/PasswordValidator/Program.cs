using System;

namespace PasswordValidator
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();
            IsValid(password);
        }

        static bool IsLong(string password)
        {
            if (password.Length >= 6 && password.Length <= 10)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static bool LettersAndDigitts(string password)
        {

            for (int i = 0; i < password.Length; i++)
            {
                if (!(password[i] >= 48 && password[i] <= 57 || password[i] >= 65 && password[i] <= 90 || password[i] >= 97 && password[i] <= 122))
                {
                    return false;
                }
            }
            return true;

        }

        static bool AtLeastTwoDigits(string password)
        {
            int counterDigits = 0;
            for (int i = 0; i < password.Length; i++)
            {
                if (password[i] >= 48 && password[i] <= 57)
                {
                    counterDigits++;
                }

                if (counterDigits == 2)
                {
                    return true;
                }
            }

            return false;
        }

        static void IsValid(string password)
        {
            if (!IsLong(password))
            {
                Console.WriteLine("Password must be between 6 and 10 characters ");
            }
            if (!LettersAndDigitts(password))
            {
                Console.WriteLine("Password must consist only of letters and digits");
            }
            if (!AtLeastTwoDigits(password))
            {
                Console.WriteLine("Password must have at least 2 digits");
            }

            if (IsLong(password) && LettersAndDigitts(password) && AtLeastTwoDigits(password))
            {
                Console.WriteLine("Password is valid");

            }


        }
    }
}
