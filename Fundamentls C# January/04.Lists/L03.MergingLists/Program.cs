using System;
using System.Collections.Generic;
using System.Linq;

namespace L03.MergingLists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> first = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            List<int> second = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            int longerCount = Math.Max(first.Count, second.Count);

            List<int> result = new List<int>();

            for (int i = 0; i < longerCount; i++)
            {
                if (i < first.Count)
                {
                    result.Add(first[i]);
                }
                if (i < second.Count)
                {
                    result.Add(second[i]);
                }
            }
            Console.WriteLine(string.Join(" ",result));
        }

    }
}
