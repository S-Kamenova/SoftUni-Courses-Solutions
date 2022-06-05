using System;

namespace DefiningClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Family family = new Family();

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();

                Person person = new Person(input.Split()[0], int.Parse(input.Split()[1]));
                family.AddMember(person);
            }

            Person oldest = family.GetoldestMember();
            Console.WriteLine(oldest.Name + " " + oldest.Age);

        }
    }
}
