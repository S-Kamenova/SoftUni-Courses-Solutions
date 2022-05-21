using System;
using System.Collections.Generic;
using System.Linq;

namespace L07.VehicleCatalogue
{
    class Truck
    {
        public Truck(string brand, string model,int weight)
        {
            this.Brand = brand;
            this.Model = model;
            this.Weight = weight;
        }
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Weight { get; set; }
    }
    class Car
    {
        public Car(string brand, string model, int horsePower)
        {
            this.Brand = brand;
            this.Model = model;
            this.HorsePower = horsePower;
        }
        public string Brand { get; set; }
        public string Model { get; set; }
        public int HorsePower { get; set; }
    }
    class Catalog
    {
       public Catalog()
        {
            this.Trucks = new List<Truck>();
            this.Cars = new List<Car>();
        }
        public List<Truck> Trucks { get; set; }
        public List<Car> Cars { get; set; }
    }


    class Program
    {
        static void Main(string[] args)
        {

            Catalog catalog = new Catalog();

            string comand = Console.ReadLine();
            

            while (comand != "end")
            {
                string[] token = comand.Split('/', StringSplitOptions.RemoveEmptyEntries);

                string type = token[0];
                string brand = token[1];
                string model = token[2];
                int finalParam = int.Parse(token[3]);

                if (type=="Car")
                {
                    Car newCar = new Car(brand, model, finalParam);
                    catalog.Cars.Add(newCar);
                }
                if (type=="Truck")
                {
                    Truck newTruck = new Truck(brand, model, finalParam);
                    catalog.Trucks.Add(newTruck);
                }

                comand = Console.ReadLine();
            }
            if (catalog.Cars.Count>0)
            {
                Console.WriteLine("Cars:");
                List<Car> orderedCars = catalog.Cars.OrderBy(car => car.Brand).ToList();
                foreach (Car car in orderedCars)
                {
                    Console.WriteLine($"{car.Brand}: {car.Model} - {car.HorsePower}hp");
                }
            }
            if (catalog.Trucks.Count>0)
            {
                Console.WriteLine("Trucks:");
                List<Truck> orderedTrucks = catalog.Trucks.OrderBy(truck => truck.Brand).ToList();
                foreach (Truck truck in orderedTrucks)
                {
                    Console.WriteLine($"{truck.Brand}: {truck.Model} - {truck.Weight}kg");
                }
            }
        }
    }
}
