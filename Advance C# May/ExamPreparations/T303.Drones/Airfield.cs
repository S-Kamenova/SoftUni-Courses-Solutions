using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Drones
{
    public class Airfield
    {
        public Airfield(string name, int capacity, double landingStrip)
        {
            Name = name;
            Capacity = capacity;
            LandingStrip = landingStrip;
            Drones = new List<Drone>();
        }


        public List<Drone> Drones { get; set; }
        public string Name { get; set; }
        public int Capacity { get; set; }
        public double LandingStrip { get; set; }

        public int Count => Drones.Count;


        public string AddDrone(Drone drone)
        {

            if (!(drone.Range > 5 && drone.Range < 15) 
                || drone.Name == null
                || drone.Name==string.Empty 
                || drone.Brand == null
                ||drone.Brand==string.Empty)
            {
                return "Invalid drone.";
            }
            else if (!(Capacity >= Drones.Count + 1))
            {
                return "Airfield is full.";
            }
            else
            {
                Drones.Add(drone);
                return $"Successfully added {drone.Name} to the airfield";
            }

        }

        public bool RemoveDrone(string name)
        {
            if (Drones.Exists(x=>x.Name==name))
            {
                Drones.Remove(Drones.FirstOrDefault(x => x.Name == name));
                return true;
            }
            else
            {
                return false;
            }
        }

        public int RemoveDroneByBrand(string brand)
        {
            if (Drones.Exists(x => x.Brand == brand))
            {
                var allRemove = Drones.Where(x => x.Brand == brand).ToList();             
                Drones.RemoveAll(x => x.Brand == brand);
                return allRemove.Count;
            }
            else
            {
                return 0;
            }
        }

        public Drone FlyDrone(string name)
        {
            
            if (Drones.Exists(x=>x.Name==name))
            {
                Drone drone = Drones.FirstOrDefault(x => x.Name == name);

                drone.Available = false;
                
                return Drones.FirstOrDefault(x => x.Name == name);
            }
            else
            {
                return null;
            }
        }

        public List<Drone> FlyDronesByRange(int range)
        {
            var flyDrones = Drones.Where(x => x.Range >= range).ToList();
            foreach (var item in flyDrones)
            {
                item.Available = false;
            }
            return flyDrones;
        }

        public string Report()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Drones available at {Name}:");
            foreach (var drone in Drones)
            {
                if (drone.Available)
                {
                    sb.AppendLine(drone.ToString());
                }
            }

            return sb.ToString().TrimEnd();
        }
    }
}
