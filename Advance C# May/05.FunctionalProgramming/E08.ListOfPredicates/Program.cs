
using System;
using System.Collections.Generic;
using System.Linq;

namespace E08.ListOfPredicates
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<int> dividers = Console.ReadLine().Split().Select(int.Parse).ToList();

            List<int> numbers = new List<int>();
            for (int i = 1; i <= n; i++)
            {
                numbers.Add(i);
            }

            List<int> printNum = new List<int>();
            foreach (var number in numbers)
            {
                bool IsDivisible = true;
                foreach (var divider in dividers)
                {
                    Predicate<int> divisible = number => number % divider == 0;
                    if (!divisible(number))
                    {
                        IsDivisible = false;
                        break;
                    }
                }
                if (IsDivisible)
                {
                    printNum.Add(number);
                }
            }
            Console.WriteLine(string.Join(" ",printNum));
        }
    }
}
