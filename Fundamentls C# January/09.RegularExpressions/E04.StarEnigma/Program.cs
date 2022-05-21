using System;
using System.Text.RegularExpressions;
using System.Linq;
using System.Collections.Generic;

namespace E04.StarEnigma
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> attacked = new List<string>();
            List<string> destroyed = new List<string>();
            
            string pattern = @"@(?<planet>[A-z]+)[^@\-!:>]*:(\d+)[^@\-!:>]*!(?<type>[A,D])![^@\-!:>]*->(\d+)";

            int n =int.Parse( Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string messages = Console.ReadLine();
                int sum = messages.ToLower().Count(x => x == 's' || x == 't' || x == 'a' || x == 'r');

                string decripted = "";
                foreach (char charType in messages)
                {
                    decripted += (char)(charType - sum);

                }
                Match matches = Regex.Match(decripted, pattern, RegexOptions.IgnoreCase);
                if (matches.Success)
                {
                    string name = matches.Groups["planet"].Value;
                    char type = char.Parse(matches.Groups["type"].Value);
                    
                    if (type=='A')
                    {
                        attacked.Add(name);
                    }
                    else if(type=='D')
                    {
                        destroyed.Add(name);
                    }

                }
            }
            Console.WriteLine($"Attacked planets: {attacked.Count}");
            attacked.OrderBy(x => x).ToList().ForEach(x => Console.WriteLine($"-> {x}"));
            Console.WriteLine($"Attacked planets: {destroyed.Count}");
            destroyed.OrderBy(x => x).ToList().ForEach(x => Console.WriteLine($"-> {x}"));
        }
    }
}
