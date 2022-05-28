using System;
using System.Collections.Generic;
using System.Linq;

namespace FE4.HeroesOfCodeAndLogic
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            Dictionary<string, List<int>> game = new Dictionary<string, List<int>>();

            for (int i = 0; i < num; i++)
            {
                string[] token = Console.ReadLine().Split();
                string name = token[0];
                int hitpoints = int.Parse(token[1]);
                int manapoints = int.Parse(token[2]);

                game.Add(name, new List<int>() { hitpoints, manapoints });
            }

            string comand = Console.ReadLine();
            while (comand != "End")
            {
                string[] comands = comand.Split(" - ");
                string action = comands[0];
                string heroName = comands[1];

                if (action == "CastSpell")
                {
                    int MPneeded = int.Parse(comands[2]);
                    string spellName = comands[3];

                    if (game[heroName][1] >= MPneeded)
                    {
                        game[heroName][1] -= MPneeded;
                        Console.WriteLine($"{heroName} has successfully cast {spellName} and now has {game[heroName][1]} MP!");
                    }
                    else
                    {
                        Console.WriteLine($"{heroName} does not have enough MP to cast {spellName}!");
                    }

                }
                else if (action == "TakeDamage")
                {
                    int damage = int.Parse(comands[2]);
                    string attacker = comands[3];

                    game[heroName][0] -= damage;
                    if (game[heroName][0] > 0)
                    {
                        Console.WriteLine($"{heroName} was hit for {damage} HP by {attacker} and now has {game[heroName][0]} HP left!");
                    }
                    else
                    {
                        Console.WriteLine($"{heroName} has been killed by {attacker}!");
                        game.Remove(heroName);
                    }

                }
                else if (action == "Recharge")
                {
                    int amount = int.Parse(comands[2]);
                    int current = game[heroName][1];
                    game[heroName][1] += amount;

                    if (game[heroName][1] > 200)
                    {
                        Console.WriteLine($"{heroName} recharged for {200- current} MP!");
                        game[heroName][1] = 200;
                    }
                    else
                    {
                        Console.WriteLine($"{heroName} recharged for {amount} MP!");
                    }
                    
                }
                else if (action == "Heal")
                {
                    int amount = int.Parse(comands[2]);
                    int current = game[heroName][0];
                    game[heroName][0] += amount;
                    if (game[heroName][0] > 100)
                    {
                        Console.WriteLine($"{heroName} healed for {100- current} HP!");
                        game[heroName][0] = 100;
                    }
                    else
                    {
                        Console.WriteLine($"{heroName} healed for {amount} HP!");
                    }
                    
                }
                comand = Console.ReadLine();
            }
            foreach (var item in game)
            {
                Console.WriteLine($"{item.Key}");
                Console.WriteLine($"  HP: {item.Value[0]}");
                Console.WriteLine($"  MP: {item.Value[1]}");
            }
        }
    }
}
