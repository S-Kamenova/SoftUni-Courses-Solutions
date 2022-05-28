using System;
using System.Collections.Generic;
using System.Linq;

namespace FE3.ThePianist
{
    class Program
    {
        static void Main(string[] args)
        {
            int numPieces = int.Parse(Console.ReadLine());

            Dictionary<string, List<string>> pianist = new Dictionary<string, List<string>>();

            for (int i = 0; i < numPieces; i++)
            {
                string[] token = Console.ReadLine().Split("|");
                string piece = token[0];
                string composer = token[1];
                string key = token[2];
                pianist.Add(piece, new List<string>() { composer, key });
            }

            //foreach (var item in pianist)
            //{
            //    Console.WriteLine($"{item.Key} - {string.Join(", ", item.Value)}");
            //}


            string comand = Console.ReadLine();
            while (comand != "Stop")
            {
                string[] comands = comand.Split("|");
                string action = comands[0];
                
               

                if (action == "Add")
                {
                    string piece = comands[1];
                    string composer = comands[2];
                    string key = comands[3];
                    if (!pianist.ContainsKey(piece))
                    {
                        pianist.Add(piece, new List<string>() { composer, key });
                        Console.WriteLine($"{piece} by {composer} in {key} added to the collection!");
                    }
                    else
                    {
                        Console.WriteLine($"{piece} is already in the collection!");
                    }
                }
                else if (action == "Remove")
                {
                    string piece = comands[1];
                    if (!pianist.ContainsKey(piece))
                    {
                        Console.WriteLine($"Invalid operation! {piece} does not exist in the collection.");
                    }
                    else
                    {
                        Console.WriteLine($"Successfully removed {piece}!");
                        pianist.Remove(piece);
                    }
                }
                else if (action == "ChangeKey")
                {
                    string piece = comands[1];
                    string newKey = comands[2];
                    if (!pianist.ContainsKey(piece))
                    {
                        Console.WriteLine($"Invalid operation! {piece} does not exist in the collection.");
                    }
                    else
                    {
                        pianist[piece][1] = newKey;
                        Console.WriteLine($"Changed the key of {piece} to {newKey}!");
                    }
                }

                comand = Console.ReadLine();

            }

            foreach (var item in pianist.OrderBy(x=>x.Key).OrderBy(y=>y.Value[0]))
                // in judge is without sorting
            {
                Console.WriteLine($"{item.Key} -> Composer: {item.Value[0]}, Key: {item.Value[1]}");
            }
          
        }
    }
}
