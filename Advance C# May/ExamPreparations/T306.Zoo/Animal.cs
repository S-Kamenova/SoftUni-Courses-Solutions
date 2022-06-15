using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo
{
    public class Animal
    {
        private string species;
        private string diet;
        private double weight;
        private double length;

        public Animal(string species, string diet, double weight, double length)
        {
            Species = species;
            Diet = diet;
            Weight = weight;
            Lenght = length;

        }

        public string Species
        {
            get { return this.species; }
            set { this.species = value; }
        }
        public string Diet
        {
            get { return this.diet; }
            set { this.diet = value; }
        }
        public double Weight
        {
            get { return this.weight; }
            set { this.weight = value; }
        }
        public double Lenght
        {
            get { return this.length; }
            set { this.length = value; }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"The {species} is a {diet} and weighs {weight} kg.");
            return sb.ToString().TrimEnd();
        }
    }
}
