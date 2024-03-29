﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace T109.FlowerWreaths
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> lilies = new Stack<int>(Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));
            Queue<int> roses = new Queue<int>(Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));

            int wreaths = 0;
            int flowers = 0;

            while (roses.Count>0 && lilies.Count>0)
            {
                int lili = lilies.Pop();
                int rose = roses.Dequeue();

                int sum = lili + rose;
                if (sum==15)
                {
                    wreaths++;
                }
                else if (sum<15)
                {
                    flowers += sum;
                }
                else
                {
                    if (sum%2==0)
                    {
                        flowers += 14;
                    }
                    else
                    {
                        wreaths++;

                    }
                }
            }
            wreaths += flowers/15;
            if (wreaths>=5)
            {
                Console.WriteLine($"You made it, you are going to the competition with { wreaths} wreaths!");
            }
            else
            {
                Console.WriteLine($"You didn't make it, you need {5 - wreaths} wreaths more!");
            }

        }
    }
}
