using System;
using System.Linq;

namespace L08.CondenseArrayToNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine()
                 .Split(' ')
                 .Select(int.Parse)
                 .ToArray();

            int firstLenght = nums.Length;

            for (int i = 0; i < firstLenght-1; i++)
            {
                int[] condense = new int[nums.Length - 1];

                for (int j = 0; j < nums.Length-1; j++)
                {
                    condense[j] = nums[j] + nums[j + 1];
                }

                nums = condense;
            }

            Console.WriteLine(nums[0]);
        }
    }
}
