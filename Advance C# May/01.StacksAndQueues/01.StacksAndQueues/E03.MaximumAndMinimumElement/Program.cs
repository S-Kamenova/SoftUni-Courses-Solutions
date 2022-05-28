using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace E03.MaximumAndMinimumElement
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Stack<int> stack = new Stack<int>();
            for (int i = 0; i < n; i++)
            {
                string comand = Console.ReadLine();

                if (comand.StartsWith("1"))
                {
                    stack.Push(int.Parse(comand.Split()[1]));
                }
                else if (comand.StartsWith("2"))
                {
                    stack.Pop();
                }

                else if (comand.StartsWith("3"))
                {
                    if (stack.Count > 0)
                    {
                        Console.WriteLine(stack.Max());
                    }

                }
                else if (comand.StartsWith("4"))
                {
                    if (stack.Count > 0)
                    {
                        Console.WriteLine(stack.Min());
                    }

                }
            }
          
            Console.WriteLine(string.Join(", ", stack));
        }
    }
}
