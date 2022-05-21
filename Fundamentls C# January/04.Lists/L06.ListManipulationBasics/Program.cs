using System;
using System.Collections.Generic;
using System.Linq;

namespace L06.ListManipulationBasics
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

            while (comand!="end")
            {
                string[] token = comand.Split();
                string action = token[0];

                if (action=="Add")
                {
                    int numberToAdd = int.Parse(token[1]);
                    numbers.Add(numberToAdd);
                }
                else if (action=="Remove")
                {
                    int numberToRemove = int.Parse(token[1]);
                    numbers.Remove(numberToRemove);

                }
                else if (action == "RemoveAt")
                {
                    int indexToRemove = int.Parse(token[1]);
                    numbers.RemoveAt(indexToRemove);

                }
                else if (action == "Insert")
                {
                    int elementToInsert = int.Parse(token[1]);
                    int indexToInsert = int.Parse(token[2]);
                    numbers.Insert(indexToInsert, elementToInsert);
                }

                                comand = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
