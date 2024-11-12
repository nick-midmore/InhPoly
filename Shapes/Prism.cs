using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Prism : Shape3D
    {
        public double Height { get; set; }

        public Prism(Triangle shape, double height)
        {
            Height = height;
            base.BaseShape = shape;
        }

        public override double CalculateVolume()
        {
            return (base.BaseShape as Triangle).CalculateArea() * Height;
        }
    }
}
