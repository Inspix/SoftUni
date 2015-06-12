using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Rectangle : BasicShape
    {
        public Rectangle(double width, double height)
        {
            this.Height = height;
            this.Width = width;
        }
        public override double CalculateArea()
        {
            return (this.Width + this.Height)*2;
        }

        public override double CalculatePerimeter()
        {
            return this.Width*this.Height;
        }
    }
}
