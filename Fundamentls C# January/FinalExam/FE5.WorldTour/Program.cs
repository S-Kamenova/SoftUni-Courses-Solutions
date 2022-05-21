using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FE5.WorldTour
{
    class Program
    {
        static void Main(string[] args)
        {
            string stops = Console.ReadLine();

            string comand = Console.ReadLine();
            while (comand != "Travel")
            {
                string[] token = comand.Split(':');
                string action = token[0];

                if (action == "Add Stop")
                {
                    int index = int.Parse(token[1]);
                    string text = token[2];

                    if (index >= 0 && (index < stops.Length))
                    {
                        stops = stops.Insert(index, text);
                    }

                    Console.WriteLine(stops);

                }
                else if (action == "Remove Stop")
                {
                    int startIndex = int.Parse(token[1]);
                    int endIndex = int.Parse(token[2]);

                    if (startIndex >= 0 && (startIndex < stops.Length) && (endIndex >= 0) && (endIndex < stops.Length))
                    {
                        if (startIndex <= endIndex)
                        {
                            stops = stops.Remove(startIndex, endIndex + 1 - startIndex);
                        }
                    }
                    Console.WriteLine(stops);

                }
                else if (action == "Switch")
                {
                    string oldText = token[1];
                    string newText = token[2];

                    if (stops.Contains(oldText))
                    {
                        stops = stops.Replace(oldText, newText);
                    }
                    Console.WriteLine(stops);
                }
                comand = Console.ReadLine();

            }
            Console.WriteLine($"Ready for world tour! Planned stops: {stops}");
        }
    }
}
