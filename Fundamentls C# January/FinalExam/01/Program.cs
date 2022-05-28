using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Text;


namespace T02
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            string patternName = @"^(\$|\%)(?<name>[A-Z][a-z]{2,})(\1): (\[(?<numOne>\d+)\])\|(\[(?<numTwo>\d+)\])\|(\[(?<numThree>\d+)\])\|$";

            for (int i = 0; i < num; i++)
            {
                string message = Console.ReadLine();
                Match matched = Regex.Match(message, patternName);

                if (matched.Success)
                {
                    int one = int.Parse(matched.Groups["numOne"].Value);
                    int two = int.Parse(matched.Groups["numTwo"].Value);
                    int three = int.Parse(matched.Groups["numThree"].Value);
                    string tag = matched.Groups["name"].Value;

                    char first = (char)(one);
                    char second = (char)(two);
                    char third = (char)(three);
                    //StringBuilder sb = new StringBuilder();
                    //sb.Append(first);
                    //sb.Append(second);
                    //sb.Append(third);
                    //string characters = sb.ToString();
                    //Console.WriteLine($"{tag}: {characters}");

                    Console.WriteLine($"{tag}: {first}{second}{third}");
                }
                else
                {
                    Console.WriteLine("Valid message not found!");
                }
            }
        }
    }
}