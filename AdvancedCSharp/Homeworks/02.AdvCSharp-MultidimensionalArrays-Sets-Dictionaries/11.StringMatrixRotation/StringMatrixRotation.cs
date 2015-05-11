using System;
using System.Collections.Generic;
using System.Linq;

class StringMatrixRotation
{
    static List<string> input = new List<string>();
    static void Main()
    {
        string rotation = Console.ReadLine();

        int degrees = int.Parse(rotation.Remove(rotation.Length-1).Remove(0,7));
        string line;
        do
        {
            line = Console.ReadLine();
            if (line == "END")
            {
                break;
            }
            else
            {
                input.Add(line);
            }
        } while (line != "END");

        input = ExtendStrings(input);

        Print(degrees);
    }

    static List<string> ExtendStrings(List<string> str)
    {
        int max = str.Max(s => s.Length);
        for (int i = 0; i < str.Count; i++)
        {
            str[i] = str[i].PadRight(max,' ');
        }
        return str;
    }

    static void Print(int degrees)
    {
        degrees = degrees / 90;
        degrees = degrees % 4;
        switch (degrees)
        {
            case 0: Print0();
                break;
            case 1: Print90();
                break;
            case 2: Print180();
                break;
            case 3: Print270();
                break;
            default:
                break;
        }
    }

    static void Print0()
    {
        for (int x = 0; x < input.Count; x++)
        {
            for (int y = 0; y < input[0].Length; y++)
            {
                Console.Write(input[x][y]);
            }
            Console.WriteLine();
        }
    }

    static void Print90()
    {
        int count = input.Count;
        int length = input[0].Length;
        for (int y = 0; y < length; y++)
        {
            for (int x = 0; x < count; x++)
            {
                Console.Write(input[x][y]);
            }
            Console.WriteLine();
        }
    }

    static void Print180()
    {
        int count = input.Count - 1;
        int length = input[0].Length - 1;
        for (int x = count; x >= 0; x--)
        {
            for (int y = length; y >= 0; y--)
            {
                Console.Write(input[x][y]);
            }
            Console.WriteLine();
        }
    }

    static void Print270()
    {
        int count = input.Count - 1;
        int length = input[0].Length - 1;
        for (int y = length; y >= 0; y--)
        {
            for (int x = count; x >= 0; x--)
            {
                Console.Write(input[x][y]);
            }
            Console.WriteLine();
        }
    }
}
