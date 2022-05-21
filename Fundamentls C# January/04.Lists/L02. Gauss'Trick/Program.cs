using System;
using System.Collections.Generic;
using System.Linq;

namespace L02.GaussTrick
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
       

            List<int> result = new List<int>();

            for (int i = 0; i < numbers.Count/2; i++)
            {
                int newElements = numbers[i] + numbers[numbers.Count - 1-i];
                result.Add(newElements);
            }
            if (numbers.Count%2!=0)
            {
                result.Add(numbers[ numbers.Count/2]);
            }
            Console.WriteLine(string.Join(" ", result));
        }
    }
}
