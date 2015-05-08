using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Globalization;

class PerimeterAreaPolygon
{
    static void Main(string[] args)
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        //Get number of points
        int n = int.Parse(Console.ReadLine());
        //Create list of coordinates
        List<Coordinates> points = new List<Coordinates>();

        for (int i = 0; i < n; i++)
        {
            string[] crds = Console.ReadLine().Split(' ');
            //Add each coordinate to list
            points.Add(new Coordinates { X = Convert.ToDouble(crds[0]), Y = Convert.ToDouble(crds[1]) });
        }
        Console.WriteLine(CalcPerimeter(points));
        Console.WriteLine(CalcArea(points));
    }

    //Calculate distance between 2 coordinates
    private static double CalcLenght(Coordinates a, Coordinates b)
    {
        return Math.Sqrt(Math.Pow(b.X - a.X, 2) + Math.Pow(b.Y - a.Y, 2));
    }

    //Calculate perimeter
    private static double CalcPerimeter(List<Coordinates> coords)
    {
        double perimeter = 0;
        for (int i = 0; i < coords.Count; i++)
        {
            if (i + 1 >= coords.Count)
            {
                perimeter += CalcLenght(coords[i], coords[0]);
            }
            else
            {
                perimeter += CalcLenght(coords[i], coords[i + 1]);
            }
           
        }
        return Math.Round(perimeter,2);
    }

    //Calculate Area
    private static double CalcArea(List<Coordinates> coords)
    {
        double area = 0;
        for (int i = 0; i < coords.Count; i++)
        {
            if (i + 1 >= coords.Count)
            {
                area += (coords[i].X * coords[0].Y) - (coords[i].Y * coords[0].X);
            }
            else
            {
                area += (coords[i].X * coords[i + 1].Y) - (coords[i].Y * coords[i + 1].X);
            }
            
        }
        return Math.Round(Math.Abs(area/2),2);
    }
}
//Coordinate class
public class Coordinates
{
    public double X { get; set; }
    public double Y { get; set; } 
}
