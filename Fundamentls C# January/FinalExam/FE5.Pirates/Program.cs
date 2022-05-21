using System;
using System.Collections.Generic;
using System.Linq;

namespace FE5.Pirates
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Dictionary<string, List<int>> pirates = new Dictionary<string, List<int>>();

            while (input != "Sail")
            {
                string[] token = input.Split("||");
                string city = token[0];
                int population = int.Parse(token[1]);
                int gold = int.Parse(token[2]);
                if (!pirates.ContainsKey(city))
                {
                pirates.Add(city, new List<int>() { population, gold });
                }
                else
                {
                    pirates[city][0] += population;
                    pirates[city][1] += gold;
                }
                input = Console.ReadLine();
            }
            string comand = Console.ReadLine();

            while (comand!="End")
            {
                string[] comands = comand.Split("=>");
                string action = comands[0];
                string town = comands[1];

                if (action=="Plunder")
                {
                    int people = int.Parse(comands[2]);
                    int gold = int.Parse(comands[3]);

                    pirates[town][0] -= people;
                    pirates[town][1] -= gold;

                    Console.WriteLine($"{town} plundered! {gold} gold stolen, {people} citizens killed.");

                    if (pirates[town][0]<=0 || pirates[town][1]<=0)
                    {
                        Console.WriteLine($"{town} has been wiped off the map!");
                        pirates.Remove(town);
                    }
                    
                }
                else if (action== "Prosper")
                {
                    int gold = int.Parse(comands[2]);

                    if (gold>=0)
                    {
                        pirates[town][1] += gold;
                        Console.WriteLine($"{gold} gold added to the city treasury. {town} now has {pirates[town][1]} gold.");
                    }
                    else
                    {
                        Console.WriteLine("Gold added cannot be a negative number!");
                    }
                }
                comand = Console.ReadLine();
            }
            if (pirates.Count>0)
            {
                Console.WriteLine($"Ahoy, Captain! There are {pirates.Count} wealthy settlements to go to:");
                foreach (var item in pirates)
                {
                    Console.WriteLine($"{item.Key} -> Population: {item.Value[0]} citizens, Gold: {item.Value[1]} kg");
                }
            }
            else
            {
                Console.WriteLine("Ahoy, Captain! All targets have been plundered and destroyed!");
            }
        }
    }
}
