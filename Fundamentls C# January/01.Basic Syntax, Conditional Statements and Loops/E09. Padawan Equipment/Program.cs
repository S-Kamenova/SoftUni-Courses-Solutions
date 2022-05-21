using System;

namespace E09._Padawan_Equipment
{
    class Program
    {
        static void Main(string[] args)
        {
            double amountOfMoney = double.Parse(Console.ReadLine());
            int countOfStudents = int.Parse(Console.ReadLine());
            double priceOfLightsabers = double.Parse(Console.ReadLine());
            double priceOfRobes = double.Parse(Console.ReadLine());
            double priceOfBelts = double.Parse(Console.ReadLine());

            int freebelts = countOfStudents / 6;


          double neededMoney = priceOfLightsabers * Math.Ceiling(countOfStudents * 1.1) + countOfStudents * priceOfRobes + (countOfStudents - freebelts) * priceOfBelts;


            if (neededMoney<=amountOfMoney)
            {
                Console.WriteLine($"The money is enough - it would cost {neededMoney:f2}lv.");
            }
            else
            {
                Console.WriteLine($"John will need {neededMoney-amountOfMoney:f2}lv more.");
            }
        }
    }
}
