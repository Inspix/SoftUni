using System;
using _01.Point3D;

namespace _02.DistanceCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Point3D a = new Point3D();
            Point3D b = new Point3D(1,1,1);

            Console.WriteLine(DistanceCalculator.CalcDistance(a,b));
        }
    }

    static class DistanceCalculator
    {
        public static float CalcDistance(Point3D a, Point3D b)
        {
            float x = (float)Math.Pow((a.x - b.x), 2);
            float y = (float)Math.Pow((a.y - b.y), 2);
            float z = (float)Math.Pow((a.z - b.z), 2);

            float result = (float) Math.Sqrt(x + y + z);
            return result;
        }

    }
}
