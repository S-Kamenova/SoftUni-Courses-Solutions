using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FE2.PasswordReset
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();

            string comand = Console.ReadLine();
            while (comand != "Done")
            {
                string[] token = comand.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string action = token[0];
                if (action == "TakeOdd")
                {
                    //char[] oddChars = text.Where((character, index) => index % 2 != 0);
                    // text = string.Join(string.Empty, oddChars);

                    string text = string.Empty;
                    char[] newpass = password.ToCharArray();
                    for (int i = 1; i < newpass.Length; i += 2)
                    {
                        if (!(i % 2 == 0))
                        {

                            text += newpass[i];
                        }
                    }
                    password = text;
                    Console.WriteLine(password);
                }
                else if (action == "Cut")
                {
                    int index = int.Parse(token[1]);
                    int lenght = int.Parse(token[2]);

                    //string substring = password.Substring(index, lenght);
                    //int place = password.IndexOf(substring);
                    //password = password.Remove(place, substring.Length);

                    password = password.Remove(index, lenght);

                    Console.WriteLine(password);
                }
                else if (action == "Substitute")
                {
                    string substring = token[1];
                    string substitute = token[2];

                    if (password.Contains(substring))
                    {
                        password = password.Replace(substring, substitute);
                        Console.WriteLine(password);
                    }
                    else
                    {
                        Console.WriteLine("Nothing to replace!");
                    }
                }

                comand = Console.ReadLine();
            }
            Console.WriteLine($"Your password is: {password}");
        }
    }
}
