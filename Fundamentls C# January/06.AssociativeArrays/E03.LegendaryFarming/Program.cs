using System;
using System.Collections.Generic;
using System.Linq;

namespace E03.LegendaryFarming
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> legend = new Dictionary<string, int>()
            {
               { "shards",0},
               { "motes",0} ,
               { "fragments",0}
            };

            Dictionary<string, int> junks = new Dictionary<string, int>();

            bool isFull = false;

            while (!isFull)
            {
                string[] input = Console.ReadLine()
                    .ToLower()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                for (int i = 0; i < input.Length; i += 2)
                {
                    string currMat = input[i + 1];
                    int currQty = int.Parse(input[i]);


                    if (legend.ContainsKey(currMat))
                    {
                        legend[currMat] += currQty;

                        if (legend[currMat] >= 250)
                        {
                            isFull = true;
                            break;
                        }
                    }
                    else if (junks.ContainsKey(currMat))
                    {

                        junks[currMat] += currQty;
                    }
                    else
                    {
                        junks.Add(currMat, currQty);
                    }

                }

            }
            if (legend.ContainsKey("shards") && legend["shards"] >= 250)
            {
                Console.WriteLine("Shadowmourne obtained!");
                legend["shards"] -= 250;
            }
            else if (legend.ContainsKey("fragments") && legend["fragments"] >= 250)
            {
                Console.WriteLine("Valanyr obtained!");
                legend["fragments"] -= 250;
            }
            else if (legend.ContainsKey("motes") && legend["motes"] >= 250)
            {
                Console.WriteLine("Dragonwrath obtained!");
                legend["motes"] -= 250;
            }
            foreach (var legendItem in legend) //legend.OrderByDescending(x => x.Value).ThenBy(y => y.Key) - sorting by descending value,then sorting by key(name)
            {
                Console.WriteLine($"{legendItem.Key}: {legendItem.Value}");
            }
            foreach (var junkItem in junks)
            {
                Console.WriteLine($"{junkItem.Key}: {junkItem.Value}");
            }

        }
    }
}
