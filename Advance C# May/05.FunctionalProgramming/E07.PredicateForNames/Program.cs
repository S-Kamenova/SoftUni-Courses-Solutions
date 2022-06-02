using System;
using System.Collections.Generic;
using System.Linq;

namespace E07.PredicateForNames
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<string> names = Console.ReadLine().Split().ToList();

            Console.WriteLine(string.Join("\n", names
              .Where(x => x.Length<=n)));
        }
    }
}
