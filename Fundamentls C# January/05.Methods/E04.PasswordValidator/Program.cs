using System;

namespace E04.PasswordValidator
{
    class Program
    {
        static void Main(string[] args)
        {
            string pass = Console.ReadLine();
            const int minLenght = 6;
            const int maxLenght = 10;
            int minDigitCount = 2;

            bool isPassValid=Validation(pass, minLenght, maxLenght, minDigitCount);
            if (isPassValid)
            {
                Console.WriteLine("Password is valid");
            }
        }
        static bool Validation(string pass, int minLenght, int maxLenght, int minDigitCount)
        {
            

            bool isPassValid = true;
            if (!ValidateLenht(pass, minLenght,maxLenght))
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
                isPassValid = false;
            }
            if (!ValidatePassIsAlphaNumerical(pass))
            {
                Console.WriteLine("Password must consist only of letters and digits");
                isPassValid = false;
            }
            
            if (!ValidatePassDigit(pass,minDigitCount))
            {
                Console.WriteLine("Password must have at least 2 digits");
                isPassValid = false;
            }
            return isPassValid;
            
        }
        static bool ValidateLenht(string pass, int minLenght, int maxLenght)
        {
            if (pass.Length>=minLenght && pass.Length<=maxLenght )
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static bool ValidatePassIsAlphaNumerical(string pass)
        {
            foreach (char ch in pass)
            {
                if (!char.IsLetterOrDigit(ch))
                {
                    return false;

                }
            }
            return true;
        }
        static bool ValidatePassDigit(string pass, int minDigitCount)
        {
            int digitCount = 0;
            foreach (char ch in pass)
            {
                if (char.IsDigit(ch))
                {
                    digitCount++;
                }
            }
            return digitCount >= minDigitCount;
        }
    }
}
