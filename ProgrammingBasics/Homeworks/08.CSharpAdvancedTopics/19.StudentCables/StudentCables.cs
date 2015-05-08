using System;

class StudentCables
{
    public static int initialCables;
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        initialCables = n;
        int maxlenght = 0;
        for (int i = 0; i < n; i++)
        {
            maxlenght += Metrix(int.Parse(Console.ReadLine()), Console.ReadLine());
        }

        if (initialCables == 1)
        {
            //do nothing
        }
        else
        {
            maxlenght -= (initialCables-1) * 3;
        }
        
        int cableCount = 0;

        while (maxlenght >= 504)
        {
            maxlenght -= 504;
            cableCount++;
        }

        Console.WriteLine(cableCount);
        Console.WriteLine(maxlenght);

    }

    public static int Metrix(int lenght,string measure)
    {
        switch (measure)
        {
            case "meters": return lenght * 100;
            default: if (lenght < 20)
                {
                    initialCables--;
                    return 0;
                }
                else
                {
                    return lenght;
                }
        }
    }
}
