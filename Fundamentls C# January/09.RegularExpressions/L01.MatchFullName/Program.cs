using System;
using System.Text.RegularExpressions;

namespace L01.MatchFullName
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string pattern = @"\b[A-Z][a-z]+ \b[A-Z][a-z]+";

            Regex regex = new Regex(pattern);

            MatchCollection validNames = regex.Matches(input);


            Console.WriteLine(string.Join(" ", validNames));

            //foreach (Match match in validNames)
            //{
            //    Console.Write($"{match.Value} ");
            //}
        }
    }
}
