using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Zoo
{
    public class Zoo
    {
        public Zoo(string name, int capacity)
        {
            Name = name;
            Capacity = capacity;
            Animals = new List<Animal>();
        }

        public List<Animal> Animals { get; set; }
        public string Name { get; set; }
        public int Capacity { get; set; }

        public string AddAnimal(Animal animal)
        {
            if (string.IsNullOrWhiteSpace(animal.Species))
            {
                return "Invalid animal species.";
            }
            else if (animal.Diet != "herbivore" && animal.Diet != "carnivore")
            {
                return "Invalid animal diet.";
            }
            else if (!(Capacity >= Animals.Count + 1))
            {
                return "The zoo is full.";
            }
            else
            {
                Animals.Add(animal);
                return $"Successfully added {animal.Species} to the zoo.";
            }
        }

        public int RemoveAnimals(string species)
        {
            var removeAnimals = Animals.FindAll(x => x.Species == species);
            Animals.RemoveAll(x => x.Species == species);
            return removeAnimals.Count();
        }

        public List<Animal> GetAnimalsByDiet(string diet)
        {
            var searchingAnimals = Animals.Where(x => x.Diet == diet).ToList();
            
            return searchingAnimals;
        }

        public Animal GetAnimalByWeight(double weight)
        {
            var animal = Animals.Where(x => x.Weight == weight).First();

            return animal;
            
        }

        public string GetAnimalCountByLength(double minimumLength, double maximumLength)
        {
            var allAnimals = Animals.Where(x => x.Lenght >= minimumLength && x.Lenght <= maximumLength).ToList();
            return $"There are {allAnimals.Count} animals with a length between {minimumLength} and {maximumLength} meters.";
        }
    }
}
