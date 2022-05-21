﻿using System;

namespace E02.SumDigits
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int sum = 0;
            char[] charArr = input.ToCharArray();
            for (int i = 0; i < charArr.Length; i++)
            {
                sum+=int.Parse(charArr[i].ToString());
            }



            // antoher variant
            //int num = int.Parse(Console.ReadLine());
            //int sum = 0;

            //while (num!=0)
            //{
            //    int lastDigit = num % 10;
            //    sum += lastDigit;
            //    num /= 10;
            //}

            Console.WriteLine(sum);
        }
    }
}
