using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FE1.ActivationKeys
{
    class Program
    {
        static void Main(string[] args)
        {
            string rowActivationKey = Console.ReadLine();

            string comand = Console.ReadLine();
            while (comand!="Generate")
            {
                string[] token = comand.Split(">>>", StringSplitOptions.RemoveEmptyEntries);
                string action = token[0];

                if (action=="Contains")
                {
                    string searchWord = token[1];

                    if (rowActivationKey.Contains(searchWord))
                    {
                        Console.WriteLine($"{rowActivationKey} contains {searchWord}");
                    }
                    else
                    {
                        Console.WriteLine("Substring not found!");
                    }
                }
                else if (action=="Flip")
                {
                    string type = token[1];
                    int startIndex = int.Parse(token[2]);
                    int endIndex = int.Parse(token[3]);

                    string textToFlip = rowActivationKey.Substring(startIndex, endIndex-startIndex);
                    if (type=="Lower")
                    {
                        textToFlip = textToFlip.ToLower();
                    }
                    else
                    {
                        textToFlip = textToFlip.ToUpper();
                    }
                    rowActivationKey = rowActivationKey.Remove(startIndex, endIndex - startIndex);
                    rowActivationKey = rowActivationKey.Insert(startIndex, textToFlip);
                    Console.WriteLine($"{rowActivationKey}");
                }
                else if (action=="Slice")
                {
                    int startIndex = int.Parse(token[1]);
                    int endIndex = int.Parse(token[2]);
                    rowActivationKey = rowActivationKey.Remove(startIndex, endIndex - startIndex);
                    Console.WriteLine($"{rowActivationKey}");
                }
                comand = Console.ReadLine();
            }
            Console.WriteLine($"Your activation key is: {rowActivationKey}");
        }
    }
}
