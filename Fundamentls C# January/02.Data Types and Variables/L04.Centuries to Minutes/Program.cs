using System;

namespace L04.Centuries_to_Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            const int yearsInCenturie = 100;
            const decimal daysInyear = 365.2422m;
            const int hoursInDay = 24;
            const int minutesInHour = 60;

           int centuries = int.Parse(Console.ReadLine());

            var years = centuries * yearsInCenturie;
            int days = (int)(years * daysInyear);
            int hours = days * hoursInDay;
            int minutes = hours * minutesInHour;

            Console.WriteLine($"{centuries} centuries = {years} years = {days} days = {hours} hours = {minutes} minutes");




        }
    }
}
