using System;

namespace E07.NxNMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            PrintMatrix(num);
        }

        static void PrintMatrix(int num)
        {
            for (int rows = 0; rows < num; rows++)
            {
                for (int cols = 0; cols < num; cols++)
                {
                    Console.Write(num + " ");
                }
                Console.WriteLine();
            }
            
        }
    }
}
