using System;

namespace L12.RefactorSpecialNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int endNum = int.Parse(Console.ReadLine());
           
           
            for (int number = 1; number <= endNum; number++)
            {
                int currentNumber = number;
                int sum = 0;

              
                while (number > 0)
                {
                    sum += number % 10;
                    number = number / 10;
                }
               bool isSpecialNum = (sum == 5) || (sum == 7) || (sum == 11);
                Console.WriteLine("{0} -> {1}", currentNumber, isSpecialNum);
                sum = 0;
                number = currentNumber;
            }

        }
    }
}
