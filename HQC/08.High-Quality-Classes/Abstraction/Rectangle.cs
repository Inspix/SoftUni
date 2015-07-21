using System;

namespace Abstraction
{
    class Rectangle : Figure
    {
        private double height;
        private double width;
        
        public Rectangle(double width, double height)
        {
            this.Height = height;
            this.Width = width;
        }

        public double Width
        {
            get { return this.width; }
            set {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(Width), "The rectangle Width must be positive.");
                }
                this.width = value;
            }
        }

        public double Height
        {
            get { return this.height; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(Height), "The rectangle Height must be positive.");
                }
                this.height = value;
            }
        }


        public override double CalcPerimeter()
        {
            double perimeter = 2 * (this.Width + this.Height);
            return perimeter;
        }

        public override double CalcSurface()
        {
            double surface = this.Width * this.Height;
            return surface;
        }
    }
}
