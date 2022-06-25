using System;
using System.Collections.Generic;
using System.Linq;

namespace T108.Scheduling
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> tasks = new Stack<int>(Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));
            Queue<int> threads = new Queue<int>(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));

            int taskForKill = int.Parse(Console.ReadLine());
            int thread = 0;
            while (true)
            {
                thread = threads.Peek();
                int task = tasks.Peek();
                if (task==taskForKill)
                {
                    tasks.Pop();
                    break;
                }
                else if (thread>=task && task !=taskForKill)
                {
                    threads.Dequeue();
                    tasks.Pop();
                }
                else if (thread<task)
                {
                    threads.Dequeue();
                }
            }
            Console.WriteLine($"Thread with value {thread} killed task {taskForKill}");
            Console.WriteLine($"{string.Join(" ", threads)}");
        }
    }
}
