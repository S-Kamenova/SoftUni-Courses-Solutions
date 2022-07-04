using System;
using System.Linq;

namespace T208.Survivor
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            char[][] beach = new char[rows][];

            int collectedTokens = 0;
            int opponentTokens = 0;

            for (int row = 0; row < rows; row++)
            {
                char[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(char.Parse).ToArray();
                beach[row] = input;
            }

            string data = Console.ReadLine();
            while (data!="Gong")
            {
                string[] token = data.Split(' ',StringSplitOptions.RemoveEmptyEntries);
                string command = token[0];
                int mainRow =int.Parse (token[1]);
                int mainCol =int.Parse (token[2]);

                if (HasValid(beach,mainRow,mainCol))
                {
                    if (command=="Find")
                    {
                        if (beach[mainRow][mainCol] == 'T')
                        {
                            collectedTokens++;
                            beach[mainRow][mainCol] = '-';
                        }
                    }
                    else if (command=="Opponent")
                    {
                        if (beach[mainRow][mainCol] == 'T')
                        {
                            opponentTokens++;
                            beach[mainRow][mainCol] = '-';
                        }

                        for (int i = 0; i < 3; i++)
                        {
                            switch (token[3])
                            {
                                case "up":
                                    mainRow--;
                                    break;
                                case "down":
                                    mainRow++;
                                    break;
                                case "left":
                                    mainCol--;
                                    break;
                                case "right":
                                    mainCol++;
                                    break;
                            }
                            if (HasValid(beach, mainRow, mainCol))
                            {
                                if (beach[mainRow][mainCol] == 'T')
                                {
                                    opponentTokens++;
                                    beach[mainRow][mainCol] = '-';
                                }
                            }
                        }
                    }
                   
                }
                
                data = Console.ReadLine();
            }
            PrintMatrix(beach);
            Console.WriteLine($"Collected tokens: {collectedTokens}");
            Console.WriteLine($"Opponent's tokens: {opponentTokens}");
        }

        static bool HasValid(char[][] beach, int row, int col)
        {
            return row >= 0 && row < beach.GetLength(0) &&
                   col >= 0 && col < beach[row].Length;
        }
        public static void PrintMatrix(char[][] beach)
        {
            for (int row = 0; row < beach.GetLength(0); row++)
            {
                for (int col = 0; col < beach[row].Length; col++)
                {
                    Console.Write(beach[row][col] + " ");
                }
                Console.WriteLine();
            }
        }

    }
}
