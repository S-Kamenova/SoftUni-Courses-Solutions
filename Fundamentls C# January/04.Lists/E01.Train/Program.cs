using System;
using System.Collections.Generic;
using System.Linq;

namespace E01.Train
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> wagons = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            int MaxCapacity = int.Parse(Console.ReadLine());

            string comand = Console.ReadLine();

            while (comand!="end")
            {
                string[] tokens = comand.Split();
                if (tokens.Length==2)
                {
                    int currenrWagon = int.Parse(tokens[1]);
                    wagons.Add(currenrWagon);
                }
                else
                {
                    int currentCapacity = int.Parse(tokens[0]);
                    FindWagons(wagons, MaxCapacity, currentCapacity);
                }
                
               
                
                comand = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", wagons));
        }

        private static void FindWagons(List<int> wagons, int maxCapacity, int currentCapacity)
        {
            for (int i = 0; i < wagons.Count; i++)
            {
              
                if (wagons[i]+currentCapacity<maxCapacity)
                {
                    wagons[i] += currentCapacity;
                    break;
                }
            }
        }
    }
}
