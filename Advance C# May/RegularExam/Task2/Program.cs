using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            char[,] matrix = new char[num, num];

            int mainRow = -1;
            int mainCol = -1;

            int countHole = 1;
            int countRod = 0;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                char[] rowDate = Console.ReadLine().ToCharArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = rowDate[col];

                    if (matrix[row, col] == 'V')
                    {
                        mainRow = row;
                        mainCol = col;
                    }
                    

                }
            }

            string command = Console.ReadLine();
            while (command !="End")
            {
                var previousRow = mainRow;
                var previousCol = mainCol;

                matrix[mainRow, mainCol] = '*';

                if (command=="up")
                {
                    mainRow--;
                }
                if (command == "down")
                {
                    mainRow++;
                }
                if (command == "left")
                {
                    mainCol--;
                }
                if (command == "right")
                {
                    mainCol++;
                }
                if (!IsValid(matrix,mainRow, mainCol))
                    {
                        matrix[previousRow, previousCol] = 'V';
                        mainRow = previousRow;
                        mainCol = previousCol;
                        
                    }
                    else
                    {
                        if (matrix[mainRow, mainCol] == 'R')
                        {
                            mainRow = previousRow;
                            mainCol = previousCol;
                            countRod++;
                            Console.WriteLine("Vanko hit a rod!");

                        }
                        else if (matrix[mainRow, mainCol] == 'C')
                        {
                            matrix[mainRow, mainCol] = 'E';
                            countHole++;
                            Console.WriteLine($"Vanko got electrocuted, but he managed to make {countHole} hole(s).");
                            break;
                        }
                        else if (matrix[mainRow, mainCol] == '*')
                        {
                            Console.WriteLine($"The wall is already destroyed at position [{mainRow}, {mainCol}]!");
                        }
                        else
                        {
                            countHole++;
                            matrix[mainRow, mainCol] = 'V';
                            matrix[previousRow, previousCol] = '*';
                        }

                    }
               
                matrix[mainRow, mainCol] = 'V';
                               
                command = Console.ReadLine();
            }

            if (command == "End")
            {
                Console.WriteLine($"Vanko managed to make {countHole} hole(s) and he hit only {countRod} rod(s).");
            }
            PrintMatix(matrix);
            
        }
        static bool IsValid(char[,] matrix, int row, int col)
        {
            if (row < 0 || col < 0)
            {
                return false;
            }
            if (row >= matrix.GetLongLength(0) || col >= matrix.GetLongLength(1))
            {
                return false;
            }
            return true;
        }

        static void PrintMatix(char[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
