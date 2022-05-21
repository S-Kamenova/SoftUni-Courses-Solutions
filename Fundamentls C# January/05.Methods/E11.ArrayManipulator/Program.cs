using System;
using System.Collections.Generic;
using System.Linq;

namespace E11.ArrayManipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            string[] comand = Console.ReadLine()
                .Split()
                .ToArray();

            while (comand[0] != "end")
            {
                if (comand[0] == "exchange")
                {
                    arr = ExchangeArr(arr, int.Parse(comand[1]));

                }
                else if (comand[0] == "max " || comand[0] == "min")
                {
                    FindMinMax(arr, comand[0], comand[1]);
                }
                else
                {
                    FindNumbers(arr, comand[0], int.Parse(comand[1]), comand[2]);
                }
                comand = Console.ReadLine().Split().ToArray();

            }
            Console.WriteLine($"[{string.Join(", ", arr)}]");

        }

             

        static int[] ExchangeArr(int[] currentArr, int splitIndex)
        {
            if (splitIndex >= currentArr.Length || splitIndex <= 0)
            {
                Console.WriteLine("invaid index");
                return currentArr;
            }

            int[] exchangeArr = new int[currentArr.Length];
            int index = 0;

            for (int currentIndex = splitIndex+1; currentIndex < currentArr.Length; currentIndex++)
            {
                exchangeArr[index] = currentArr[currentIndex];
                index++;
            }
            for (int curIndex = 0; curIndex < splitIndex; curIndex++)
            {
                exchangeArr[index] = currentArr[curIndex];
                index++;

            }
            return exchangeArr;
        }

        static void FindMinMax(int[] currArr, string minOrMax, string evenOrOdd)
        {
            int index = -1;
            int min = int.MaxValue;
            int max = int.MinValue;

            int resultOddEven = 1;

            if (evenOrOdd=="even")
            {
                resultOddEven = 0;
            }
            for (int curIndex = 0; curIndex < currArr.Length; curIndex++)
            {
                if (currArr[curIndex]%2==resultOddEven)
                {
                    if (minOrMax=="min" && min>=currArr[curIndex])
                    {
                        min = currArr[curIndex];
                        index = curIndex;
                    }
                    else if (minOrMax=="max" && max<=currArr[curIndex])
                    {
                        max = currArr[curIndex];
                        index = curIndex;
                    }
                }
            }
            if (index>-1)
            {
                Console.WriteLine(index);
            }
            else
            {
                Console.WriteLine("No matches");
            }
        }

        static void FindNumbers(int[] currArr, string position, int numbersCount, string evenOdd)
        {
            if (numbersCount > currArr.Length)
            {
                Console.WriteLine("Invalid count");
                return;
            }
            if (numbersCount==0)
            {
                Console.WriteLine("[]");
                return;
            }

            int resultEvenOdd = 1;
            if (evenOdd=="even")
            {
                resultEvenOdd = 0;
            }
            int count = 0;
            List<int> nums = new List<int>();

            if (position=="first")
            {
                foreach (var num in currArr)
                {
                    if (num%2==resultEvenOdd)
                    {
                        count++;
                        nums.Add(num);
                    }
                    if (count==numbersCount)
                    {
                        break;
                    }
                }
            }
            else
            {
                for (int currentIndex = currArr.Length-1; currentIndex >=0; currentIndex--)
                {
                    if (currArr[currentIndex]%2==resultEvenOdd)
                    {
                        count++;
                        nums.Add(currArr[currentIndex]);
                    }
                    if (count==numbersCount)
                    {
                        break;

                    }
                }
                nums.Reverse();
            }
            Console.WriteLine($"[{string.Join(", ",nums)}]");
        }
    }
}
