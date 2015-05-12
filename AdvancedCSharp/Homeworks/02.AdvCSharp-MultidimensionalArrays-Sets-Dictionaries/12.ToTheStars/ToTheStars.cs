using System;
using System.Collections.Generic;
using System.Threading;
using System.Globalization;

class ToTheStars
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

        string[] commands;
        Star[] stars = new Star[3];
        for (int i = 0; i < 3; i++)
        {
            commands = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            stars[i] = new Star(commands[0], double.Parse(commands[1]), double.Parse(commands[2]));
        }
        commands = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        double nX = double.Parse(commands[0]);
        double nY = double.Parse(commands[1]);
        int steps = int.Parse(Console.ReadLine());

        for (int i = 0; i <= steps; i++)
        {
            bool match = false;
            foreach (Star star in stars)
            {
                if (star.inOrbit(nX,nY))
                {
                    Console.WriteLine(star.Name.ToLower());
                    match = true;
                }
            }
            if (!match) Console.WriteLine("space");
            nY++;
        }

    }
}
class Star
{
    double X;
    double Y;
    public string Name;

    public Star(string name, double x, double y)
    {
        Name = name;
        X = x;
        Y = y;
    }

    public bool inOrbit (double x, double y)
    {
        if (x <= this.X + 1 && x >= this.X - 1 && y <= this.Y + 1 && y >= this.Y - 1)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
