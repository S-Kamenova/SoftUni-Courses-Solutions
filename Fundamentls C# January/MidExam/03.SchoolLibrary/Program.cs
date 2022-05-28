using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.SchoolLibrary
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> library = Console.ReadLine().Split("&", StringSplitOptions.RemoveEmptyEntries).ToList();

            string comand = Console.ReadLine();


            while (comand != "Done")
            {
                string[] token = comand.Split(" | ", StringSplitOptions.RemoveEmptyEntries);
                string action = token[0];

                if (token[0] == "Add Book")
                {
                    if (!library.Contains(token[1]))
                    {
                        library.Insert(0, token[1]);
                    }
                }
                else if (token[0] == "Take Book")
                {
                    if (library.Contains(token[1]))
                    {
                        library.Remove(token[1]);
                    }
                }
                else if (token[0] == "Swap Books")
                {
                    if (library.Contains(token[1]) && library.Contains(token[2]))
                    {
                        int indexFirstBook = library.IndexOf(token[1]);
                        int indexSecondBook = library.IndexOf(token[2]);

                        library[indexFirstBook] = token[2];
                        library[indexSecondBook] = token[1];
                    }
                }
                else if (token[0] == "Insert Book")
                {
                    if (!library.Contains(token[1]))
                    {
                        library.Add(token[1]);
                    }
                }
                else if (token[0] == "Check Book")
                {
                    if (int.Parse(token[1]) >= 0 && int.Parse(token[1]) < library.Count)
                    {
                        Console.WriteLine($"{library[int.Parse(token[1])]}");
                    }
                }

                comand = Console.ReadLine();
            }
            Console.WriteLine(string.Join(", ", library));
        }
    }
}
