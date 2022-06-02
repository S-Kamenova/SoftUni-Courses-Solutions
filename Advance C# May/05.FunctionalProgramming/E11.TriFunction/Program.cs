using System;
using System.Collections.Generic;
using System.Linq;

namespace E11.TriFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<string> names = Console.ReadLine().Split().ToList();

            
            Console.WriteLine(names
                .First(name =>
                name.Select(x => (int)x).Sum() >= n));



        }
    }
}
