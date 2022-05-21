using System;
using System.Linq;

namespace L07.EqualArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] firstArr = Console.ReadLine()
                 .Split(' ')
                 .Select(int.Parse)
                 .ToArray();

            int[] secondArr = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int sum = 0;
            bool arraysAreDifferent = false;

            for (int i = 0; i < firstArr.Length; i++)
            {
                sum += firstArr[i];
                if (firstArr[i] != secondArr[i])
                {
                    Console.WriteLine($"Arrays are not identical. Found difference at {i} index");
                    arraysAreDifferent = true;
                    break; // можем да сложим return и да не ползваме флаг arraysAreDifferent
                }
            }
            if (!arraysAreDifferent)
            {

            Console.WriteLine($"Arrays are identical. Sum: {sum}");
            }
        }
    }
}
