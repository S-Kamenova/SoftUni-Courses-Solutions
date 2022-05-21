using System;

namespace L03.Substring
{
    class Program
    {
        static void Main(string[] args)
        {
            string wordRemove = Console.ReadLine();
            string text = Console.ReadLine();

            while (text.Contains(wordRemove))
            {
                //int startIndexOfWordRemove = text.IndexOf(wordRemove);
                //text = text.Remove(startIndexOfWordRemove,wordRemove.Length);

                text = text.Replace(wordRemove, "");


            }

            Console.WriteLine(text);
        }
    }
}
