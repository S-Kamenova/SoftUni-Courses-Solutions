﻿using System;

namespace E06.MiddleCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            GetMiddle(text);

        }

        static void GetMiddle(string text)
        {
            if (text.Length % 2 == 0)
            {
                Console.WriteLine($"{text[(text.Length / 2) - 1]}{text[text.Length / 2]}");

            }
            else
            {
                Console.WriteLine($"{text[text.Length / 2]}");
            }
        }
    }
}
