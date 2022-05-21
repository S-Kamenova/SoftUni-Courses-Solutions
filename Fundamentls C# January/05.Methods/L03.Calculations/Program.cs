using System;

namespace L03.Calculations
{
    class Program
    {
        static void Main(string[] args)
        {
            string comand = Console.ReadLine();
            int numberOne = int.Parse(Console.ReadLine());
            int numberTwo = int.Parse(Console.ReadLine());

            if (comand=="add")
            {
                Add(numberOne, numberTwo);
            }
            else if (comand=="multiply")
            {
                Multiply(numberOne, numberTwo);
            }
            else if (comand=="subtract")
            {
                Subtract(numberOne, numberTwo);
            }
            else if (comand=="divide")
            {
                Divide(numberOne, numberTwo);
            }
        }

        static void Add(int numOne, int numTwo)
        {
            Console.WriteLine(numOne+numTwo);
        }

        static void Multiply(int numOne, int numTwo)
        {
            Console.WriteLine(numOne*numTwo);
        }
        static void Subtract(int numOne, int numTwo)
        {
            Console.WriteLine(numOne - numTwo);
        }
        static void Divide(int numOne, int numTwo)
        {
            Console.WriteLine(numOne / numTwo);
        }
    }
}
