using System;
using System.Collections.Generic;
using System.Linq;

namespace E01.CountCharsInAString
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] word = Console.ReadLine()
                .ToCharArray();
            Dictionary<char, int> counts = new Dictionary<char, int>();

            foreach (var item in word)
            {
                if (item!=' ')
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
            }
            foreach (var item in counts)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
