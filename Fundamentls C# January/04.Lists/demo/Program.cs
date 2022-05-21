using System;
using System.Collections.Generic;
using System.Linq;

namespace demo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> wagons = Console.ReadLine()
                 .Split()
                 .Select(int.Parse)
                 .ToList();

            int maxCap = int.Parse(Console.ReadLine());

            string comand = Console.ReadLine();

            while (comand!="end")
            {
                string[] token = comand.Split();
                string action = token[0];
                if (token.Length==2)
                {
                    int pass = int.Parse(token[1]);
                    wagons.Add(pass);
                }
                else
                {

                }
                


                comand = Console.ReadLine();
            }
        }
    }
}
