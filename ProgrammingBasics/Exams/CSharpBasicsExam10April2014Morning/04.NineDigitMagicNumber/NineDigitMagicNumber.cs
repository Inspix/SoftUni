using System;

internal class NineDigitMagicNumber
{
    private static void Main(string[] args)
    {
        int sum = int.Parse(Console.ReadLine());
        int diff = int.Parse(Console.ReadLine());
        int abc = 0;
        int def = 0;
        int ghi = 0;
        int index = 0;
        for (int i = 111; i < 778; i++)
        {
            abc = i;
            def = abc + diff;
            ghi = def + diff;
            if (checkValidN(abc) && checkValidN(def) && checkValidN(ghi) && checkSum(abc, def, ghi, sum))
            {
                Console.WriteLine("{0}{1}{2}", abc, def, ghi);
                index++;
            }
        }
        if (index == 0)
        {
            Console.WriteLine("No");
        }
    }

    private static bool checkSum(int abc, int def, int ghi, int sum)
    {
        int result = 0;
        string numbers = String.Format("{0}{1}{2}", abc, def, ghi);
        foreach (char item in numbers)
        {
            result += item - 48;
        }
        return result == sum;
    }

    private static bool checkValidN(int x)
    {
        if (x < 111 || x > 777)
        {
            return false;
        }
        while (x != 0)
        {
            if (x % 10 > 0 && x % 10 < 8)
            {
                x = x / 10;
            }
            else
            {
                return false;
            }
        }
        return true;
    }
}