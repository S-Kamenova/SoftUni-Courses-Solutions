using System;

namespace E04.CaesarCipher
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string result = string.Empty;

            foreach (char item in input)
            {
                int currPosition = item;
                currPosition += 3;
                result += (char)currPosition;

            }
            Console.WriteLine(result);
        }
    }
}
