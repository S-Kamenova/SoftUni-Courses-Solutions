using System;
using System.Linq;

namespace E02.SquaresInMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int rows =int.Parse( input.Split(" ")[0]);
            int cols =int.Parse( input.Split(" ")[1]);

            string[,] matrix = new string[rows, cols];

            FillMatrix(matrix);

            int count = 0;

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    if (rows>row+1 && cols>col+1)
                    {
                        if (matrix[row, col] == matrix[row, col + 1] &&
                                               matrix[row, col] == matrix[row + 1, col] &&
                                               matrix[row, col] == matrix[row + 1, col + 1])
                        {
                            count++;
                        }
                    } 
                }
            }
            Console.WriteLine(count);

        }

        private static void FillMatrix(string[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string[] rowDate = Console.ReadLine().Split(" ");

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = rowDate[col];
                }
            }
        }
    }
}
