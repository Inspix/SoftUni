using System;

internal class HexToDecimal
{
    private static void Main(string[] args)
    {
        string input = Console.ReadLine();
        Console.WriteLine(HexToDec(input));
    }

    private static long HexToDec(string x)
    {
        long number = 0;
        long multiplier = 1;
        for (int i = x.Length - 1; i >= 0; i--)
        {
            number += getNumber(x[i]) * multiplier;
            multiplier *= 16;
        }
        return number;
    }

    private static int getNumber(char x)
    {
        switch (x)
        {
            case 'A': return 10;
            case 'B': return 11;
            case 'C': return 12;
            case 'D': return 13;
            case 'E': return 14;
            case 'F': return 15;
            default: return Convert.ToInt32(x) - 48;
        }
    }
}