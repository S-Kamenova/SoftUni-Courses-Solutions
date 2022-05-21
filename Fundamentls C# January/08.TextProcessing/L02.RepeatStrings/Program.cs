using System;

namespace L02.RepeatStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] allWords = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

            string result = string.Empty;

            foreach (var item in allWords)
            {
                for (int i = 0; i < item.Length; i++)
                {
                    result += item;
                }
            }
            Console.WriteLine(result);
        }
    }
}
