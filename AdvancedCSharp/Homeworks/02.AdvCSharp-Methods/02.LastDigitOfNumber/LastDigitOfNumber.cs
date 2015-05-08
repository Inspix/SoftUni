using System;

class LastDigitOfNumber
{
    static void Main()
    {
        int input = int.Parse(Console.ReadLine());
        Console.WriteLine(GetLastDigitAsWord(input));
    }

    static string GetLastDigitAsWord(int x)
    {
        x = x % 10;
        switch (x)
        {
            case 1: return "one";
            case 2: return "two";
            case 3: return "three";
            case 4: return "four";
            case 5: return "five";
            case 6: return "six";
            case 7: return "seven";
            case 8: return "eight";
            case 9: return "nine";
            default: return "zero";
        }
    }
}
