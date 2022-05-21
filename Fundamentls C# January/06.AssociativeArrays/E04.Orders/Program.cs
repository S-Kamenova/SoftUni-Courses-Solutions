using System;
using System.Collections.Generic;
using System.Linq;

namespace E04.Orders
{
    class Program
    {
        static void Main(string[] args)
        {

            string comand = Console.ReadLine();

            Dictionary<string, decimal> order = new Dictionary<string, decimal>();
            Dictionary<string, int> newOrder = new Dictionary<string, int>();

            while (comand!="buy")
            {
                string[] token = comand.Split(' ');
                string product = token[0];
                decimal price = decimal.Parse(token[1]);
                int quantity = int.Parse(token[2]);

                if (!order.ContainsKey(product))
                {
                    order.Add(product, price);
                    newOrder.Add(product, quantity);

                }
                else if (order.ContainsKey(product))
                {
                    if (price!=order[product])
                    {
                        order[product] = price;
                    } 
                    newOrder[product] += quantity;
                }

                comand = Console.ReadLine();
            }
            foreach (var item in order)
            {
                foreach (var newOrd in newOrder)
                {
                    if (item.Key==newOrd.Key)
                    {
                        Console.WriteLine($"{item.Key} -> {item.Value*newOrd.Value:f2}");
                    }
                }
                
            }
        }
    }
}
