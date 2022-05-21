using System;

namespace L08.TownInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            string townName = Console.ReadLine();
            ulong population = ulong.Parse(Console.ReadLine());
            double area = double.Parse(Console.ReadLine());

            Console.WriteLine($"Town {townName} has population of {population} and area {area} square km.");

        }
    }
}
