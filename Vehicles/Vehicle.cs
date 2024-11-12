using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using Shapes;

namespace Vehicles
{
    public abstract class Vehicle
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Speed { get; set; }
        public Engine EngineType { get; set; }
        public Shape3D VehicleShape { get; set; }

        public Vehicle(string make, string model, Engine engineType, Shape3D shape)
        {
            Make = make;
            Model = model;
            EngineType = engineType;
            VehicleShape = shape;
        }

        public void StartEngine()
        {
            EngineType.Start();
        }

        public void Drive()
        {
            if (EngineType.Running)
            {
                Accelerate();
            }
            else
            {
                Console.WriteLine($"{Make} {Model} is not running.");
            }
        }
        protected abstract void Accelerate();
    }
}
