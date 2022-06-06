using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string data = Console.ReadLine();

                Person person = new Person(data.Split()[0], int.Parse(data.Split()[1]));
                people.Add(person);

            }
            foreach (var man in people.OrderBy(x=>x.Name).Where(x => x.Age>30))
            {
                Console.WriteLine($"{man.Name} - {man.Age}");
            }

        }
    }
}
