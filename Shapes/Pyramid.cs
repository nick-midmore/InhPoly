using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Pyramid : Shape3D
    {
        public double Height { get; set; }

        public Pyramid(Triangle shape, double height)
        {
            Height = height;
            base.BaseShape = shape;
        }
    }
}
