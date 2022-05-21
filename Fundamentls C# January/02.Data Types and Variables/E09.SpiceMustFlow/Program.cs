using System;

namespace E09.SpiceMustFlow
{
    class Program
    {
        static void Main(string[] args)
        {
            const int workersConsumed = 26;
            const int deilyDecrees = 10;

            int spices = int.Parse(Console.ReadLine());

            var total = 0;
            int days = 0;


            while (spices>=100)
            {
                total += (spices - workersConsumed);
                spices -= deilyDecrees;
                days++;

                if (spices<100)
                {
                    total -= workersConsumed;
                }
            }
            Console.WriteLine(days);
            Console.WriteLine(total);
        }
    }
}
