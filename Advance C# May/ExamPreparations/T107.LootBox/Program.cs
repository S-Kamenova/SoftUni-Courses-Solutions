using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace T107.LootBox
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> first = new Queue<int>(Console.ReadLine().Split().Select(int.Parse));
            Stack<int> second = new Stack<int>(Console.ReadLine().Split().Select(int.Parse));

            int sum = 0;

            while (true )
            {
                var currQueue = first.Peek();
                var currStack = second.Peek();
                var result = currQueue + currStack;
                if (result%2==0)
                {
                    sum += result;
                    first.Dequeue();
                    second.Pop();
                }
                else
                {
                    first.Enqueue(currStack);
                    second.Pop();
                }
                if (first.Count==0)
                {
                    break;
                }
                if (second.Count==0)
                {
                    break;
                }
            }

            if (first.Count==0)
            {
                Console.WriteLine("First lootbox is empty");
            }
            if (second.Count==0)
            {
                Console.WriteLine("Second lootbox is empty");
            }
            if (sum>=100)
            {
                Console.WriteLine($"Your loot was epic! Value: {sum}");
            }
            else
            {
                Console.WriteLine($"Your loot was poor... Value: {sum }");
            }
        }
    }
}
