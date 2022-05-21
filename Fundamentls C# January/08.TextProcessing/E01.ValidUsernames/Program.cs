using System;
using System.Linq;
using System.Text;

namespace E01.ValidUsernames
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries);


            foreach (var item in input)
            {
                if (item.Length>3 && item.Length<=16)
                {
                    bool isValid = true;
                    foreach (char currChar in item)
                    {
                        if (!(char.IsLetterOrDigit(currChar) || currChar=='-' || currChar=='_'))
                        {
                            isValid = false;
                            break;
                        }
                    }
                    if (isValid)
                    {
                        Console.WriteLine(item);
                    }
                }
            }
        }
    }
}
