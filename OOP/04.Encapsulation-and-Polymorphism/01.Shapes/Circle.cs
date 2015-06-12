﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Circle : IShape
    {
        public double R;

        public Circle(double r)
        {
            this.R = r;
        }

        public double CalculateArea()
        {
            return Math.PI*R*R;
        }

        public double CalculatePerimeter()
        {
            return 2*Math.PI*R;
        }
    }
}
