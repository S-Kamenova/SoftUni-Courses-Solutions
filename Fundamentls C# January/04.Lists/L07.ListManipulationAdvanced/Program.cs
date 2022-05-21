using System;
using System.Collections.Generic;
using System.Linq;

namespace L07.ListManipulationAdvanced
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
            bool hasChange = false;
            while (comand != "end")
            {
                string[] token = comand.Split();
                string action = token[0];

                if (action == "Add")
                {
                    int numberToAdd = int.Parse(token[1]);
                    numbers.Add(numberToAdd);
                    hasChange = true;
                }
                else if (action == "Remove")
                {
                    int numberToRemove = int.Parse(token[1]);
                    numbers.Remove(numberToRemove);
                    hasChange = false;

                }
                else if (action == "RemoveAt")
                {
                    int indexToRemove = int.Parse(token[1]);
                    numbers.RemoveAt(indexToRemove);
                    hasChange = false;

                }
                else if (action == "Insert")
                {
                    int elementToInsert = int.Parse(token[1]);
                    int indexToInsert = int.Parse(token[2]);
                    numbers.Insert(indexToInsert, elementToInsert);
                    hasChange = false;
                }
                else if (action == "Contains")
                {
                    int elementsToCheck = int.Parse(token[1]);
                    if (numbers.Contains(elementsToCheck))
                    {
                        Console.WriteLine("Yes");
                    }
                    else
                    {
                        Console.WriteLine("No such number");
                    }
                }
                else if (action == "PrintEven")
                {
                    List<int> evenNumbers = numbers.FindAll(x => x % 2 == 0);
                    Console.WriteLine(string.Join(" ", evenNumbers));
                }
                else if (action == "PrintOdd")
                {
                    List<int> oddNumbers = numbers.FindAll(x => x % 2 != 0);
                    Console.WriteLine(string.Join(" ", oddNumbers));
                }
                else if (action == "GetSum")
                {
                    int sum = numbers.Sum();
                    Console.WriteLine(sum);
                }
                else if (action == "Filter")
                {
                    string condition = token[1];
                    int numberForComparison = int.Parse(token[2]);
                    List<int> result = GetFilterNumbers(numbers, condition, numberForComparison);
                    Console.WriteLine(string.Join(" ", result));
                }

                comand = Console.ReadLine();
            }
            if (hasChange)
            {
            Console.WriteLine(string.Join(" ", numbers));
            }
        }

        static List<int> GetFilterNumbers(List<int> allNumbers, string condition, int numberOfCompare)
        {
            if (condition == "<")
            {
                List<int> result = allNumbers.FindAll(x => x < numberOfCompare);
                return result;
            }
            else if (condition == ">")
            {
                List<int> result = allNumbers.FindAll(x => x > numberOfCompare);
                return result;
            }
            else if (condition == "<=")
            {
                List<int> result = allNumbers.FindAll(x => x <= numberOfCompare);
                return result;
            }
            else if (condition == ">=")
            {
                List<int> result = allNumbers.FindAll(x => x >= numberOfCompare);
                return result;
            }
            else
            {
                return allNumbers;
            }
        }
    }
}
