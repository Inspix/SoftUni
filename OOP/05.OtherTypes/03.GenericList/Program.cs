using System;
using System.Reflection;

namespace _03.GenericList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(typeof(GenericList<>).GetCustomAttribute(typeof(Ver)));

            GenericList<string> list = new GenericList<string>();
            GenericList<Point2D> list2 = new GenericList<Point2D>();
            list2.Add(new Point2D(5, 3));
            list2.Add(new Point2D(6, 4));


            list.Add("az");
            list.Add("ti");
            list.Add("toj");
            list.Add("tq");
            list.Insert("to",1);
            list.Remove(3);
            
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }

            Console.WriteLine(Environment.NewLine);
            Console.WriteLine(list.FindIndexOf("toj"));
            Console.WriteLine(list);
            Console.WriteLine(list.Contains("tq"));
            Console.WriteLine(list.Max());
            Console.WriteLine(list2.Max());
            Console.WriteLine(list2.Contains(new Point2D(5, 3)));
            Console.WriteLine(list2.Contains(new Point2D(5, 2)));
        }
    }

    /// <summary>
    /// Its just to check if the genericList works with custom classes/structs...
    /// </summary>
    [Ver(1,4)]
    struct Point2D : IComparable
    {
        public float X, Y;

        public Point2D(float x, float y)
        {
            this.X = x;
            this.Y = y;
        }

        public int CompareTo(object obj)
        {
            if (!(obj is Point2D))
            {
                throw new InvalidOperationException();
            }

            Point2D toCheck = (Point2D) obj;
            if (toCheck.X.Equals(this.X) && toCheck.Y.Equals(this.Y))
            {
                return 0;
            }
            if (toCheck.X + toCheck.Y > this.X + this.Y)
            {
                return -1;
            }
            return 1;

        }

        public override string ToString()
        {
            return string.Format("X:{0},Y:{1}", this.X, this.Y);
        }
    }
}
