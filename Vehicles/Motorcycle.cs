using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles
{
    public class Motorcycle : Vehicle
    {
        public bool HasSidecar { get; set; }

        public Motorcycle(string make, string model, bool hasSideCar) : base(make, model, new MotorcycleEngine(100, Engine.fuelType.Leaded))
        {
            this.HasSidecar = hasSideCar;
        }

    }
}
