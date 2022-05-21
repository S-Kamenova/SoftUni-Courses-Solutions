using System;
using System.Collections.Generic;

namespace E05.SoftUniParking
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            Dictionary<string, string> users = new Dictionary<string, string>();

            for (int i = 0; i < number; i++)
            {
                string[] token = Console.ReadLine().Split();

                string comand = token[0];
                string username = token[1];
                

                if (comand == "register")
                {
                    string licensePlateNumber = token[2];
                    if (!users.ContainsKey(username))
                    {
                        users.Add(username, licensePlateNumber);
                        Console.WriteLine($"{username} registered {licensePlateNumber} successfully");
                    }
                    else
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {licensePlateNumber}");
                    }
                }
                else if (comand == "unregister")
                {
                    if (!users.ContainsKey(username))
                    {
                        Console.WriteLine($"ERROR: user {username} not found");
                    }
                    else
                    {
                        Console.WriteLine($"{username} unregistered successfully");
                        users.Remove(username);
                    }
                }
            }
            foreach (var item in users)
            {
                Console.WriteLine($"{item.Key} => {item.Value}");
            }
        }
    }
}
