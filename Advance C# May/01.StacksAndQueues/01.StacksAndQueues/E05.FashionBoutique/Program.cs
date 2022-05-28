using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace E05.FashionBoutique
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>(Console.ReadLine().Split(" ").Select(int.Parse));

            int capacity = int.Parse(Console.ReadLine());

            int box = 1;

            int sum = 0;

            while (stack.Any())
            {
                if (sum+stack.Peek()<=capacity)
                {
                    sum += stack.Pop();

                }
                else
                {
                    sum = 0;
                    box++;
                }
            }
            Console.WriteLine(box);
        }
    }
}
