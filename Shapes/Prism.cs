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
        //public Shape CrossSectionShape { get; set; }

        public Prism(Shape shape, double height)
        {
            Height = height;
            base.BaseShape = shape;
            //this.CrossSectionShape = shape;
        }

        public override double CalculateVolume()
        {
            return base.BaseShape.CalculateArea() * Height;
        }
    }
}
