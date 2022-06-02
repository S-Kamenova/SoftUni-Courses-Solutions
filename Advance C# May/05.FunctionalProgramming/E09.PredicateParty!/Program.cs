using System;
using System.Collections.Generic;
using System.Linq;

namespace E09.PredicateParty
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> people = Console.ReadLine().Split().ToList();

            string comand = Console.ReadLine();


            while (comand != "Party!")
            {
                Predicate<string> predicate = GetPredicate(comand);

                if (comand.StartsWith("Double"))
                {
                    for (int i = 0; i < people.Count; i++)
                    {
                        string person = people[i];
                        if (predicate(person))
                        {
                            people.Insert(people.IndexOf(person) + 1, person);
                            i++;
                        }
                    }
                }
                else if (comand.StartsWith("Remove"))
                {
                    people.RemoveAll(predicate);
                }

                comand = Console.ReadLine();
            }
            if (people.Count == 0)
            {
                Console.WriteLine("Nobody is going to the party!");
            }
            else
            {
                Console.WriteLine($"{string.Join(", ", people)} are going to the party!");
            }


            static Predicate<string> GetPredicate(string comand)
            {
                string comand2 = comand.Split()[1];
                string arg = comand.Split()[2];

                Predicate<string> predicate = null;

                if (comand2 == "StartsWith")
                {
                    predicate = name => name.StartsWith(arg);
                }
                else if (comand2 == "EndsWith")
                {
                    predicate = name => name.EndsWith(arg);
                }
                else if (comand2 == "Length")
                {
                    predicate = name => name.Length == int.Parse(arg);
                }
                return predicate;

            }
        }
    }
}
