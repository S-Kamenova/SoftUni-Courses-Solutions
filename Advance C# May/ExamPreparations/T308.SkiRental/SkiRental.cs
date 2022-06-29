using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace SkiRental
{
    class SkiRental
    {
        public SkiRental(string name, int capacity)
        {
            Name = name;
            Capacity = capacity;
            data = new List<Ski>();
        }
        public int Count => data.Count;
        public List<Ski> data { get; set; }
        public string Name { get; set; }
        public int Capacity { get; set; }

        public void Add(Ski ski)
        {
            if (Capacity >= data.Count+1)
            {
                data.Add(ski);
            }
        }

       public bool Remove(string manufacturer, string model)
        {
            return data.Remove(data.Find(x => x.Manufacturer == manufacturer && x.Model==model));
        }

        public Ski GetNewestSki()
        {
            return data.OrderByDescending(x=>x.Year).FirstOrDefault();
        }
        public Ski GetSki(string manufacturer, string model)
        {
            return data.FirstOrDefault(x => x.Manufacturer == manufacturer && x.Model == model);
        }

        public string GetStatistics() 
        {
            StringBuilder result = new StringBuilder();
            result.AppendLine($"The skis stored in {Name}:");
            foreach (var item in data)
            {
                result.AppendLine(item.ToString());
            }
            return result.ToString().TrimEnd();
        }
    }

}
