using System;
using System.Text.RegularExpressions;

namespace L03.MatchDates
{
    class Program
    {
        static void Main(string[] args)
        {
            string date = Console.ReadLine();

            string pattern = @"(?<day>\d{2})(.|-|\/)(?<month>[A-Z][a-z]{2})\1(?<year>\d{4})";

            MatchCollection matches = Regex.Matches(date, pattern);

            foreach (Match item in matches)
            {
                string day = item.Groups["day"].Value;
                string month = item.Groups["month"].Value;
                var year = item.Groups["year"].Value;
                Console.WriteLine($"Day: {day}, Month: {month}, Year: {year}");
            }
        }
    }
}
