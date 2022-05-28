using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FE3.SecretChat
{
    class Program
    {
        static void Main(string[] args)
        {
            string message = Console.ReadLine();

            string comand = Console.ReadLine();
            while (comand!="Reveal")
            {
                string[] token = comand.Split(":|:", StringSplitOptions.RemoveEmptyEntries);
                string action = token[0];

                if (action=="InsertSpace")
                {
                    int index = int.Parse(token[1]);
                    message = message.Insert(index," ");
                    Console.WriteLine(message);

                }
                else if (action=="Reverse")
                {
                    string substring = token[1];
                    if (message.Contains(substring))
                    {
                        int index = message.IndexOf(substring);
                        message = message.Remove(index, substring.Length);

                        //message = message + string.Join("", substring.Reverse());
                       
                        message = message + substring.Reverse();
                        Console.WriteLine(message);
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }

                }
                else if (action== "ChangeAll")
                {
                    string substring = token[1];
                    string replacement = token[2];

                    message = message.Replace(substring, replacement);
                    Console.WriteLine(message);
                }
                comand = Console.ReadLine();
            }
            Console.WriteLine($"You have a new text message: {message}");
        }
    }
}
