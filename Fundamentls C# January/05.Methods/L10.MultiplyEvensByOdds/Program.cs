using System;

namespace L10.MultiplyEvensByOdds
{
    class Program
    {
        static void Main(string[] args)
        {
            int number =Math.Abs( int.Parse(Console.ReadLine()));
            var sumOfEvenDigits = GetSumOfEvenDigit(number);
            var sumOfOddDigits = GetSumOfOddDigit(number);
            Console.WriteLine(sumOfEvenDigits*sumOfOddDigits);
        }

        static int GetSumOfEvenDigit(int number)
        {
            int sum = 0;

            while (number!=0)
            {
                int digit = number % 10;
                if (digit%2==0)
                {
                    sum += digit % 10;
                }
                number /= 10;
            }
            return sum;
        }
        static int GetSumOfOddDigit(int number)
        {
            int sum = 0;

            while (number != 0)
            {
                int digit = number % 10;
                if (digit % 2 != 0)
                {
                    sum += digit % 10;
                }
                number /= 10;
            }
            return sum;
        }
    }
}
