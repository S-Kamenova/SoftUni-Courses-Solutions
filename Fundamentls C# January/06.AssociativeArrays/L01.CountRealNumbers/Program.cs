using System;
using System.Collections.Generic;
using System.Linq;

namespace L01.CountRealNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] numbers = Console.ReadLine()
                  .Split(' ',StringSplitOptions.RemoveEmptyEntries)
                  .Select(double.Parse)
                  .ToArray();

            SortedDictionary<double, int> counts = new SortedDictionary<double, int>();

            foreach (var item in numbers)
            {
                if (counts.ContainsKey(item))
                {
                    counts[item] += 1;
                }
                else
                {
                    counts.Add(item, 1);
                }
            }
            foreach (var num in counts)
            {
                Console.WriteLine($"{num.Key}->{num.Value}");
            }
            
        }
    }
}
