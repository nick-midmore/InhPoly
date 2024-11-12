using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles
{
    public abstract class Engine
    {
        public bool Running { get; set; }
        public int Horsepower { get; set; }
        public enum fuelType { Unleaded, Leaded, Diesel };
        public fuelType FuelType { get; set; }

        public Engine(int horsepower, fuelType fueltype)
        {
            Horsepower = horsepower;
            FuelType = fueltype;
        }
    }
}
