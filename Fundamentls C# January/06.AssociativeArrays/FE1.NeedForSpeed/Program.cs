using System;
using System.Collections.Generic;
using System.Linq;

namespace FE1.NeedForSpeed
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            Dictionary<string, List<int>> game = new Dictionary<string, List<int>>();

            for (int i = 0; i < num; i++)
            {
                string[] token = Console.ReadLine().Split("|");
                string car = token[0];
                int mileage = int.Parse(token[1]);
                int fuel = int.Parse(token[2]);

                game.Add(car, new List<int>() { mileage, fuel });
            }

            string comand = Console.ReadLine();

            while (comand != "Stop")
            {
                string[] comands = comand.Split(" : ", StringSplitOptions.RemoveEmptyEntries);
                string action = comands[0];
                string car = comands[1];
                if (action == "Drive")
                {
                    int distance = int.Parse(comands[2]);
                    int fuel = int.Parse(comands[3]);

                    if (game[car][1] < fuel)
                    {
                        Console.WriteLine("Not enough fuel to make that ride");
                    }
                    else
                    {
                        game[car][0] += distance;
                        game[car][1] -= fuel;

                        Console.WriteLine($"{car} driven for {distance} kilometers. {fuel} liters of fuel consumed.");
                    }
                    if (game[car][0] >= 100000)
                    {
                        game.Remove(car);
                        Console.WriteLine($"Time to sell the {car}!");
                    }
                }
                else if (action == "Refuel")
                {
                    int fuel = int.Parse(comands[2]);

                    int neededFuel = 75 - game[car][1];
                    game[car][1] += fuel;

                    if (game[car][1] > 75)
                    {
                        Console.WriteLine($"{car} refueled with {neededFuel} liters");
                        game[car][1] = 75;
                    }
                    else
                    {
                        Console.WriteLine($"{car} refueled with {fuel} liters");
                    }


                }
                else if (action == "Revert")
                {
                    int kilometers = int.Parse(comands[2]);
                    game[car][0] -= kilometers;
                    if (game[car][0] < 10000)
                    {
                        game[car][0] = 10000;
                    }
                    else
                    {
                        Console.WriteLine($"{car} mileage decreased by {kilometers} kilometers");
                    }
                }
                comand = Console.ReadLine();
            }
            foreach (var item in game)
            {
                Console.WriteLine($"{item.Key} -> Mileage: {item.Value[0]} kms, Fuel in the tank: {item.Value[1]} lt.");
            }

        }
    }
}
