using System;
using System.Linq;

internal class BitRoller
{
    private static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int f = int.Parse(Console.ReadLine());
        int r = int.Parse(Console.ReadLine());

        char[] bits = Convert.ToString(n, 2).PadLeft(19, '0').ToArray();
        for (int i = 0; i < r; i++)
        {
            bits = Roll(bits, f);
        }

        Console.WriteLine(Convert.ToInt32(new string(bits), 2));
    }

    private static char[] Roll(char[] bitz, int fBit)
    {
        Array.Reverse(bitz);
        char[] newbits = new char[bitz.Length];
        Array.Copy(bitz, newbits, bitz.Length);
        char toSet = ' ';
        for (int i = 0; i <= 18; i++)
        {
            if (i != fBit)
            {
                toSet = bitz[i];
            }

            if (i == fBit)
            {
                continue;
            }
            else if (i == 0)
            {
                if (fBit == 18)
                {
                    newbits[17] = toSet;
                }
                else
                {
                    newbits[18] = toSet;
                }
            }
            else if (i - 1 == fBit)
            {
                if (i - 2 < 0)
                {
                    newbits[18] = toSet;
                }
                else
                {
                    newbits[i - 2] = toSet;
                }
            }
            else
            {
                newbits[i - 1] = toSet;
            }
        }
        Array.Reverse(newbits);
        return newbits;
    }
}