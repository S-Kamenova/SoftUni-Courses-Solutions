using System;
using System.Collections.Generic;
using System.Text;

namespace E06.SpeedRacing
{
    public class Car
    {
        public string Model { get; set; }
        public double FuelAmount { get; set; }
        public double FuelConsumptionPerKilometer { get; set; }
        public double TravelledDistance { get; set; }

        public Car(string model, double fuelAmount, double fuelConsumptionPerKm)
        {
            this.Model = model;
            this.FuelAmount = fuelAmount;
            this.FuelConsumptionPerKilometer = fuelConsumptionPerKm;
            this.TravelledDistance = 0;

        }

        public void Drive(double amountOfKm)
        {
            double neededFuel = amountOfKm * FuelConsumptionPerKilometer;
            if (FuelAmount>=neededFuel)
            {
                FuelAmount -= neededFuel;
                TravelledDistance += amountOfKm;
            }
            else
            {
                Console.WriteLine("Insufficient fuel for the drive");
            }
        }
    }
}
