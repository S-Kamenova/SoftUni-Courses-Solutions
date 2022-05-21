using System;

namespace L01.ReverseStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();


            while (text != "end")
            {
                char[] wordArr = text.ToCharArray();
                Array.Reverse(wordArr);
                string reversed = new string(wordArr);

                Console.WriteLine($"{text} = {reversed}");

                text = Console.ReadLine();
            }

        }
    }
}
