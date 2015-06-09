using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _01.Point3D;
using _02.DistanceCalculator;

namespace _03.Path3D
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Point3D> list = new List<Point3D>()
            {
                new Point3D(0,0,0),
                new Point3D(1,1,1),
                new Point3D(2,2,2),
                new Point3D(3,2,1),
                new Point3D(5,3,4)
            };

            Storage.WritePathToFile("blabal.txt",new Path3D(list));


            Path3D test = Storage.ReadPathFromFile("blabal.txt");

            foreach (var point in test.Path)
            {
                Console.WriteLine(point);
            }
        }
    }

    public class Path3D
    {
        private List<Point3D> path = new List<Point3D>();

        public Path3D(List<Point3D> points)
        {
            this.path = points;
        }

        public List<Point3D> Path
        {
            get { return this.path; }
            set { this.path = value; }
        } 

        public void AddPoint(Point3D point)
        {
            this.path.Add(point);
        }
        public void RemovePoint(Point3D point)
        {
            this.path.Remove(point);
        }
    }

    public static class Storage
    {
        public static void WritePathToFile(string file, Path3D points)
        {
            
            using (StreamWriter writer = new StreamWriter(file, false, Encoding.UTF8))
            {
                foreach (var point in points.Path)
                {
                    writer.WriteLine("{0} {1} {2}",point.x,point.y,point.z);
                }
            }
        }

        public static Path3D ReadPathFromFile(string file)
        {
            List<Point3D> reslist = new List<Point3D>();
            using (StreamReader reader = new StreamReader(file, Encoding.UTF8))
            {
                string result;
                while ((result = reader.ReadLine()) != null)
                {
                    float[] input = result.Split().Select(float.Parse).ToArray();
                    reslist.Add(new Point3D(input[0], input[1], input[2]));
                }
            }
            return new Path3D(reslist);
        }
    }
}
