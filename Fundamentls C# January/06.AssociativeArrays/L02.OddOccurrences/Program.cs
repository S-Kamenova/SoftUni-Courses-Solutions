using System;
using System.Collections.Generic;
using System.Linq;

namespace L02.OddOccurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

            Dictionary<string, int> numWord = new Dictionary<string, int>();

            foreach (var word in words)
            {
                string lowerWord = word.ToLower();

                if (numWord.ContainsKey(lowerWord))
                {
                    numWord[lowerWord] += 1;
                }
                else
                {
                    numWord.Add(lowerWord,1);
                }

            }
            string[] result = numWord.Where(item => item.Value % 2 != 0)
                 .Select(item => item.Key)
                 .ToArray();
            Console.WriteLine(string.Join(' ',result));
        }
    }
}
