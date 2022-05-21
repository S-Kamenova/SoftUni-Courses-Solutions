using System;

namespace E07._Vending_Machine
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine().ToLower();

            decimal totalsum = 0m;

            while (input != "start")
            {
                decimal coins = decimal.Parse(input);
                if (coins != 0.1m && coins != 0.2m && coins != 0.5m && coins != 1m && coins != 2m)
                {
                    Console.WriteLine($"Cannot accept {coins}");
                }
                else
                {
                    totalsum += coins;
                }

                input = Console.ReadLine().ToLower();
            }
            if (input=="start")
            {
                input = Console.ReadLine().ToLower();
            }
           
            while (input != "end")
            {
                decimal currentPrice = 0;
                switch (input)
                {
                    case "nuts":
                        currentPrice = 2m;
                        break;
                    case "water":
                        currentPrice = 0.7m;
                        break;
                    case "crisps":
                        currentPrice = 1.5m;
                        break;
                    case "soda":
                        currentPrice = 0.8m;
                        break;
                    case "coke":
                        currentPrice = 1m;
                        break;
                    default:
                        Console.WriteLine("Invalid product");
                        input = Console.ReadLine().ToLower();
                        continue;

                }

                if (totalsum >= currentPrice)
                {
                    totalsum -= currentPrice;
                    Console.WriteLine($"Purchased {input.ToLower()}");
                }
                else
                {
                    Console.WriteLine("Sorry, not enough money");
                }

                input = Console.ReadLine().ToLower();
            }
            Console.WriteLine($"Change: {totalsum:f2}");
        }
    }
}
