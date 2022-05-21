using System;
using System.Collections.Generic;
using System.Linq;

namespace E04.ListOperations
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

            while (comand != "End")
            {
                string[] token = comand.Split();
                string action = token[0];
                if (action == "Add")
                {
                    int num = int.Parse(token[1]);
                    numbers.Add(num);

                }
                else if (action == "Insert")
                {
                    int num = int.Parse(token[1]);
                    int index = int.Parse(token[2]);
                    if (index < 0 || index >= numbers.Count)
                    {
                        Console.WriteLine("Invalid index");
                    }
                    else
                    {
                        numbers.Insert(index, num);
                    }
                }
                else if (action == "Remove")
                {
                    int index = int.Parse(token[1]);
                    if (index < 0 || index >= numbers.Count)
                    {
                        Console.WriteLine("Invalid index");
                    }
                    else
                    {
                        numbers.RemoveAt(index);
                    }
                }
                else if (action == "Shift")
                {
                    string directrion = token[1];
                    int count = int.Parse(token[2]);

                    if (directrion=="left")
                    {
                        for (int i = 0; i < count; i++)
                        {
                            int element = numbers[0];
                            numbers.RemoveAt(0);
                            numbers.Add(element);
                        }
                    }
                    else if (directrion == "right")
                    {
                        for (int i = 0; i < count; i++)
                        {
                            int element = numbers[numbers.Count-1];
                            numbers.RemoveAt(numbers.Count-1);
                            numbers.Insert(0,element);
                        }
                    }
                }


                comand = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
