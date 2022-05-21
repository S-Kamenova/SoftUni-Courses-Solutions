using System;

namespace E05.AddAndSubtract
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());
            Console.WriteLine(AddSubtract(num1,num2,num3));
        }

        static int AddSubtract (int num1, int num2,int num3)
        {
            int result = (num1 + num2)-num3;
            return result;
        }
    }
}
