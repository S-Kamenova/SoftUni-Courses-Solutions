using System;

namespace L01.DayOfWeek
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            string[] days = new string[]
            {
            "Monday",
            "Tuesday",
            "Wednesday",
            "Thursday",
            "Friday",
            "Saturday",
            "Sunday",
            };

            if (number>=1 && number<=days.Length)
            {
                Console.WriteLine(days[number-1]);
            }
            else
            {
                Console.WriteLine("Invalid day!");
            }
        }
    }
}
