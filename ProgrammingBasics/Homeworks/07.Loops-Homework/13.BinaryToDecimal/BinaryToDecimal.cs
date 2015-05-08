using System;

class BinaryToDecimal
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();
        Console.WriteLine(toDecimal(input));
    }

    private static long toDecimal(string x)
    {
        long start = 1;
        long number = 0;
        for (int i = x.Length-1; i >= 0; i--)
        {
            if (x[i] == '0')
            {
                //do nothing
            }
            else
            {
                number += start;
            }
            start *= 2;
        }
        return number;
    }
}
