using System;

namespace _01.ComputerStore
{
    class Program
    {
        static void Main(string[] args)
        {
            string comand = Console.ReadLine();

            decimal sum = 0;

            while (comand != "special" && comand != "regular")
            {
                decimal price = decimal.Parse(comand);


                if (price < 0)
                {
                    Console.WriteLine("Inalid price");
                    comand = Console.ReadLine();
                    continue;
                }


                sum += price;
                comand = Console.ReadLine();

            }


            if (sum == 0)
            {
                Console.WriteLine("Invalid order");
                return;
            }

            decimal total = sum * 1.2m;

            if (comand == "special")
            {
                total = 0.9m * total;

            }

            Console.WriteLine("Congratulations you've just bought a new computer!");
            Console.WriteLine($"Price without taxes: {sum:f2}$");
            Console.WriteLine($"Taxes: {(sum * 0.2m):f2}$");
            Console.WriteLine("-----------");
            Console.WriteLine($"Total price: {total:f2}$");



        }
    }
}
