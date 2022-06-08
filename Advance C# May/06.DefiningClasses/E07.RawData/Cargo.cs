using System;
using System.Collections.Generic;
using System.Text;

namespace E07.RawData
{
    class Cargo
    {
        public Cargo(string type,int weight)
        {
            Type = type;
            Weight = weight;
        }
        public string Type { get; set; }
        public int Weight { get; set; }
    }
}
