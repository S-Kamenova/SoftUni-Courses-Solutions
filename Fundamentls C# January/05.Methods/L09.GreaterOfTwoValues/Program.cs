using System;

namespace L09.GreaterOfTwoValues
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();

            if (type=="int")
            {
                int first = int.Parse(Console.ReadLine());
                int second = int.Parse(Console.ReadLine());
                int output = GetMax(first, second);
                Console.WriteLine(output);

            }
            else if (type=="char")
            {
                char first = char.Parse(Console.ReadLine());
                char second = char.Parse(Console.ReadLine());
                char output = GetMax(first, second);
                Console.WriteLine(output);
            }
            else if (type=="string")
            {
                string first = Console.ReadLine();
                string second = Console.ReadLine();
                string output = GetMax(first, second);
                Console.WriteLine(output);
            }

        }
        static int GetMax(int first, int second)
        {
            if (first>second)
            {
                return first;
            }
            else
            {
                return second;
            }
        }
        
        static char GetMax(char first, char second)
        {
            if (first > second)
            {
                return first;
            }
            else
            {
                return second;
            }
        }
        static string GetMax(string first, string second)
        {
            if (first.CompareTo(second)>=0)
            {
                return first;
            }
            else
            {
                return second;
            }
            //first.CompareTo(second)>=0 ? first : second
        }
    }
}
