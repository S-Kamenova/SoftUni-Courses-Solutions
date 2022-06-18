using System;

namespace T201.TruffleHunter
{
    class Program
    {
        static void Main(string[] args)
        {
            int black = 0;
            int summer = 0;
            int white = 0;
            int eatTruffles = 0;

            int num = int.Parse(Console.ReadLine());
            string[,] matrix = new string[num, num];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string[] rowDate = Console.ReadLine().Split();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = rowDate[col];
                }
            }

            string command = Console.ReadLine();
            while (command!= "Stop the hunt")
            {
                var token = command.Split(" ");
                string action = token[0];
                int row = int.Parse(token[1]);
                int col = int.Parse(token[2]);
                

                if (action== "Collect")
                {
                    if (row>=0 && row<=num-1 && col >= 0 && col <= num - 1)
                    {
                        var currPosition = matrix[row, col];
                        if (currPosition=="B")
                        {
                            black++;
                        }
                        else if (currPosition=="S")
                        {
                            summer++;
                        }
                        else if (currPosition=="W")
                        {
                            white++;
                        }
                        matrix[row, col] = "-";
                    }
                }
                else if (action == "Wild_Boar")
                {
                    string direction = token[3];
                    if (direction=="up")
                    {
                        for (int i = row; i >= 0; i-=2)
                        {
                            if (matrix[i, col]!="-")
                            {
                                eatTruffles++;
                                matrix[i, col] = "-";
                            } 
                        }
                    }
                    else if (direction=="down")
                    {
                        for (int i = row; i < matrix.GetLength(0); i+=2)
                        {
                            if (matrix[i, col] != "-")
                            {
                                eatTruffles++;
                                matrix[i, col] = "-";
                            }
                        }
                    }
                    else if (direction == "left")
                    {
                        for (int i = col; i >= 0; i-=2)
                        {
                            if (matrix[row, i] != "-")
                            {
                                eatTruffles++;
                                matrix[row, i] = "-";
                            }
                        }
                    }
                    else if (direction == "right")
                    {
                        for (int i = col; i < matrix.GetLength(1); i+=2)
                        {
                            if (matrix[row, i] != "-")
                            {
                                eatTruffles++;
                                matrix[row, i] = "-";
                            }
                        }
                    }

                }

                command = Console.ReadLine();
            }

            Console.WriteLine($"Peter manages to harvest {black} black, {summer} summer, and {white} white truffles.");
            Console.WriteLine($"The wild boar has eaten {eatTruffles} truffles.");

            PrintMatrix(matrix);
        }

        private static void PrintMatrix(string[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col] + " ", StringSplitOptions.RemoveEmptyEntries);
                }
                Console.WriteLine();
            }
        }

    }
}
