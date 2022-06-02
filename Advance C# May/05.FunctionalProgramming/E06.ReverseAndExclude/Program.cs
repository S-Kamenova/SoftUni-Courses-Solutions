using System;
using System.Collections.Generic;
using System.Linq;

namespace E06.ReverseAndExclude
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> newNum = new List<int>();
            
            int n = int.Parse(Console.ReadLine());

            for (int i = numbers.Count-1; i >=0 ; i--)
            {
                newNum.Add(numbers[i]);
            }
            Console.WriteLine(string.Join(" ",newNum
               .Where(x => x%n!=0)));
        }
    }
}
