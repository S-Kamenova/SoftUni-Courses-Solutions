using System;
using System.Collections.Generic;

namespace T03

{

    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Dictionary<string, List<int>> book = new Dictionary<string, List<int>>();

            while (input != "Log out")
            {
                string[] comands = input.Split(": ");
                string comand = comands[0];
                string username = comands[1];


                if (comand == "New follower")
                {

                    if (!book.ContainsKey(username))
                    {
                        book.Add(username, new List<int>() { 0, 0 });

                    }
                }
                else if (comand == "Like")
                {

                    int count = int.Parse(comands[2]);
                    if (!book.ContainsKey(username))
                    {
                        book.Add(username, new List<int>() { count, 0 });

                    }
                    else
                    {
                        book[username][0] += count;
                    }
                }
                else if (comand == "Comment")
                {
                    if (!book.ContainsKey(username))
                    {
                        book.Add(username, new List<int>() { 0, 1 });

                    }
                    else
                    {
                        book[username][1] += 1;
                    }
                }
                else if (comand == "Blocked")
                {
                    if (!book.ContainsKey(username))
                    {
                        Console.WriteLine($"{username} doesn't exist.");
                    }
                    else
                    {
                        book.Remove(username);
                    }
                }

                input = Console.ReadLine();
            }
            Console.WriteLine($"{book.Count} followers");
            foreach (var item in book)
            {
                Console.WriteLine($"{item.Key}: {(item.Value[0] + item.Value[1])}");
            }
        }
    }
}
