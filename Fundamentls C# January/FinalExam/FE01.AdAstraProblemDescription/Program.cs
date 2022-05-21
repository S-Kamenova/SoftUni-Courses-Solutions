using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace FE01.AdAstra
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string pattern = @"(\||\#)(?<name>[a-zA-Z ]+)(\1)(?<date>(\d{2})(\/)(\d{2})(\/)(\d{2}))(\1)(?<cal>\d+)(\1)";
            int totalCal = 0;

            MatchCollection matches = Regex.Matches(input, pattern);
            foreach (Match item in matches)
            {
                string product = item.Groups["name"].Value;
                string date = item.Groups["date"].Value;
                string cal = item.Groups["cal"].Value;
                totalCal +=int.Parse(cal);

            }
            int days = totalCal / 2000;

            Console.WriteLine($"You have food to last you for: {days} days!");
            foreach (Match item in matches)
            {
                Console.WriteLine($"Item: {item.Groups["name"].Value}, Best before: {item.Groups["date"].Value}, Nutrition: {item.Groups["cal"].Value}");
            }
        }
    }
}
