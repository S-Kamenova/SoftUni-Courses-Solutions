using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace E04.FastFood
{
    class Program
    {
        static void Main(string[] args)
        {
            int quantityFood = int.Parse(Console.ReadLine());

            List<int> orders = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            Queue<int> queue = new Queue<int>(orders);

            Console.WriteLine(queue.Max());

            int countQueue = queue.Count();

            for (int i = 1; i <=countQueue ; i++)
            {
                if (quantityFood>=queue.Peek())
                {
                    quantityFood -= queue.Peek();
                    queue.Dequeue();
                }
                else
                {
                    break;
                }
            }

            if (queue.Count==0)
            {
                Console.WriteLine("Orders complete");
            }
            else
            {
                Console.WriteLine("Orders left: " + string.Join(" ", queue));
            }
        }
    }
}
