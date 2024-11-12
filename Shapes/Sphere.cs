using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Sphere : Shape3D
    {
        public Sphere(Circle shape) 
        {
            base.BaseShape = shape;
        }

        public override double CalculateVolume()
        {
            return ((4.00/3.00) * Math.PI * Math.Pow((base.BaseShape as Circle).Radius,3));
        }
    }
}
