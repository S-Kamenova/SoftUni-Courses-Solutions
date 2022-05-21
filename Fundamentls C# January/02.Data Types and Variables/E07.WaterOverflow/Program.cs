using System;

namespace E07.WaterOverflow
{
    class Program
    {
        static void Main(string[] args)
        {
            const int capacity = 255;
            int n = int.Parse(Console.ReadLine());

            int total = capacity;


            for (int i = 0; i < n; i++)
            {
                int water = int.Parse(Console.ReadLine());
               

                if (total-water>=0)
                {
                    total -= water;
                }
                else
                {
                    Console.WriteLine("Insufficient capacity!");
                }
            }
            int sum = capacity - total;
            Console.WriteLine(sum);
        }
    }
}
