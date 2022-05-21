﻿using System;

namespace L02.Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            double readGrade = double.Parse(Console.ReadLine());
            PrintGrade(readGrade);
        }

        static void PrintGrade(double grade)
        {
            string gradeInWord = string.Empty;
            if (grade>=2.00 && grade<=2.99)
            {
                Console.WriteLine("Fail");
            }
            else if (grade >= 3.00 && grade <= 3.49)
            {
                Console.WriteLine("Poor");
            }
            else if (grade >= 3.50 && grade <= 4.49)
            {
                Console.WriteLine("Good");
            }
            else if (grade >= 4.50 && grade <= 5.49)
            {
                Console.WriteLine("Very good");
            }
            else if (grade >= 5.50 && grade <= 6.00)
            {
                Console.WriteLine("Excellent");
            }
        }
    }
}
