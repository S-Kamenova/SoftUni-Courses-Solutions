using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Collections.Generic;


namespace FE03.EmojiDetector
{
    class Program
    {
        static void Main(string[] args)
        {
            string patternEmoji = @"(\:\:|\*\*)(?<emoji>[A-Z][a-z]{2,})(\1)";
            string patternDigit = @"\d";

            string input = Console.ReadLine();
            long cool = 1;
            

            MatchCollection matchesDigit = Regex.Matches(input, patternDigit);
            foreach (Match item in matchesDigit)
            {
                cool *= int.Parse(item.Value.ToString());
            }
            Console.WriteLine($"Cool threshold: {cool}");

            MatchCollection matchesEmoji = Regex.Matches(input, patternEmoji);
            
            Console.WriteLine($"{matchesEmoji.Count} emojis found in the text. The cool ones are:");
            
            foreach (Match item in matchesEmoji)
            {
                long emodjiCool = 0;
                char[] charArr = item.ToString().Where(x=>char.IsLetter(x)).ToArray();
                for (int i = 0; i < charArr.Length; i++)
                {
                    char currChar = charArr[i];
                   
                    emodjiCool += currChar;

                }

                if (emodjiCool >= cool)
                {
                    Console.WriteLine(item);
                }
               
            }
        }
    }
}
