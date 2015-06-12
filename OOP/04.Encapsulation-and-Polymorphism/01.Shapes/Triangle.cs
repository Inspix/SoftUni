using System;

namespace Shapes
{
    class Triangle : BasicShape
    {
        public double A;
        public double B;
        public double C;

        public Triangle(double a, double b, double c)
        {
            A = a;
            B = b;
            C = c;
        }


        public override double CalculateArea()
        {
            double p = this.CalculatePerimeter()/2d;
            return Math.Sqrt(p*(p - this.A)*(p - this.B)*(p - this.C));
        }

        public override double CalculatePerimeter()
        {
            return A + B + C;
        }
    }
}
//Math.Sqrt(this.p * (this.p - this.A) * (this.p - this.B) * (this.p - this.C));