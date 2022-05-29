﻿using System;

namespace L07.PascalTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            long n = long.Parse(Console.ReadLine());
            long[][] pascalTriangle = new long[n][];
            pascalTriangle[0] = new long[1] { 1 };

            for (int row = 1; row < n; row++)
            {
                pascalTriangle[row] = new long[pascalTriangle[row - 1].Length + 1];
                for (long col = 0; col < pascalTriangle[row].Length; col++)
                {
                    if (pascalTriangle[row-1].Length>col)
                    {
                        pascalTriangle[row][col] += pascalTriangle[row - 1][col];
                    }
                    if (col>0)
                    {
                        pascalTriangle[row][col] += pascalTriangle[row - 1][col - 1];
                    }
                }
            }
            PrintJagged(pascalTriangle);
            
        }
        static void PrintJagged(long[][] jagged)
        {
            for (long row = 0; row < jagged.Length; row++)
            {
                Console.WriteLine($"{string.Join(" ", jagged[row])}");
            }
        }
    }
   
}
