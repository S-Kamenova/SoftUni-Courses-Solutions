using System;

namespace L03.Exact_Sum_of_Real_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal numbers = decimal.Parse(Console.ReadLine());
            decimal sum = 0;

            for (int i = 1; i <= numbers; i++)
            {
                var n= decimal.Parse(Console.ReadLine());
                sum += n;
            }

            Console.WriteLine(sum);
        }
    }
}
