using System;
using System.Collections.Generic;
using System.Text;

namespace E07.RawData
{
    class Car
    {
        public Car(string model,Engine engine, Cargo cargo, Tires[] tire)
        {
            this.Model = model;
            this.engine = engine;
            this.cargo = cargo;
            this.tire = tire;
        }
        public string Model { get; set; }
        public Engine engine { get; set; }
        public Cargo cargo { get; set; }
        public Tires[] tire { get; set; }
    }
}
