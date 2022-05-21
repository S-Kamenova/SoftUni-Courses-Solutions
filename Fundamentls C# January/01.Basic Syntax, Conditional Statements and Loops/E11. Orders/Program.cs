using System;

namespace E11.Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            int countOrders = int.Parse(Console.ReadLine());
            double total = 0;


            for (int i = 1; i <= countOrders; i++)
            {
                double pricePerCapsule = double.Parse(Console.ReadLine());
                int days = int.Parse(Console.ReadLine());
                int countCapsules = int.Parse(Console.ReadLine());

                double sum = days * countCapsules * pricePerCapsule;
                total += sum;
                Console.WriteLine($"The price for the coffee is: ${sum:f2}");
            }
            Console.WriteLine($"Total: ${total:f2}");
        }
    }
}
