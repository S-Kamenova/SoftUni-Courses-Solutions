using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FishingNet
{
    class Net
    {
        public Net(string material, int capacity)
        {
            Material = material;
            Capacity = capacity;
            Fish = new List<Fish>();
        }


        public List<Fish> Fish { get; set; }
        public string Material { get; set; }
        public int Capacity { get; set; }

        public int Count => Fish.Count;

        public string AddFish(Fish fish)
        {
            if (Capacity >= Count + 1)
            {
                if (string.IsNullOrWhiteSpace(fish.FishType)
                    || fish.Length <= 0 || fish.Weight <= 0)
                {
                    return "Invalid fish.";
                }
                else
                {
                    Fish.Add(fish);
                    return $"Successfully added {fish.FishType} to the fishing net.";
                }
            }
            else
            {
                return "Fishing net is full.";
            }
        }

        public bool ReleaseFish(double weight)
        {
            var findFish = Fish.FirstOrDefault(x => x.Weight == weight);
            if (findFish != null)
            {
                Fish.Remove(findFish);
                return true;
            }
            else
            {
                return false;
            }
        }

        public Fish GetFish(string fishType)
        {
            var currFish = Fish.First(x => x.FishType == fishType);
            
                return currFish;
        }

        public Fish GetBiggestFish()
        {
            return  Fish.OrderByDescending(x => x.Length).First();
        }

        public string Report()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Into the {Material}:");
            foreach (var item in Fish.OrderByDescending(x=>x.Length))
            {
                sb.AppendLine(item.ToString().TrimEnd());
            }
            return sb.ToString().TrimEnd();
        }
    }
}
