﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace E02.BasicQueueOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                 .Split(' ')
                 .Select(int.Parse)
                 .ToArray();

            int n = numbers[0];
            int s = numbers[1];
            int x = numbers[2];

            List<int> numList = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            Queue<int> queue = new Queue<int>();

            for (int i = 0; i < n; i++)
            {
                queue.Enqueue(numList[i]);
            }
            for (int i = 0; i < s; i++)
            {
                queue.Dequeue();
            }

            if (queue.Count==0)
            {
                Console.WriteLine(0);
            }
            else if (queue.Contains(x))
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine(queue.Min());
            }
        }
    }
}
