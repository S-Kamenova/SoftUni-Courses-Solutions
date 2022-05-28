using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            string comand = Console.ReadLine();

            while (comand != "Finish")
            {
                string[] token = comand.Split(" ");
                string action = token[0];

                if (token[0] == "Add")
                {
                    numbers.Add(int.Parse(token[1]));
                }
                else if (token[0]=="Remove")
                {
                    numbers.Remove(int.Parse(token[1]));
                }
                else if (token[0]=="Replace")
                {
                    if (numbers.Contains(int.Parse(token[1])))
                    {
                        numbers[numbers.IndexOf(int.Parse(token[1]))] = int.Parse(token[2]);
                    }
                }
                else if (token[0]=="Collapse")
                {
                    numbers.RemoveAll(x => x < int.Parse(token[1]));
                }
                comand = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", numbers));


        }
    }
}
