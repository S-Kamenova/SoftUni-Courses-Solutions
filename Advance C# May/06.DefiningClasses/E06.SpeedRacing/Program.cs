using System;
using System.Collections.Generic;
using System.Linq;

namespace E06.SpeedRacing
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>();

            for (int i = 0; i < n; i++)
            {
                string data = Console.ReadLine();

                string model = data.Split()[0];
                double fuelAmount = double.Parse(data.Split()[1]);
                double fuelConsumptionFor1km = double.Parse(data.Split()[2]);

                Car car = new Car(model, fuelAmount, fuelConsumptionFor1km);
                cars.Add(car);
            }

            string command = Console.ReadLine();
            while (command!="End")
            {
                string model = command.Split()[1];
                double amountOfKm = double.Parse(command.Split()[2]);

                Car carToDrive = cars.First(car => car.Model == model);
                carToDrive.Drive(amountOfKm);

                command = Console.ReadLine();
            }
            foreach (Car car in cars)
            {
                Console.WriteLine($"{car.Model} {car.FuelAmount:f2} {car.TravelledDistance}");
            }
        }
    }
}
