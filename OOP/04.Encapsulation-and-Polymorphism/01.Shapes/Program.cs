using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Program
    {
        static void Main(string[] args)
        {
            IShape[] shapes = new IShape[3];

            shapes[0] = new Circle(5.5);
            shapes[1] = new Triangle(20,20,10);
            shapes[2] = new Rectangle(10,10);

            foreach (var shape in shapes)
            {
                Console.WriteLine("AREA: " +shape.CalculateArea() + " : " + shape);
                Console.WriteLine("PERIMETER: " + shape.CalculatePerimeter() + " : " + shape);
                Console.WriteLine(Environment.NewLine);
            }
        }
    }
}
