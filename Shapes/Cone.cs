using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Cone : Shape3D
    {
        public double Height { get; set; }

        public Cone(Circle shape, double height)
        {
            Height = height;
            base.BaseShape = shape;
        }

        public override double CalculateVolume()
        {
            return (base.BaseShape as Circle).CalculateArea() * Height / 3;
        }
    }
}
