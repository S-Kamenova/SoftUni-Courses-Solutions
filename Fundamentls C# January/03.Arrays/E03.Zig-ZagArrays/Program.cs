using System;
using System.Linq;

namespace E03.Zig_ZagArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int[] evenArr = new int[num];
            int[] oddArr = new int[num];

            for (int i = 0; i < num; i++)
            {
                int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
                if (i%2==0)
                {
                    evenArr[i] = numbers[0];
                    oddArr[i]= numbers[1];
                }
                else
                {
                    evenArr[i] = numbers[1];
                    oddArr[i] = numbers[0];
                }
            }
            Console.WriteLine(string.Join(" ",evenArr));
            Console.WriteLine(string.Join(" ",oddArr));
        }
    }
}
