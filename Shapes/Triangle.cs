﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    internal class Triangle : Shape
    {
        public double BaseLength { get; set; }
        public double Height { get; set; }

        public override double CalculateArea()
        {
            return 0.5 * BaseLength * Height;
        }
    }
}