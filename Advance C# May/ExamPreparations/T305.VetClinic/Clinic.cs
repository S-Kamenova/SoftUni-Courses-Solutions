using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VetClinic
{
    class Clinic
    {
        public Clinic(int capacity)
        {
            Capacity = capacity;
            Data = new List<Pet>();
        }

        public List<Pet> Data { get; set; }
        public int Capacity { get; set; }
        public int Count => Data.Count;

        public void Add(Pet pet)
        {
            if (Capacity >= Data.Count + 1)
            {
                Data.Add(pet);
            }
        }

        public bool Remove(string name)
        {
            bool IsRemove = Data.Exists(x => x.Name == name);
            if (IsRemove)
            {
                Data.Remove(Data.FirstOrDefault(x => x.Name == name));
            }
            return IsRemove;
        }

        public Pet GetPet(string name, string owner)
        {
            var pet = Data.FirstOrDefault(x => x.Name == name && x.Owner == owner);

            return pet;
        }

        public Pet GetOldestPet()
        {
            return  Data.OrderByDescending(x => x.Age).FirstOrDefault();
        }


        public string GetStatistics()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("The clinic has the following patients:");
            foreach (var pet in Data)
            {
                sb.AppendLine($"Pet {pet.Name} with owner: {pet.Owner}");
            }
            return sb.ToString().TrimEnd();
        }
    }

}
