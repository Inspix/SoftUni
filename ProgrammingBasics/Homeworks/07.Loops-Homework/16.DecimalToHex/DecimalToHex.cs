using System;

internal class DecimalToHex
{
    private static void Main(string[] args)
    {
        long input = long.Parse(Console.ReadLine());
        Console.WriteLine(DecToHex(input));
    }

    private static string DecToHex(long x)
    {
        string result = "";
        long reminder;
        while (x >= 16)
        {
            reminder = (x % 16);
            x /= 16;
            if (reminder > 9)
            {
                result = GetChar(reminder) + result;
            }
            else
            {
                result = reminder + result;
            }
        }
        if (x > 9)
        {
            result = GetChar(x) + result;
        }
        else
        {
            result = x + result;
        }
        return result;
    }

    private static char GetChar(long x)
    {
        switch (x)
        {
            case 10: return 'A';
            case 11: return 'B';
            case 12: return 'C';
            case 13: return 'D';
            case 14: return 'E';
            case 15: return 'F';
            default: return '0';
        }
    }
}