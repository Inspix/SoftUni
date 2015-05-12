using System;
using System.Text;
using System.Threading;
using System.Globalization;

class LettersChangeNumbers
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        double result = 0;
        foreach (string str in input)
        {
            result += calculateValue(str);
        }
        Console.WriteLine("{0:0.00}", result);

    }

    static double calculateValue(string x)
    {
        char firstLetter = x[0];
        char lastLetter = x[x.Length - 1];
        double number = double.Parse(x.Substring(1, x.Length - 2));

        if (char.IsUpper(firstLetter))
        {
            number /= getAlphabetPosition(firstLetter);
        }
        else
        {
            number *= getAlphabetPosition(firstLetter);
        }
        if (char.IsUpper(lastLetter))
        {
            number -= getAlphabetPosition(lastLetter);
        }
        else
        {
            number += getAlphabetPosition(lastLetter);
        }
        return number;
    }

    static double getAlphabetPosition(char x)
    {
        int value = (int)x;
        if (value >= 65 && value <= 90)
        {
            return value - 64;
        }
        else
        {
            return value - 96;
        }
    }
}