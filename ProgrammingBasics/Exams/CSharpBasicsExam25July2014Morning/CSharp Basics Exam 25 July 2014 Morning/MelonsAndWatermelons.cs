using System;

class Program
{
    static void Main()
    {
        for (int i = 0; i < 7; i++)
        {
            for (int x = 0; x < 50000; x++)
            {
                MelonsAndWatermelons.meth(i, x);
            }
        }
    }
    
}
class MelonsAndWatermelons
{
    public static int melons = 0;
    public static int watermelons = 0;
    public static void meth(int s, int d)
    {
        //int s = int.Parse(Console.ReadLine());
        //int d = int.Parse(Console.ReadLine());

        for (int i = s; i < d +s; i++)
        {
            GetMelonsWaterMelons(i % 7);
        }

        if (melons > watermelons)
        {
            Console.WriteLine("{0} more melons",melons - watermelons);
        }
        else if (watermelons > melons)
        {
            Console.WriteLine("{0} more watermelons",watermelons - melons);
        }
        else
        {
            Console.WriteLine("Equal amount: {0}", melons);
        }

    }
    public static void GetMelonsWaterMelons(int day)
    {
        switch (day)
        {
            case 1: watermelons++;
                break;
            case 2: melons += 2;
                break;
            case 3: watermelons++; melons++;
                break;
            case 4: watermelons += 2;
                break;
            case 5: watermelons += 2; melons += 2;
                break;
            case 6: watermelons++; melons += 2;
                break;
            default:
                break;
        }
    }
}
