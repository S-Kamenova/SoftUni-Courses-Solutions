using System;
using System.Text.RegularExpressions;
using System.Linq;
using System.Collections.Generic;

namespace E05.NetherRealms
{
    class Program
    {
        static void Main(string[] args)
        {
            string helthPattern = @"[^\+\-\*\/\.\,0-9 ]";
            string damagePattern = @"-?\d+\.?\d*";
            string multy = @"[\*\/]";
            string splitPattern = @"[,\s]+";

            string input = Console.ReadLine();
            string[] demons = Regex.Split(input, splitPattern).OrderBy(x => x).ToArray();

            for (int i = 0; i < demons.Length; i++)
            {
                string currDemon = demons[i];
                MatchCollection healthMatched = Regex.Matches(currDemon, helthPattern);
                long health = 0;
                foreach (Match item in healthMatched)
                {
                    char currChar = char.Parse(item.ToString());
                    health += currChar;
                }
                decimal damage = 0;
                MatchCollection damageMatched = Regex.Matches(currDemon, damagePattern);
                foreach (Match item in damageMatched)
                {
                    decimal currDamage = decimal.Parse(item.ToString());
                    damage += currDamage;
                }

                MatchCollection multiplyD = Regex.Matches(currDemon, multy);
                foreach (Match item in multiplyD)
                {
                    char currOperatino = char.Parse(item.ToString());
                    if (currOperatino=='*')
                    {
                        damage *= 2;
                    }
                    else
                    {
                        damage /= 2;
                    }
                }
                Console.WriteLine($"{currDemon} - {health} health, {damage:f2} damage");
            }
        }
    }
}
