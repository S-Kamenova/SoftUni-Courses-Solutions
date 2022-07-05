using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> tiles = new Dictionary<string, int>();
            tiles.Add("Sink", 0);
            tiles.Add("Oven", 0);
            tiles.Add("Countertop", 0);
            tiles.Add("Wall", 0);
            tiles.Add("Floor", 0);

           
            Stack<int> whites = new Stack<int>(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));
            Queue<int> greys = new Queue<int>(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));

           

            

            while (greys.Count>0 && whites.Count>0)
            {
                int currentWhite = whites.Peek();
                int currentGrey = greys.Peek();

                if (currentWhite== currentGrey)
                {
                    int newTile = currentGrey + currentWhite;
                    if (newTile==40)
                    {
                        tiles["Sink"]++;
                        whites.Pop();
                        greys.Dequeue();
                    }
                    else if (newTile == 50)
                    {
                        tiles["Oven"]++;
                        whites.Pop();
                        greys.Dequeue();
                    }
                    else if (newTile == 60)
                    {
                        tiles["Countertop"]++;
                        whites.Pop();
                        greys.Dequeue();
                    }
                    else if (newTile == 70)
                    {
                        tiles["Wall"]++;
                        whites.Pop();
                        greys.Dequeue();
                    }
                    else
                    {
                        tiles["Floor"]++;
                        whites.Pop();
                        greys.Dequeue();
                    }

                }
                else
                {
                    whites.Pop();
                    whites.Push(currentWhite / 2);
                    greys.Dequeue();
                    greys.Enqueue(currentGrey);
                }

            }

            if (whites.Count==0)
            {
                Console.WriteLine("White tiles left: none");
            }
            else
            {
                Console.WriteLine($"White tiles left: {string.Join(", ",whites)}");
            }
            if (greys.Count==0)
            {
                Console.WriteLine("Grey tiles left: none");
            }
            else
            {
                Console.WriteLine($"Grey tiles left: {string.Join(", ", greys)}");
            }

            foreach (var item in tiles.OrderByDescending(x=>x.Value).ThenBy(x=>x.Key))
            {
                if (item.Value>0)
                {
                    Console.WriteLine($"{item.Key}: {item.Value}");
                } 
            }
        }
    }
}
