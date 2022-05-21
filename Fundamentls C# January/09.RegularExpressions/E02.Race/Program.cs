using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace E02.Race
{
    class Program
    {
        static void Main(string[] args)
        {
            string patternName = @"(?<name>[A-Za-z]+)";
            string patternDigits = @"(?<digits>\d+)";

            Dictionary<string, int> participant = new Dictionary<string, int>();

            List<string> names = Console.ReadLine().Split(", ").ToList();

            string input = Console.ReadLine();

            Regex nameRegex = new Regex(patternName);
            Regex digitRegex = new Regex(patternDigits);

            var sumOfDigits = 0;

            
            while (input != "end of race")
            {
                MatchCollection matchedNames = Regex.Matches(input, patternName);
                MatchCollection matchedDigits = Regex.Matches(input, patternDigits);
                var currName = string.Join("", matchedNames);
                var currDigit = string.Join("", matchedDigits);

                sumOfDigits = 0;
                for (int i = 0; i < currDigit.Length; i++)
                {
                    sumOfDigits += int.Parse(currDigit[i].ToString());
                }

                if (names.Contains(currName))
                {
                    if (!participant.ContainsKey(currName))
                    {
                        participant.Add(currName, sumOfDigits);
                    }
                    else
                    {
                        participant[currName] += sumOfDigits;
                    }
                }

                input = Console.ReadLine();
            }

            var winners = participant.OrderByDescending(x => x.Value).Take(3);

            int counter = 1;
            foreach (var item in winners)
            {
                string text = counter == 1 ? "st" : counter == 2 ? "nd" : "rd";
                Console.WriteLine($"{counter++}{text} place: {item.Key}");
            }

            //var first = winners.Take(1);
            //var second = winners.OrderByDescending(x => x.Value).Take(2).OrderBy(x => x.Value).Take(1);
            //var third = winners.OrderBy(x => x.Value).Take(1);

            //foreach (var firstname in first)
            //{
            //    Console.WriteLine($"1st place: {firstname.Key}");
            //}
            //foreach (var secondName in second)
            //{
            //    Console.WriteLine($"2nd place: {secondName.Key}");
            //}
            //foreach (var thirtdName in third)
            //{
            //    Console.WriteLine($"3rd place: {thirtdName.Key}");
            //}


        }
    }
}
