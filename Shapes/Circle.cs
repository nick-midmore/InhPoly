﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    internal class Circle : Shape
    {
        public double Radius { get; set; }
        public override double CalculateArea()
        { return 3.14 * Radius * Radius; }
    }
}
