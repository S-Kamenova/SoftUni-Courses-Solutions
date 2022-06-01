using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace LineNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputFilePath = @"..\..\..\text.txt";
            string outputFilePath = @"..\..\..\output.txt";

            ProcessLines(inputFilePath, outputFilePath);
        }

        private static void ProcessLines(string inputFilePath, string outputFilePath)
        {
            string[] lines = File.ReadAllLines(inputFilePath);
            int count = 0;

            List<string> outputDate = new List<string>();
            foreach (string line in lines)
            {
                count++;
                int countLetters = line.Count(char.IsLetter);
                int countSymbols = line.Count(char.IsPunctuation);

                string modifiedLine = $"Line {count}: {line} ({countLetters})({countSymbols})";

                outputDate.Add(modifiedLine);

            }
            File.WriteAllLines(outputFilePath, outputDate);
        }
    }
}
