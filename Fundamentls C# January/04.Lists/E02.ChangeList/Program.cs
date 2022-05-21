using System;
using System.Collections.Generic;
using System.Linq;

namespace E02.ChangeList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                 .Split()
                 .Select(int.Parse)
                 .ToList();

            string comand = Console.ReadLine();

            while (comand != "end")
            {
                string[] token = comand.Split();

                string action = token[0];
                if (action == "Delete")
                {
                    int element = int.Parse(token[1]);
                    numbers.RemoveAll(x => x == element);

                }
                if (action=="Insert")
                {
                    int element = int.Parse(token[1]);
                    int position = int.Parse(token[2]);

                    numbers.Insert(position, element);
                }
                comand = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
