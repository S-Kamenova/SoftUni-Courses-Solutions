using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace E06.SongsQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<string> songsQueue = new Queue<string>(Console.ReadLine().Split(", "));

            
            while (songsQueue.Count>0)
            {
                string comand = Console.ReadLine();
                

                if (comand=="Play")
                {
                    songsQueue.Dequeue();
                }
                else if (comand.Contains("Add"))
                {
                    string song = comand.Substring(4);
                    // or: string song=comand.Split("Add ");

                    if (songsQueue.Contains(song))
                    {
                        Console.WriteLine($"{song} is already contained!");
                    }
                    else
                    {
                        songsQueue.Enqueue(song);
                    }
                }
                else if (comand=="Show")
                {
                    Console.WriteLine(string.Join(", ", songsQueue));
                }
            }
            Console.WriteLine("No more songs!");          
        }
    }
}
