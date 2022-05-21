using System;

namespace E06._Strong_number
{
    class Program
    {
        static void Main(string[] args)

        {
                       // можем да го направим и с числа, с модулно деление и вемаме числото
            
            string num = Console.ReadLine();
            long facturialSum = 0;

            for (
                
                int i = 0; i <= num.Length-1; i++)
            {
                char currCh = num[i];
                int currDigit = (int)currCh - 48;

                long currDigitFactorial = 1;
                for (int r= currDigit; r > 1; r--)
                {
                    currDigitFactorial *= r;

                }
                facturialSum += currDigitFactorial;
            }

            if (facturialSum==int.Parse(num))
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
            
        }
    }
}
