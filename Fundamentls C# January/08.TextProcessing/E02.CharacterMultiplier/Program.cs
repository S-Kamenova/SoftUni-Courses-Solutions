using System;

namespace E02.CharacterMultiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split();

           int finalSum= GetStringSum(input[0], input[1]);

            Console.WriteLine(finalSum);
        }

        private static int GetStringSum(string one, string two)
        {
            int sum = 0;

            int minLengt = Math.Min(one.Length, two.Length);
            for (int i = 0; i < minLengt; i++)
            {
                sum += one[i] * two[i];
            }
            string longestLengt = one;
            if (longestLengt.Length<two.Length)
            {
                longestLengt = two;
            }
            for (int i = minLengt; i < longestLengt.Length; i++)
            {
                sum += longestLengt[i];
            }


            return sum;

        }
    }
}
