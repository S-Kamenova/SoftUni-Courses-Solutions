using System;

namespace L04.PrintingTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int hight = int.Parse(Console.ReadLine());

            for (int i = 1; i < hight; i++)
            {
                PrintLine(1, i);
            }

            for (int i = hight; i >= 1; i--)
            {
                PrintLine(1, i);
            }
        }

        static void PrintLine(int start, int end)
        {
            for (int i = start; i <= end; i++)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine();
        }
    }
}
