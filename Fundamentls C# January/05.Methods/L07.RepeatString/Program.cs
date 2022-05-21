using System;
using System.Text;

namespace L07.RepeatString
{
    class Program
    {
        

        static void Main(string[] args)
        {
            string template = Console.ReadLine();
            int repeatTimes = int.Parse(Console.ReadLine());

            Console.WriteLine(RepeatString(template, repeatTimes));
        }

        static string RepeatString(string template, int numberOfrepeat)
        {
            StringBuilder stringBulder = new StringBuilder();

            for (int i = 0; i < numberOfrepeat; i++)
            {
                stringBulder.Append(template);
            }
                return stringBulder.ToString();

        }
    }
}
