using System;
using System.Linq;

namespace E06.JaggedArrayManipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            int[][] matrix = new int[rows][];

            //fill matrix
            for (int row = 0; row < rows; row++)
            {
                matrix[row] = Console.ReadLine().Split().Select(int.Parse).ToArray();

            }

            //analyze matrix
            for (int row = 0; row < rows - 1; row++)
            {
                if (matrix[row].Length == matrix[row + 1].Length)
                {
                    matrix[row] = matrix[row].Select(el => el * 2).ToArray();
                    matrix[row + 1] = matrix[row + 1].Select(el => el * 2).ToArray();

                }
                else
                {
                    matrix[row] = matrix[row].Select(el => el / 2).ToArray();
                    matrix[row + 1] = matrix[row + 1].Select(el => el / 2).ToArray();
                }
            }

            string comand = Console.ReadLine();
            while (comand !="End")
            {
                int row = int.Parse(comand.Split()[1]);
                int col = int.Parse(comand.Split()[2]);
                int value = int.Parse(comand.Split()[3]);

                if (comand.StartsWith("Add"))
                {
                    if (row>=0 && row<rows && col>=0 && col<matrix[row].Length)
                    {
                        matrix[row][col] += value;
                    }
                }
                else if (comand.StartsWith("Subtract "))
                {
                    if (row >= 0 && row < rows && col >= 0 && col < matrix[row].Length)
                    {
                        matrix[row][col] -= value;
                    }
                }

                comand= Console.ReadLine();
            }
            foreach (var row in matrix)
            {
                Console.WriteLine(string.Join(" ", row));
            }
        }
    }
}
