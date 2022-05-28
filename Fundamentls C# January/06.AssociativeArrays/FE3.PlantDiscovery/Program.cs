using System;
using System.Collections.Generic;
using System.Linq;

namespace FE2.PlantDiscovery
{
    class Program
    {

        public class Plant
        {
            public string plantName;
            public int rarity;
            public List<double> rates = new List<double>();
            public double average = 0;
            public void addRate(double rate)
            {
                this.average = 0;
                this.rates.Add(rate);
                for (int i = 0; i < rates.Count; i++)
                {
                    average += rates[i];
                }
                average /= rates.Count;
            }
        }
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            Dictionary<string, Plant> discovery = new Dictionary<string, Plant>();

            for (int i = 0; i < num; i++)
            {
                string[] token = Console.ReadLine().Split("<->", StringSplitOptions.RemoveEmptyEntries);
                string plant = token[0];
                int rarityValue = int.Parse(token[1]);
                if (discovery.ContainsKey(plant))
                {
                    discovery[plant].rarity = rarityValue;
                }
                else
                {
                    Plant currPlant = new Plant();
                    currPlant.plantName = plant;
                    currPlant.rarity = rarityValue;

                    discovery.Add(plant, currPlant);
                }
            }

            string comand = Console.ReadLine();

            while (comand != "Exhibition")
            {
                string[] comands = comand.Split();//"char[]{':', '-', ' '}", StringSplitOptions.RemoveEmptyEntries
                string action = comands[0];
                string plant = comands[1];

                if (!discovery.ContainsKey(plant))
                {
                    Console.WriteLine("error");
                }
                else
                {
                    if (action == "Rate:")
                    {
                        double rating = double.Parse(comands[3]);
                        discovery[plant].addRate(rating);
                    }
                    else if (action == "Update:")
                    {
                        int newRarity = int.Parse(comands[3]);
                        discovery[plant].rarity = newRarity;
                    }
                    else if (action == "Reset:")
                    {
                        discovery[plant].rates.Clear();
                        discovery[plant].average = 0;
                    }
                }

                comand = Console.ReadLine();
            }
            Console.WriteLine("Plants for the exhibition:");
            foreach (var item in discovery) //discovery.OrderByDescending(x=>x.Value.rarity).thenByDescending(x=>x.Value.average)-sorting
            {
                Console.WriteLine($"- {item.Key}; Rarity: {item.Value.rarity}; Rating: {item.Value.average:f2}");
            }

        }
    }
}
