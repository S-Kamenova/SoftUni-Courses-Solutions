using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FE4.TheImitationGame
{
    class Program
    {
        static void Main(string[] args)
        {
            string message = Console.ReadLine();

            string comand = Console.ReadLine();
            while (comand != "Decode")
            {
                string[] token = comand.Split('|', StringSplitOptions.RemoveEmptyEntries);
                string action = token[0];

                if (action == "Move")
                {
                    int numberOfLetters = int.Parse(token[1]);
                    string text = message.Substring(0,numberOfLetters);
                    message = message.Remove(0,numberOfLetters);
                    message = message + text;


                }
                else if (action == "Insert")
                {
                    int index = int.Parse(token[1]);
                    string value = token[2];

                    message = message.Insert(index, value);

                }
                else if (action == "ChangeAll")
                {
                    string substring = token[1];
                    string substitute = token[2];

                    message = message.Replace(substring, substitute);

                }
                comand = Console.ReadLine();
            }
            Console.WriteLine($"The decrypted message is: {message}");
        }
    }
}
