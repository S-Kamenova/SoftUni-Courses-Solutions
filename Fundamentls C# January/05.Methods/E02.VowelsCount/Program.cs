using System;
using System.Linq;

namespace E02.VowelsCount
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine().ToLower();

            Console.WriteLine(GetVowelsCount(word));
        }

        static int GetVowelsCount(string word)
        {
            char[] vowels = new char[] { 'a', 'e', 'i', 'o', 'u' };

            int count = 0;
            foreach (char ch in word)
            {
                if (vowels.Contains(ch))
                {
                    count++;
                }
            }
            return count;
        }
    }
}
