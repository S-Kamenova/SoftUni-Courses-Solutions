using System;

namespace E06.ReplaceRepeatingChars
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            char previousChar = text[0];
            Console.Write(previousChar);

            for (int i = 1; i < text.Length; i++)
            {
                char currentChar = text[i];
                if (previousChar!=currentChar)
                {
                    previousChar = currentChar;
                    Console.Write(previousChar);
                }
            }
        }
    }
}
