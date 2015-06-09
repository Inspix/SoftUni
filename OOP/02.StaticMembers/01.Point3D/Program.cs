using System.Runtime.CompilerServices;

namespace _01.Point3D
{
    class Program
    {
        static void Main()
        {
            
        }
    }

    public class Point3D
    {
        public float x;
        public float y;
        public float z;

        private static readonly Point3D StartPoint3D = new Point3D();

        public Point3D()
        {
            this.x = 0;
            this.y = 0;
            this.z = 0;
        }

        public Point3D(float x, float y, float z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public static Point3D GetStartingPoint()
        {
            return StartPoint3D;
        }

        public override string ToString()
        {
            return string.Format("X:{0}, Y:{1}, Z:{2}", this.x, this.y, this.z);
        }
    }
}
