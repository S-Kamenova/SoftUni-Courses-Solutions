using System;

namespace L08.MathPower
{
    class Program
    {
        static void Main(string[] args)
        {
            double @base = double.Parse(Console.ReadLine());
            int power = int.Parse(Console.ReadLine());
            double result = GetPow(@base, power);
            Console.WriteLine(result);
        }
        static double GetPow(double number, int power)
        {
            //double result = Math.Pow(number, power);
            double result = 1;

            for (int i = 0; i < power; i++)
            {
                result *= number;
            }
            return result;
        }

    }
}
