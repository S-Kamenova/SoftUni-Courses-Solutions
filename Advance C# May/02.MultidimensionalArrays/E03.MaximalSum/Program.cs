using System;
using System.Linq;

namespace E03.MaximalSum
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int rows = int.Parse(input.Split(" ")[0]);
            int cols = int.Parse(input.Split(" ")[1]);

            int[,] matrix = new int[rows, cols];

            FillMatrix(matrix);

            int bigestRow = 3;
            int bigestCol = 3;

            int maxSum = int.MinValue;
            int maxRowIndex = 0;
            int maxColsIndex = 0;

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    if (row + bigestRow - 1 < rows && col + bigestCol - 1 < cols)
                    {
                        int currentSum = 0;
                        for (int currRow = row; currRow < row + bigestRow; currRow++)
                        {
                            for (int currCol = col; currCol < col + bigestCol; currCol++)
                            {
                                currentSum += matrix[currRow, currCol];
                            }
                        }
                        if (currentSum>maxSum)
                        {
                            maxSum = currentSum;
                            maxColsIndex = col;
                            maxRowIndex = row;
                        }

                    }

                }
            }

            Console.WriteLine($"Sum = {maxSum}");

            for (int row = maxRowIndex; row < maxRowIndex + bigestRow; row++)
            {
                for (int col = maxColsIndex; col < maxColsIndex + bigestCol; col++)
                {
                    Console.Write($"{matrix[row, col]} ");
                }
                Console.WriteLine();
            }
            
        }
        private static void FillMatrix(int[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] rowDate = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = rowDate[col];
                }
            }
        }
    }
}
