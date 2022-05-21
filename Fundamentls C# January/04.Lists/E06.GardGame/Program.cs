using System;
using System.Collections.Generic;
using System.Linq;

namespace E06.GardGame
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


            while (true)
            {
                if (first[0] > second[0])
                {

                    first.Add(second[0]);
                    first.Add(first[0]);
                    
                }
                else if (second[0] > first[0])
                {

                    second.Add(first[0]);
                    second.Add(second[0]);
                }

                first.RemoveAt(0);
                second.RemoveAt(0);

                if (first.Count == 0)
                {
                    int sum = second.Sum();
                    Console.WriteLine($"Second player wins! Sum: {sum}");
                    break;
                }

                else if (second.Count == 0)
                {
                    int sum = first.Sum();
                    Console.WriteLine($"First player wins! Sum: {sum}");
                    break;
                }
            }
        }
    }

}

