using System;
using System.Linq;

namespace L05.SquareWithMaximumSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int bigestSquareRows = 2;
            int bigestSquareCols = 2;

            int[] input = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            int rows = input[0];
            int cols = input[1];

            int[,] matrix = new int[rows, cols];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] rowInput = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

                for (int col = 0; col < rowInput.Length; col++)
                {
                    matrix[row, col] = rowInput[col];
                }
            }
            int maxSum = int.MinValue;
            int maxRowIndex = 0;
            int maxColsIndex = 0;
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    if (row + bigestSquareRows - 1 < rows && col + bigestSquareCols - 1 < cols)
                    {
                        int sum = matrix[row, col] + matrix[row, col + 1] + matrix[row + 1, col] + matrix[row + 1, col + 1];

                        //for nxn (not 2x2)
                        //int sum = 0;
                        //for (int currRow = row; currRow < row + bigestSquareRows; currRow++)
                        //{
                        //    for (int currCol = col; currCol < col + bigestSquareCols; currCol++)
                        //    {
                        //        sum += matrix[currRow, currCol];
                        //    }
                        //}


                        if (sum > maxSum)
                        {
                            maxSum = sum;
                            maxColsIndex = col;
                            maxRowIndex = row;
                        }
                    }

                }
            }

            for (int row = maxRowIndex; row < maxRowIndex + bigestSquareRows; row++)
            {
                for (int col = maxColsIndex; col < maxColsIndex + bigestSquareCols; col++)
                {
                    Console.Write($"{matrix[row, col]} ");
                }
                Console.WriteLine();
            }
            Console.WriteLine(maxSum);
        }
    }
}
