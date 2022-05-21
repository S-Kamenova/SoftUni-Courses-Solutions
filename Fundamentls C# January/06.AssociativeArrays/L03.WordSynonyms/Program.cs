using System;
using System.Collections.Generic;

namespace L03.WordSynonyms
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            Dictionary<string, List<string>> synonymList = new Dictionary<string, List<string>>();

            for (int i = 1; i <= num; i++)
            {
                string word = Console.ReadLine();
                string synonym = Console.ReadLine();

                if (!synonymList.ContainsKey(word))
                {
                    synonymList.Add(word, new List<string>());
                }
                synonymList[word].Add(synonym);
            }
            foreach (var item in synonymList)
            {
                Console.WriteLine($"{item.Key} - {string.Join(", ", item.Value)}");
            }
        }
    }
}
