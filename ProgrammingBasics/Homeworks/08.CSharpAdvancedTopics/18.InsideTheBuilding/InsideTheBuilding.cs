using System;
using System.Collections.Generic;

class InsideTheBuilding
{
    public static List<Rectangle> shapes = new List<Rectangle>();

    public static void Main(string[] args)
    {
        int h = int.Parse(Console.ReadLine());
        InitShapes(h);
        List<Coordinates> inputPoints = new List<Coordinates>();
        for (int i = 0; i < 5; i++)
        {
            Coordinates toTest = new Coordinates 
            { 
                X = int.Parse(Console.ReadLine()), 
                Y = int.Parse(Console.ReadLine()) 
            };

            Console.WriteLine(IsPointInBuilding(toTest) ? "inside" : "outside");
        }
    }

    public static bool IsPointInBuilding(Coordinates p)
    {
        foreach (Rectangle rectangle in shapes)
        {
            if (IsPointInRectangle(p.X, p.Y, rectangle))
            {
                return true;
            }
        }
        return false;
    }

    public static bool IsPointInRectangle(int x, int y,Rectangle r)
    {
        if (x >= r.A.X && x <= r.D.X && y >= r.A.Y && y <= r.C.Y)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

   

    //Create the building deviding it to 4 triangles
    public static void InitShapes(int size)
    {
        shapes.Add(new Rectangle(0, 0, 0, size, size * 3, size, size * 3, 0));
        shapes.Add(new Rectangle(size, size, size, size * 4, size * 2, size * 4, size * 2, size));
    }
}

public class Coordinates
{
    public int X { get; set; }

    public int Y { get; set; }
}

public class Rectangle
{
    public Coordinates A { get; set; }

    public Coordinates B { get; set; }

    public Coordinates C { get; set; }
    public Coordinates D { get; set; }

    public Rectangle(int ax, int ay, int bx, int by, int cx, int cy, int dx, int dy)
    {
        A = new Coordinates { X = ax, Y = ay };
        B = new Coordinates { X = bx, Y = by };
        C = new Coordinates { X = cx, Y = cy };
        D = new Coordinates { X = dx, Y = dy };
    }
}