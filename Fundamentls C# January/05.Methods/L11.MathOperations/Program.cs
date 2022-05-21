using System;

namespace L11.MathOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            double first = double.Parse(Console.ReadLine());
            string @operator = Console.ReadLine();
            double second = double.Parse(Console.ReadLine());
            double result = Calculate(first, @operator, second);
            Console.WriteLine(result);


        }
        static double Calculate(double first, string @operatotr, double second)
        {
            double result = 1;
            if (operatotr=="/")
            {
                result = first / second;
            }
            else if (operatotr == "*")
            {
                result = first * second;
            }
            else if (operatotr == "+")
            {
                result = first + second;
            }
            else if (operatotr == "-")
            {
                result = first - second;
            }
            return result;
        }
    }
}
