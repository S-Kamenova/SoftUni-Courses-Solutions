using System;
using System.Linq;

namespace L05.SumEvenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int sum = 0;

            foreach (int num in nums)
            {
                if (num%2==0)
                {
                    sum += num;
                }
            }

            //for (int i = 0; i < nums.Length; i++)
            //{
            //    int currentValue = nums[i];

            //    if (currentValue % 2 == 0)
            //    {
            //        sum += currentValue;
            //    }

            //}

            Console.WriteLine(sum);
        }
    }
}
