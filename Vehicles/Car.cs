using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Vehicles.Engine;

namespace Vehicles
{
    public class Car : Vehicle
    {
        public Car(string make, string model) : base(make, model, new CarEngine(3, Engine.fuelType.Diesel))
        {
           
        }

        protected override void Accelerate()
        {
            string message = $"{Make} {Model} speed: ";
            double fuelMod = EngineType.FuelType switch
            {
                fuelType.Unleaded => 1.5D,
                fuelType.Leaded => 1.2D,
                fuelType.Diesel => 1.8D,
                _ => throw new InvalidOperationException($"Unexpected value: {EngineType.FuelType}")
            };
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"{message}{((EngineType.Horsepower * fuelMod) * Math.Exp(Math.Sqrt(i)) / 2):F2}mph");
            }
        }
    }
}
