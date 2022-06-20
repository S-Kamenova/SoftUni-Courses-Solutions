using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace T105.FoodFinder
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<char> vowels = new Queue<char>(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(char.Parse));
            Stack<char> consonants = new Stack<char>(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(char.Parse));

            List<char> chars = new List<char>();
            Dictionary<string, int> words = new Dictionary<string, int>()
            {
                { "pear",0 },
                { "flour",0 },
                { "pork",0},
                { "olive",0}
,
            };

            string pear = "pear";
            string flour = "flour";
            string pork = "pork";
            string olive = "olive";


            int pearLength = pear.Length;
            int flourLength = flour.Length;
            int porkLength = pork.Length;
            int oliveLength = olive.Length;


            while (consonants.Count>0)
            {
                var currVowel = vowels.Dequeue();
                var currConsonant = consonants.Pop();

                
                if (!chars.Contains(currVowel))
                {
                    if (pear.Contains(currVowel))
                    {
                        pearLength--;
                    }
                    if (flour.Contains(currVowel))
                    {
                        flourLength--;
                    }
                    if (pork.Contains(currVowel))
                    {
                        porkLength--;
                    }
                    if (olive.Contains(currVowel))
                    {
                        oliveLength--;
                    }
                }
                if (pear.Contains(currConsonant))
                {
                    pearLength--;
                }
                if (flour.Contains(currConsonant))
                {
                    flourLength--;
                }
                if (pork.Contains(currConsonant))
                {
                    porkLength--;
                }
                if (olive.Contains(currConsonant))
                {
                    oliveLength--;
                }

                if (pearLength == 0)
                {
                    words["pear"]++;
                }
                if (flourLength == 0)
                {
                    words["flour"]++;
                }
                if (porkLength == 0)
                {
                    words["pork"]++;
                }
                if (oliveLength == 0)
                {
                    words["olive"]++;
                }


                chars.Add(currVowel);
                vowels.Enqueue(currVowel);
            }
            Console.WriteLine($"Words found: {words.Where(x => x.Value > 0).Count()}");
            foreach (var word in words)
            {
                if (word.Value > 0)
                {
                    Console.WriteLine(word.Key);
                }
            }

        }
    }
}
