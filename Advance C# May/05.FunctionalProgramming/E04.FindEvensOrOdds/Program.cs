using System;
using System.Collections.Generic;
using System.Linq;

namespace E04.FindEvensOrOdds
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int start =int.Parse(input.Split()[0]);
            int end= int.Parse(input.Split()[1]);
            List<int> numbers = new List<int>();

            for (int i = start; i <= end; i++)
            {
                numbers.Add(i);
            }

            Predicate<int> predicate =null;

            string type = Console.ReadLine();

            if (type=="even")
            {
                predicate = number => number % 2 == 0;
            }
            else if (type=="odd")
            {
                predicate = number => number % 2 != 0;
            }

            Console.WriteLine(string.Join(" ", numbers.FindAll(predicate)));
        }
    }
}
