using System;

namespace E01.SmallestOfThreeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());

            Console.WriteLine(Compare(num1,num2,num3));
        } 

        static int Compare(int num1, int num2, int num3)
        {
            if (num1<num2)
            {
                if (num1<num3)
                {
                    return num1;
                }
                else
                {
                    return num3;
                }
            }
            else
            {
                if (num2<num3)
                {
                    return num2;
                }
                else
                {
                    return num3;
                }
            }
        }
        //static int Smalest(int num1, int num2, int num3)
        //{
        //    Math.Min(num1, Math.Min(num2, num3));
        //}
    }
}
