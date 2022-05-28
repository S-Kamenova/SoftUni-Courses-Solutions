using System;

namespace _01.BiscuitsFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            int biscuitPerDayPerWorker = int.Parse(Console.ReadLine());
            int countWorkers = int.Parse(Console.ReadLine());
            int biscuitForCompeting = int.Parse(Console.ReadLine());

            int biscuits = biscuitPerDayPerWorker * countWorkers;
            double biscuitsForMonth = biscuits * 20.0 + (Math.Floor(biscuits * 0.75) * 10);

            Console.WriteLine($"You have produced {biscuitsForMonth} biscuits for the past month.");

            double percentage = Math.Abs(biscuitsForMonth - biscuitForCompeting) / biscuitForCompeting * 100.0;
            if(biscuitsForMonth> biscuitForCompeting)
            {
                Console.WriteLine($"You produce {percentage:f2} percent more biscuits.");
            }
            else if (biscuitsForMonth < biscuitForCompeting)
            {
                Console.WriteLine($"You produce {percentage:f2} percent less biscuits.");
            }
       }
    }
}
