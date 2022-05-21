using System;

namespace L02.PrintNumbersInReverseOrder
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            int[] items = new int[num];
            for (int i = 0; i < num; i++)
            {
                items[i] = int.Parse(Console.ReadLine());

            }

            for (int i = items.Length - 1; i >= 0; i--)
            {
                Console.Write($"{items[i]} ");
                
            }


            //Console.WriteLine(string.Join(" ", items)); 
        }
    }
}
