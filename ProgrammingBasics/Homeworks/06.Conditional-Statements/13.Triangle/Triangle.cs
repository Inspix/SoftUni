using System;
using System.Threading;
using System.Globalization;

namespace Triangle
{
    internal class Triangle
    {
        private static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            Coordinates a = new Coordinates();
            Coordinates b = new Coordinates();
            Coordinates c = new Coordinates();
            a.x = int.Parse(Console.ReadLine());
            a.y = int.Parse(Console.ReadLine());
            b.x = int.Parse(Console.ReadLine());
            b.y = int.Parse(Console.ReadLine());
            c.x = int.Parse(Console.ReadLine());
            c.y = int.Parse(Console.ReadLine());

            if (CanForm(a, b, c))
            {
                double lenghtA = GetLenght(a, b);
                double lenghtB = GetLenght(b, c);
                double lenghtC = GetLenght(a, c);

                Console.WriteLine("Yes");
                Console.WriteLine(string.Format("{0:0.00}",Math.Round(area(lenghtA, lenghtB, lenghtC), 2)));
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine(string.Format("{0:0.00}", Math.Round(GetLenght(a, b), 2)));
            }
        }

        private static double GetLenght(Coordinates point1, Coordinates point2)
        {
            double d = Math.Sqrt(Math.Pow(point2.x - point1.x, 2) + Math.Pow(point2.y - point1.y, 2));
            return d;
        }

        private static bool CanForm(Coordinates point1, Coordinates point2, Coordinates point3)
        {
            double sideA = GetLenght(point1, point2);
            double sideB = GetLenght(point2, point3);
            double sideC = GetLenght(point1, point3);

            if (sideA + sideB > sideC && sideB + sideC > sideA && sideA + sideC > sideB)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static double area(double a, double b, double c)
        {
            double perimeter = (a + b + c) / 2;
            double area = Math.Sqrt(perimeter * (perimeter - a) * (perimeter - b) * (perimeter - c));
            return area;
        }
    }

    internal struct Coordinates
    {
        public int x;
        public int y;
    }
}