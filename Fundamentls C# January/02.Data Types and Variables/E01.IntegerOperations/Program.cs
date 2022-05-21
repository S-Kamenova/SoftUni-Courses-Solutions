using System;

namespace E01.IntegerOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int third = int.Parse(Console.ReadLine());
            int fourth = int.Parse(Console.ReadLine());

            
            long add = first + second;
            long divide = add / third;
            long multiply = divide* fourth;

            Console.WriteLine(multiply);

        }
    }
}
