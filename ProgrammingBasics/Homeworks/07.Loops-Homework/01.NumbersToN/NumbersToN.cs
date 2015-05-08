using System;

class NumbersToN
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        for (int i = 1; i <= n; i++)
        {
             Console.Write("{0} ", i);
        }
    }
}
