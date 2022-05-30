using System;
using System.Collections.Generic;
using System.Linq;

namespace E04.EvenTimes
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<int, int> numbers = new Dictionary<int, int>();

            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                if (!numbers.ContainsKey(num))
                {
                    numbers.Add(num, 1);
                }
                else
                {
                    numbers[num]++;
                }
            }
            foreach (var number in numbers.Where(x=>x.Value%2==0))
            {
                Console.WriteLine(number.Key);
            }

            //another variant for ptint result
            //Console.WriteLine(numbers.First(x => x.Value % 2 == 0).Key);
        }
    }
}
