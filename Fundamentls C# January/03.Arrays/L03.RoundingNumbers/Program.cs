using System;
using System.Linq;

namespace L03.RoundingNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //    double[] numbers = Console.ReadLine()
            //        .Split()
            //        .Select(double.Parse)
            //        .ToArray();


            string[] input = Console.ReadLine().Split();
            double[] items = new double[input.Length];
            for (int i = 0; i < input.Length; i++)
            {
                items[i] = double.Parse(input[i]);
            }

            for (int i = 0; i < items.Length; i++)
            {
                Console.WriteLine($"{items[i]} => {Math.Round(items[i], MidpointRounding.AwayFromZero)}");
            }



        }
    }
}
