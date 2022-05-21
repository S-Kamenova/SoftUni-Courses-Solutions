using System;
using System.Linq;

namespace E08.MagicSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToArray();
            int num = int.Parse(Console.ReadLine());

            for (int i = 0; i < numbers.Length; i++)
            {
                for (int k = i+1; k < numbers.Length; k++)
                {
                    if (numbers[i]+numbers[k]==num)
                    {
                        Console.WriteLine($"{numbers[i]} {numbers[k]}");
                    }
                }
            }
        }
    }
}
