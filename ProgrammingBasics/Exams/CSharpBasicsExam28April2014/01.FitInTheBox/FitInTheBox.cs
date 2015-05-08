using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class FitInTheBox
{
    static void Main(string[] args)
    {
        Box one = new Box(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()));
        Box two = new Box(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()));
        Box temp;

        for (int i = 0; i <=5; i++)
        {
            temp = rotate(two, i);
            if (one.Height < temp.Height && one.Width < temp.Width && one.Depth < temp.Depth)
            {
                CheckFit(one, two);
                break;
            }
            else if (one.Height > temp.Height && one.Width > temp.Width && one.Depth > temp.Depth)
            {
                CheckFit(two, one);
                break;
            }
        }
    }

    public static void CheckFit(Box small, Box big)
    {
        for (int i = 0; i <= 5; i++)
        {
            Box toCheck = rotate(big, i);
            if (small.Height < toCheck.Height && small.Width < toCheck.Width && small.Depth < toCheck.Depth)
            {
                Console.WriteLine("({0}, {1}, {2}) < ({3}, {4}, {5})", small.Height, small.Width, small.Depth, toCheck.Height, toCheck.Width, toCheck.Depth);
            }
        }
    }



    public static Box rotate(Box b, int index)
    {
        switch (index)
        {
            case 1: return new Box(b.Height, b.Depth, b.Width);
            case 2: return new Box(b.Depth, b.Height, b.Width);
            case 3: return new Box(b.Depth, b.Width, b.Height);
            case 4: return new Box(b.Width, b.Height, b.Depth);
            case 5: return new Box(b.Width, b.Depth, b.Height);
            default: return new Box(b.Height, b.Width, b.Depth);
        }
    }
}
public class Box
{
    public int Height { get; set; }
    public int Width { get; set; }
    public int Depth { get; set; }

    public Box(int h, int w, int d)
    {
        Height = h;
        Width = w;
        Depth = d;
    }
}
