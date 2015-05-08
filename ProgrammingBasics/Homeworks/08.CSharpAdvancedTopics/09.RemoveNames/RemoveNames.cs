using System;
using System.Collections.Generic;

internal class RemoveNames
{
    private static void Main(string[] args)
    {
        string[] input = Console.ReadLine().Split(' ');
        string[] inputToRemove = Console.ReadLine().Split(' ');

        List<string> names = new List<string>();
        foreach (string str in input)
        {
            names.Add(str);
        }
        foreach (string str in inputToRemove)
        {
            names.RemoveAll(x => x == str);
        }
        foreach (string i in names)
        {
            Console.Write(i + " ");
        }
    }
}