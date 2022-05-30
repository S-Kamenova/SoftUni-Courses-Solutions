using System;
using System.Collections.Generic;

namespace E03.PeriodicTable
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            SortedSet<string> elements = new SortedSet<string>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(" ");
                
                foreach (var chElement in input)
                {
                    elements.Add(chElement);
                }
            }

            Console.WriteLine(string.Join(" ",elements));
        }
    }
}
