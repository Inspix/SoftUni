using System;

internal class Calculate2
{
    private static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int k = int.Parse(Console.ReadLine());
        int kResult = k;
        int nResult = n;
        for (int i = n - 1; i >= 1; i--)
        {
            nResult *= i;
            if (i < k)
            {
                kResult *= i;
            }
        }
        int result = nResult / kResult;
        Console.WriteLine(result);
    }
}