using System;

internal class DecimalToBinary
{
    private static void Main(string[] args)
    {
        int input = int.Parse(Console.ReadLine());
        Console.WriteLine(toBinary(input));
    }

    private static string toBinary(int x)
    {
        string result = "";
        while (x != 0)
        {
            if (x % 2 == 0)
            {
                result = 0 + result;
            }
            else
            {
                result = 1 + result;
            }
            x /= 2;
        }
        return result;
    }
}