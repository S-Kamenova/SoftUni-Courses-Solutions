using System;

namespace L05.Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();

            int quantity = int.Parse(Console.ReadLine());

            GetThePrice(product,quantity);

        
        }

        static void GetThePrice(string product, int quantity)
        {
            double price = 0;
            if (product=="water")
            {
                price = quantity * 1;
            }
            else if (product=="coffee")
            {
                price = quantity * 1.5;
            }
            else if (product=="coke")
            {
                price = quantity * 1.4;
            }
            else if (product=="snacks")
            {
                price=quantity * 2;
            }
            Console.WriteLine($"{price:f2}");
        }
    }
}
