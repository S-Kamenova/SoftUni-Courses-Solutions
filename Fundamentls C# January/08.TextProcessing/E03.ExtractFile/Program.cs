using System;

namespace E03.ExtractFile
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split("\\");

            string file = input[input.Length - 1];
            string[] newArr = file.Split(".");
            string name = newArr[0];
            string extension = newArr[1];
            Console.WriteLine($"File name: {name}");
            Console.WriteLine($"File extension: {extension}");
        }
    }
}
