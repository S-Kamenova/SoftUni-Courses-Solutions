using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace FE05.MirrorWords
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            List<string[]> result = new List<string[]>();

            Regex pattern = new Regex(@"(#|@)([a-zA-Z]{3,})(\1)(\1)([a-zA-Z]{3,})(\1)");


            MatchCollection matches = pattern.Matches(input);

            if (matches.Count==0)
            {
                Console.WriteLine("No word pairs found!");
            }
            else
            {
                Console.WriteLine($"{matches.Count} word pairs found!");
            }

            foreach (Match item in matches)
            {
                string first = item.Groups[2].Value;
                string second = item.Groups[5].Value;

                string reversedSecond = string.Join("", second.Reverse());

                if (first==reversedSecond)
                {
                    result.Add(new string[] { first, second });

                }

            }
            if (result.Count==0)
            {
                Console.WriteLine("No mirror words!");
            }
            else
            {
                string[] messages = result.Select(word => $"{word[0]} <=> {word[1]}").ToArray();
                
                Console.WriteLine("The mirror words are:");
                Console.WriteLine(string.Join(", ",messages));
                
            }
        }
    }
}
