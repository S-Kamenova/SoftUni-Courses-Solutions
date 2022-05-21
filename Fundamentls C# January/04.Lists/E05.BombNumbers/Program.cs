using System;
using System.Collections.Generic;
using System.Linq;

namespace E05.BombNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                 .Split()
                 .Select(int.Parse)
                 .ToList();

            int[] comand = Console.ReadLine()
                 .Split(' ',StringSplitOptions.RemoveEmptyEntries)
                 .Select(int.Parse)
                 .ToArray();

            int bomb = comand[0];
            int power = comand[1];

            //while (numbers.Contains(bomb))
            //{
            //    int bombIndex = numbers.IndexOf(bomb);
            //    int leftIndex = Math.Max(bombIndex - power, 0);
            //    int rightIndex = Math.Min(bombIndex + power, 0);

            //    int count = 1 + rightIndex - leftIndex;

            //    numbers.RemoveRange(1 + leftIndex, count);
            //}
            //Console.WriteLine(numbers.Sum());   there are a some wrong

           
            while (true)
            {
                int bombIndex = numbers.IndexOf(bomb);
                if (bombIndex==-1)
                {
                    //there are no more bomb inside the list
                    break;
                }
                DetonateBomb(numbers, bombIndex, power);
            }
            Console.WriteLine(numbers.Sum());
           
        }
        static void DetonateBomb(List<int>numbers,int bombIndex, int power)
        {
            int rightIndex = bombIndex + power;
            for (int i = bombIndex; i <= rightIndex; i++)
            {
                if (bombIndex >= numbers.Count)
                {
                    break;
                }
                else
                {
                    numbers.RemoveAt(bombIndex);

                }
            }
            int lefttIndex = bombIndex - power;
            if (lefttIndex < 0)
            {
                lefttIndex = 0;
            }
            for (int i = lefttIndex; i < bombIndex; i++)
            {
                numbers.RemoveAt(lefttIndex);

            }
        }
    }
}
