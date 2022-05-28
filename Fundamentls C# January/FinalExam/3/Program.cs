using System;
using System.Linq;
using System.Text;

namespace T01
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string comand = Console.ReadLine();
            while (comand != "End")
            {
                string[] comands = comand.Split(" ",StringSplitOptions.RemoveEmptyEntries);
                string action = comands[0];

                if (action == "Translate")
                {
                    char character = char.Parse(comands[1]);
                    char replacement = char.Parse(comands[2]);

                    if (input.Contains(character))
                    {
                        input = input.Replace(character, replacement);
                    }
                    Console.WriteLine(input);
                }
                else if (action == "Includes")
                {
                    string substring = comands[1];

                    if (input.Contains(substring))
                    {
                        Console.WriteLine("True");
                    }
                    else
                    {
                        Console.WriteLine("False");
                    }
                }
                else if (action == "Start")
                {
                    string substring = comands[1];

                    if (input.Contains(substring))
                    {
                        int index = input.IndexOf(substring);

                        if (index == 0)
                        {
                            Console.WriteLine("True");
                        }
                        else
                        {
                            Console.WriteLine("False");
                        }
                    }
                }
                else if (action == "Lowercase")
                {
                    input = input.ToLower();
                    Console.WriteLine(input);
                }
                else if (action == "FindIndex")
                {
                    char character = char.Parse(comands[1]);

                    if (input.Contains(character))
                    {
                        int index = input.LastIndexOf(character);
                        Console.WriteLine(index);
                    }
                }
                else if (action == "Remove")
                {
                    int startIndex = int.Parse(comands[1]);
                    int count = int.Parse(comands[2]);
                    if (startIndex<input.Length && startIndex>=0)
                    {
                        int newindex = startIndex + count;
                        if (newindex>=0 && newindex<input.Length)
                        {
                            input = input.Remove(startIndex, count);
                        }
                    }
                    
                    Console.WriteLine(input);
                }
                comand = Console.ReadLine();
            }
        }
    }
}
