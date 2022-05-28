using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.MemoryGame
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> elements = Console.ReadLine()
                 .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                 .ToList();

            string comand = Console.ReadLine();
            int moveCount = 0;

            while (comand!="end")
            {
                moveCount++;
                string[] token = comand.Split();
                int first = int.Parse(token[0]);
                int second = int.Parse(token[1]);


                if (IsInvalidGues(first,second,elements))
                {
                    int middleOfElements = elements.Count / 2;
                    string elementToAdd = $"-{moveCount}a";
                    elements.Insert(middleOfElements, elementToAdd);
                    elements.Insert(middleOfElements, elementToAdd);

                }
                else if (elements[first]==elements[second])
                {
                    string guessedElements = elements[first];
                    elements.RemoveAll(x => x == guessedElements);
                    Console.WriteLine($"Congrats! You have found matching elements - {guessedElements}!");

                }
                else if (elements[first]!=elements[second])
                {
                    Console.WriteLine("Try again!");
                }
                if (elements.Count==0)
                {
                    Console.WriteLine($"You have won in {moveCount} turns!");
                }
                comand = Console.ReadLine();
            }
        }
        static bool IsInvalidGues(int first, int second, List<string> elements)
        {
            return first == second
                || !IsGuessInList(first, elements)
                || !IsGuessInList(second, elements);
        }

        static bool IsGuessInList(int guess, List<string> elements)
        {
            return guess >= 0 && guess < elements.Count;
        }
    }
}
