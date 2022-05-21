using System;

namespace E02.CommonElements
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] firstArr = Console.ReadLine().Split();
            string[] secondArr = Console.ReadLine().Split();

            foreach (string elementSecond in secondArr)
            {
                for (int i = 0; i < firstArr.Length; i++)
                {
                    string elementFirst = firstArr[i];
                    if (elementSecond==elementFirst)
                    {
                        Console.Write($"{elementFirst} ");
                        break;
                    }
                }
            }
        }
    }
}
