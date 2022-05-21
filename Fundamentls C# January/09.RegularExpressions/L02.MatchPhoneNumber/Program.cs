using System;
using System.Text.RegularExpressions;

namespace L02.MatchPhoneNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string pattern = @"\+359([ |-])2\1\d{3}\1\d{4}\b";

            MatchCollection matches = Regex.Matches(text, pattern);
            Console.WriteLine(string.Join(", ", matches));
        }
    }
}
