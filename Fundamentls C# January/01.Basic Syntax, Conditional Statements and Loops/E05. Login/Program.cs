﻿using System;

namespace E05._Login
{
    class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            string password = string.Empty;

            for (int i = username.Length-1; i >= 0; i--)
            {
                password += username[i];
                               
            }
            for (int count = 1; count <= 4; count++)
            {
                string enterPass = Console.ReadLine();
                if (enterPass == password)
                {
                    Console.WriteLine($"User {username} logged in.");
                    break;

                }
                else
                {
                    if (count==4)
                    {
                        Console.WriteLine($"User {username} blocked!");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Incorrect password. Try again.");
                    }
                }
            }
        }
    }
}
