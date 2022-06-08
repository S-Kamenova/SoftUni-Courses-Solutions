using System;
using System.Collections.Generic;
using System.Linq;

namespace E07.RawData
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>();


            for (int i = 0; i < num; i++)
            {
                string data = Console.ReadLine();
                string model = data.Split()[0];
                int engineSpeed = int.Parse(data.Split()[1]);
                int enginePower = int.Parse(data.Split()[2]);
                int cargoWeight = int.Parse(data.Split()[3]);
                string cargoType = data.Split()[4];

                double tire1Pressure = double.Parse(data.Split()[5]);
                int tire1Age = int.Parse(data.Split()[6]);

                double tire2Pressure = double.Parse(data.Split()[7]);
                int tire2Age = int.Parse(data.Split()[8]);

                double tire3Pressure = double.Parse(data.Split()[9]);
                int tire3Age = int.Parse(data.Split()[10]);

                double tire4Pressure = double.Parse(data.Split()[11]);
                int tire4Age = int.Parse(data.Split()[12]);

                Engine engine = new Engine(engineSpeed, enginePower);
                Cargo cargo = new Cargo(cargoType, cargoWeight);

                Tires[] tire = new Tires[]
                {
                    new Tires(tire1Age,tire1Pressure),
                    new Tires(tire2Age,tire2Pressure),
                    new Tires(tire3Age,tire3Pressure),
                    new Tires(tire4Age,tire4Pressure),

                };
                Car car = new Car(model, engine, cargo, tire);
                cars.Add(car);
            }

            List<Car> printCar = new List<Car>();
            string command = Console.ReadLine();
            if (command== "fragile")
            {
                printCar = cars.Where(x => x.cargo.Type == "fragile" && x.tire.Any(p => p.Pressure < 1)).ToList();

            }
            else if (command== "flammable")
            {
                printCar = cars.Where(x=>x.cargo.Type=="flammable" && x.engine.Power>250).ToList();
            }
            foreach (var car in printCar)
            {
                Console.WriteLine(car.Model);
            }
        }
    }
}
