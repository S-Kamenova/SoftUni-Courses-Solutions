using System;
using System.Text.RegularExpressions;
using System.Linq;
using System.Collections.Generic;

namespace E06.ExtractEmails
{
    class Program
    {
        static void Main(string[] args)
        {
            string patern= @"(^|\s)[A-Za-z0-9][\w*\-\.]*[A-Za-z0-9]@[A-Za-z]+([.-][A-Za-z]+)\b";

            string input = Console.ReadLine();

            MatchCollection matches = Regex.Matches(input, patern);
            matches.ToList().ForEach(Console.WriteLine);


        }
    }
}
