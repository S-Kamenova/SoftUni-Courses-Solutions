using System;
using System.Collections.Generic;
using System.Text;

namespace FishingNet
{
    class Fish
    {
        public Fish(string fishType, double length, double weight)
        {
            FishType = fishType;
            Length = length;
            Weight = weight;
        }

        private string fishType;
        private double length;
        private double weight;


        public string FishType { get=> this.fishType; set=>this.fishType=value; }
        public double Length { get=>this.length; set=>this.length=value; }
        public double Weight { get=>this.weight; set=>this.weight=value; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"There is a {fishType}, {length} cm. long, and {weight} gr. in weight.");
            return sb.ToString().TrimEnd();
        }
    }
}
