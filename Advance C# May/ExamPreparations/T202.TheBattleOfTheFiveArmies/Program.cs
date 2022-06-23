using System;

namespace T202.TheBattleOfTheFiveArmies
{
    class Program
    {
        static void Main(string[] args)
        {
            //INPUT
            int armor = int.Parse(Console.ReadLine());
            int rows = int.Parse(Console.ReadLine());
            char[][] field = new char[rows][];

            for (int i = 0; i < rows; i++)
            {
                char[] chars = Console.ReadLine().ToCharArray();
                field[i] = chars;
            }

            //FIND HERO
            int heroRow = 0; 
            int heroCol = 0;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < field[i].Length; j++)
                {
                    if (field[i][j]=='A')
                    {
                        heroRow = i;
                        heroCol = j;
                    }
                }
            }

            //MOVES
            while (true)
            {
                var data = Console.ReadLine();
                var token = data.Split(' ');
                string command = token[0];
                int orcRow = int.Parse(token[1]);
                int orcCol = int.Parse(token[2]);

                armor--;
                field[orcRow][orcCol] = 'O';
                field[heroRow][heroCol] = '-';

                //move
                if (command=="up" && heroRow-1 >= 0)
                {
                    heroRow--;
                }
                else if (command=="down" && heroRow+1 < rows)
                {
                    heroRow++;
                }
                else if (command == "left" && heroCol-1 >=0)
                {
                    heroCol--;
                }
                else if (command == "right" && heroCol+1 < field[heroRow].Length)
                {
                    heroCol++;
                }

                //already moved
                if (field[heroRow][heroCol]=='O')
                {
                    armor -= 2;
                }
                if (field[heroRow][heroCol] == 'M')
                {
                    field[heroRow][heroCol] = '-';
                    Console.WriteLine($"The army managed to free the Middle World! Armor left: {armor}");
                    break;

                }
                
                if (armor<=0)
                {
                    field[heroRow][heroCol] = 'X';
                    Console.WriteLine($"The army was defeated at {heroRow};{heroCol}.");
                    break;
                }

                field[heroRow][heroCol] = 'A';
            }

            for (int i = 0; i < rows; i++)
            {
                Console.WriteLine(new string(field[i]));
            }
        }
    }
}
