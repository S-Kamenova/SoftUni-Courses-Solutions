using System;
using System.Collections.Generic;
using System.Linq;

namespace E03.HouseParty
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            List<string> people = new List<string>();

            
            for (int i = 0; i < num; i++)
            {

                List<string> comands = Console.ReadLine().Split().ToList();
                if (comands[2]=="going!")
                {
                    if (people.Contains(comands[0]))
                    {
                        Console.WriteLine($"{comands[0]} is already in the list!");
                    }
                    else
                    {
                        people.Add(comands[0]);
                    }
                }
                else if (comands[2]=="not")
                {
                    if (people.Contains(comands[0]))
                    {
                        people.Remove(comands[0]);
                    }
                    else
                    {
                        Console.WriteLine($"{comands[0]} is not in the list!");
                    }
                }

            }
            foreach (var item in people)
            {
                Console.WriteLine(item);
            }
        }
    }
}
