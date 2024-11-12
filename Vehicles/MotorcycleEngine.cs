using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles
{
    internal class MotorcycleEngine : Engine
    {

        public MotorcycleEngine(int horsepower, fuelType fueltype) : base(horsepower, fueltype)
        {

        }
    }
}
