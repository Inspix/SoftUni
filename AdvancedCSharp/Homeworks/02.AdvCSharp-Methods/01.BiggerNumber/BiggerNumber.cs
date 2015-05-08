using System;

class BiggerNumber
{
    static void Main()
    {
        int firstN = int.Parse(Console.ReadLine());
        int secondN = int.Parse(Console.ReadLine());
        Console.WriteLine(GetMax(firstN,secondN));
    }

    static int GetMax(int a, int b)
    {
        if (a > b)
        {
            return a;
        }
        else
        {
            return b;
        }
    }
}
