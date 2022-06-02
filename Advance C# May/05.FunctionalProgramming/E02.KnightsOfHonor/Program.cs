using System;
using System.Collections.Generic;
using System.Linq;

namespace E02.KnightsOfHonor
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = Console.ReadLine().Split().ToList();
            //Action<string> condition = name => Console.WriteLine($"Sir {name}");
            //list.ForEach(condition);

            Func<string, string> addPrefix = name => "Sir" + name;

            foreach (var name in names)
            {
                Console.WriteLine(addPrefix(name));
            }
        }
    }
}
