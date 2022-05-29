﻿using System;
using System.Linq;

namespace L06.JaggedArrayModification
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            int[][] jagged = ReadJaggedArray(rows);
            string comand = Console.ReadLine();

            while (comand!="END")
            {
                var input = comand.Split();
                int row = int.Parse(input[1]);
                int col = int.Parse(input[2]);
                int value = int.Parse(input[3]);
                if (row < 0 || col < 0 || row >=jagged.Length || col>=jagged[row].Length)
                {
                    Console.WriteLine("Invalid coordinates");
                }
                else if (input[0]=="Add")
                {
                    jagged[row][col] += value;
                }
                else if (input[0]== "Subtract")
                {
                    jagged[row][col] -= value;
                }

                comand = Console.ReadLine();
            }

            PrintJagged(jagged);
        }
        static int [][] ReadJaggedArray(int rows)
        {
            int[][] jagged = new int[rows][];
            for (int row = 0; row < rows; row++)
            {
                jagged[row] = Console.ReadLine().Split().Select(int.Parse).ToArray();
            }
            return jagged;
        }
        static void PrintJagged(int[][] jagged)
        {
            for (int row = 0; row < jagged.Length; row++)
            {
                Console.WriteLine($"{string.Join(" ", jagged[row])}");
            }
        }
    }
}
