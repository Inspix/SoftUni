using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    abstract class BasicShape : IShape
    {
        private double width;
        private double height;

        public abstract double CalculateArea();

        public abstract double CalculatePerimeter();

        public double Width
        {
            get { return this.width; }
            set { this.width = value; }
        }
        public double Height
        {
            get { return this.height; }
            set { this.height = value; }
        }
    }
}
