using System;

namespace E08.FactorialDivision
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());

            double result1 = Factorial(first);
            double result2 = Factorial(second);

            Console.WriteLine($"{result1/result2:f2}");
        }

        private static double Factorial(int num)
        {
            double result = 1;
            while (num!=1)
            {
                result *= num;
                num--;
            }
            return result;
        }
       
    }
}
