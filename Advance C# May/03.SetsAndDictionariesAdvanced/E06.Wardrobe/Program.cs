using System;
using System.Linq;
using System.Collections.Generic;

namespace E06.Wardrobe
{
    class Program
    {
        static void Main(string[] args)
        {

            Dictionary<string, Dictionary<string, int>> wardrobe = new Dictionary<string, Dictionary<string, int>>();


            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();

                string color = input.Split(" -> ")[0];
                if (!wardrobe.ContainsKey(color))
                {
                    wardrobe.Add(color, new Dictionary<string, int>());
                }

                Dictionary<string, int> clothes = wardrobe[color];
                string[] inputClothes = input.Split(" -> ")[1].Split(",");

                foreach (var item in inputClothes)
                {
                    if (!clothes.ContainsKey(item))
                    {
                        clothes.Add(item, 1);
                    }
                    else
                    {
                        clothes[item]++;
                    }
                }
            }

            string[] searchedItems = Console.ReadLine().Split(" ").ToArray();
            string serachedColor = searchedItems[0];
            string serachedCloth = searchedItems[1];

            foreach (var colorEntry in wardrobe)
            {
                Console.WriteLine($"{colorEntry.Key} clothes:");
                Dictionary<string, int> clothes = colorEntry.Value;
                foreach (var item in clothes)
                {
                    if (item.Key== serachedCloth && colorEntry.Key== serachedColor)
                    {
                        Console.WriteLine($"* {item.Key} - {item.Value} (found!)");
                    }
                    else
                    {
                        Console.WriteLine($"* {item.Key} - {item.Value}");
                    }
                    
                }
            }
        }
    }
}
