using System;
using System.Collections.Generic;

namespace E02.AMinerTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> items = new Dictionary<string, int>();

            string comand = Console.ReadLine();

            while (comand!="stop")
            {
                int quantity = int.Parse(Console.ReadLine());
                if (items.ContainsKey(comand))
                {
                    items[comand] += quantity;
                }
                else
                {
                    items.Add(comand, quantity);
                }

                comand = Console.ReadLine();

            }
            foreach (var item in items)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
