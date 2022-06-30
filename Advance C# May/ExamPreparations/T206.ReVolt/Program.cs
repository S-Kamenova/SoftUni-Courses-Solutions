using System;

namespace T206.ReVolt
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            char[,] matrix = new char[size, size];
            int n = int.Parse(Console.ReadLine());

            int playerRow = -1;
            int playerCol = -1;

            int finishRow = -1;
            int finishCol = -1;

            int trapRow = -1;
            int trapCol = -1;

            int bonusRow = -1;
            int bonusCol = -1;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                char[] rowDate = Console.ReadLine().ToCharArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = rowDate[col];

                    if (matrix[row, col] == 'f')
                    {
                        playerRow = row;
                        playerCol = col;
                    }
                    if (matrix[row, col] == 'F')
                    {
                        finishRow = row;
                        finishCol = col;
                    }
                    if (matrix[row, col] == 'B')
                    {
                        bonusRow = row;
                        bonusCol = col;
                    }
                    if (matrix[row, col] == 'T')
                    {
                        trapRow = row;
                        trapCol = col;
                    }
                }
            }

            bool isWon = false;

            for (int i = 0; i < n; i++)
            {
                matrix[playerRow, playerCol] = '-';
                string command = Console.ReadLine();

                int previousRow = playerRow;
                int previousCol = playerCol;
                if (IsValid(matrix, playerRow, playerCol))
                {
                    if (command == "up")
                    {
                        if (playerRow == 0)
                        {
                            playerRow += (size - 1);
                        }
                        else
                        {
                            playerRow--;
                        }
                    }
                    else if (command == "down")
                    {
                        if (playerRow==size-1)
                        {
                            playerRow = 0;
                        }
                        else
                        {
                            playerRow++;
                        }
                    }
                    else if (command == "left")
                    {
                        if (playerCol==0)
                        {
                            playerCol += (size - 1);
                        }
                        else
                        {
                            playerCol--;
                        }
                    }
                    else if (command == "right")
                    {
                        if (playerCol==size-1)
                        {
                            playerCol = 0;
                        }
                        else
                        {
                            playerCol++;
                        }
                    }


                    if (playerRow == bonusRow && playerCol == bonusCol)
                    {
                        if (command == "up")
                        {
                            if (playerRow == 0)
                            {
                                playerRow += (size - 1);
                            }
                            else
                            {
                                playerRow--;
                            }
                        }
                        else if (command == "down")
                        {
                            if (playerRow == size - 1)
                            {
                                playerRow = 0;
                            }
                            else
                            {
                                playerRow++;
                            }
                        }
                        else if (command == "left")
                        {
                            if (playerCol == 0)
                            {
                                playerCol += (size - 1);
                            }
                            else
                            {
                                playerCol--;
                            }
                        }
                        else if (command == "right")
                        {
                            if (playerCol == size - 1)
                            {
                                playerCol = 0;
                            }
                            else
                            {
                                playerCol++;
                            }
                        }
                    }

                    if (playerRow == trapRow && playerCol == trapCol)
                    {
                        playerRow = previousRow;
                        playerCol = previousCol;
                    }

                    matrix[playerRow, playerCol] = 'f';

                    if (playerRow == finishRow && playerCol == finishCol)
                    {
                        Console.WriteLine("Player won!");
                        matrix[playerRow, playerCol] = 'f';
                        isWon = true;
                        break;
                    }
                }
                //PrintMatix(matrix);
            }
            if (!isWon)
            {
                Console.WriteLine("Player lost!");
            }
            PrintMatix(matrix);

        }


        static bool IsValid(char[,] matrix, int row, int col)
        {
            {
                return row >= 0 && row < matrix.GetLength(0) &&
                      col >= 0 && col < matrix.GetLength(1);
            }
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
