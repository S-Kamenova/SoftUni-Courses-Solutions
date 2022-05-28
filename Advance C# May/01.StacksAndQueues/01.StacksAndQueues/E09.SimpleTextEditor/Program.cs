using System;
using System.Collections.Generic;
using System.Text;

namespace E09.SimpleTextEditor
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<string> stack = new Stack<string>();

            int n = int.Parse(Console.ReadLine());

            StringBuilder text = new StringBuilder();

            for (int i = 1; i <= n; i++)
            {
                string comand = Console.ReadLine();

                if (comand.StartsWith("1"))
                {
                    stack.Push(text.ToString());
                    string textForAdd = comand.Split()[1];
                    text.Append(textForAdd);
                }
                else if (comand.StartsWith("2"))
                {
                    stack.Push(text.ToString());
                    int count = int.Parse(comand.Split()[1]);
                    text.Remove(text.Length - count, count);
                }
                else if (comand.StartsWith("3"))
                {
                    int index= int.Parse(comand.Split()[1]);
                    Console.WriteLine(text[index-1]);
                }
                else if (comand.StartsWith("4"))
                {
                    text = new StringBuilder(stack.Pop());

                }
            }
        }
    }
}
