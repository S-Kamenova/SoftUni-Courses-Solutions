using System;
using System.Linq;

namespace _05.TheLift
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberPeopleWaiting = int.Parse(Console.ReadLine());
            int[] lift = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            const int maxCapacity = 4;

            for (int i = 0; i < lift.Length; i++)
            {
                while (lift[i]<maxCapacity && numberPeopleWaiting>0)
                {
                    lift[i]++;
                    numberPeopleWaiting--;
                }
            }
            if (lift.Any(n=>n !=4))
            {
                Console.WriteLine("The lift has empty spots");
            }
            else if (numberPeopleWaiting!=0)
            {
                Console.WriteLine($"There isn't enough space! {numberPeopleWaiting} people in a queue!");
            }
            Console.WriteLine(string.Join(" ",lift));
        }
    }
}
