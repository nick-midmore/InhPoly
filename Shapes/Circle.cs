﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Circle : Shape
    {
        public double Radius { get; set; }
        public override double CalculateArea()
        { 
            return Math.PI * Math.Pow(Radius, 2); 
        }

        public Circle(double radius) 
        {
            Radius = radius;
        }
    }
}
