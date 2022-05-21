using System;
using System.Linq;

namespace E06.EqualSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();


            bool isvalue = false;

            for (int i = 0; i < numbers.Length; i++)
            {
                int leftSum = 0;
                int rightSum = 0;

                for (int k = 0; k < i; k++)
                {
                    leftSum += numbers[k];
                }

                for (int j = i + 1; j < numbers.Length; j++)
                {
                    rightSum += numbers[j];
                }
                if (leftSum == rightSum)
                {
                    Console.WriteLine(i);

                    isvalue = true;
                }


            }
            if (isvalue == false)
            {
                Console.WriteLine("no");
            }
        }
    }
}
