using System;
using System.Text;

namespace E05.MultiplyBigNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            int num = int.Parse(Console.ReadLine());

            StringBuilder sb = new StringBuilder();
            int reminer = 0;
            if (input == "0" || num == 0)
            {
                Console.WriteLine(0);
                return;
            }

            for (int i = input.Length-1; i >= 0; i--)
            {
                int currDigit = int.Parse(input[i].ToString());
                int product = currDigit * num+reminer;
                int result = product % 10;
                reminer = product / 10;
                sb.Insert(0, result);
            }
            if (reminer>0)
            {
                sb.Insert(0, reminer);
            }
            Console.WriteLine(sb);
        }
    }
}
