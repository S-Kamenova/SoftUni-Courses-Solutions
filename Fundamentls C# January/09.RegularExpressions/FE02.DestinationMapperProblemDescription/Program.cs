using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace FE02.DestinationMapper
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Regex pattern = new Regex(@"(\=|\/)(?<destination>[A-Z][A-Za-z]{2,})(\1)");
           // string pattern = @"(\=|\/)(?<destination>[A-Z][A-Za-z]{2,})(\1)";

            List<string> destination = new List<string>();
            int points = 0;

            MatchCollection matches = pattern.Matches(input);

            foreach (Match item in matches)
            {
                string currDestination = item.Groups["destination"].Value;
                destination.Add(currDestination);
                points += currDestination.Length;
            }
            Console.WriteLine($"Destinations: {string.Join(", ",destination)}");
            Console.WriteLine($"Travel Points: {points}");
        }
    }
}
