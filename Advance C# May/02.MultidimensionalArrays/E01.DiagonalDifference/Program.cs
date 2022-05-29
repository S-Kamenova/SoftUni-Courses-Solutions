using System;
using System.Linq;

namespace E01.DiagonalDifference
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            int[,] matrix = new int[num, num];

            FillMatrix(matrix);

            int sumPrimaryDiagonal = 0;
            int sumSecondaryDiagonal = 0;

            for (int row = 0; row < num; row++)
            {
                for (int col = 0; col < num; col++)
                {
                    int number = matrix[row, col];

                    if (row==col)
                    {
                        sumPrimaryDiagonal += number;
                    }
                    if (row+col==num-1)
                    {
                        sumSecondaryDiagonal += number;
                    }
                }
            }

            Console.WriteLine(Math.Abs(sumPrimaryDiagonal-sumSecondaryDiagonal));
        }

        private static void FillMatrix(int[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
               int[] rowDate = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = rowDate[col];
                }
            }
        }
    }
}
