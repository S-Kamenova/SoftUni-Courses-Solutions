using System;

namespace E04.SumOfChars
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int sum = 0;


            for (int i = 0; i < n; i++)
            {
                char digit = char.Parse(Console.ReadLine());

                // sum += int.Parse(digit.ToString()); == sum += (int)digit;
                sum += (int)digit;

            }

            Console.WriteLine($"The sum equals: {sum}");
        }
    }
}
