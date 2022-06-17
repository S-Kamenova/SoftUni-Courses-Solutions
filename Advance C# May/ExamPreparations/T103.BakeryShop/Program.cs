using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace T103.BakeryShop
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<double> waters = new Queue<double>(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(double.Parse));
            Stack<double> flours = new Stack<double>(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(double.Parse));


            Dictionary<string, int> products = new Dictionary<string, int>
                {
                {"Croissant", 0 },
                {"Muffin", 0 },
                {"Baguette", 0 },
                {"Bagel", 0 }
            };


            while (waters.Count > 0 && flours.Count > 0)
            {
                double water = waters.Peek();
                double flour = flours.Peek();

                double percentWater = (water * 100) / (water + flour);
                double percentFlour = (flour * 100) / (water + flour);

                if (percentWater==50 && percentFlour==50)
                {
                    products["Croissant"]++;
                    waters.Dequeue();
                    flours.Pop();
                }
                else if (percentWater == 40 && percentFlour == 60)
                {
                    products["Muffin"]++;
                    waters.Dequeue();
                    flours.Pop();
                }
                else if (percentWater == 30 && percentFlour == 70)
                {
                    products["Baguette"]++;
                    waters.Dequeue();
                    flours.Pop();
                }
                else if (percentWater == 20 && percentFlour == 80)
                {
                    products["Bagel"]++;
                    waters.Dequeue();
                    flours.Pop();
                }
                else
                {
                    var currentFlowerr = flours.Pop();
                    var currentWater = waters.Dequeue();
                    var flourReduced = currentFlowerr - currentWater;
                    products["Croissant"]++;
                    flours.Push(flourReduced);
                }
            }
            foreach (var product in products.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                if (product.Value > 0)
                {
                    Console.WriteLine($"{product.Key}: {product.Value}");
                }
            }
            if (waters.Count > 0)
            {
                Console.Write("Water left: ");
                Console.Write(String.Join(", ", waters));
                Console.WriteLine();

            }
            else
            {
                Console.WriteLine("Water left: None");
            }

            if (flours.Count > 0)
            {
                Console.Write("Flour left: ");
                Console.Write(String.Join(", ", flours));
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Flour left: None");
            }

        }
    }
}
