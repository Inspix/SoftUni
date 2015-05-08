using System;

internal class HalfSum
{
    private static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int left = 0;
        int right = 0;
        for (int y = 0; y < n; y++)
        {
            left += int.Parse(Console.ReadLine());
        }
        for (int y = 0; y < n; y++)
        {
            right += int.Parse(Console.ReadLine());
        }

        if (left == right)
        {
            Console.WriteLine("Yes, sum={0}", left);
        }
        else
        {
            Console.WriteLine("No, diff={0}", Math.Abs(left - right));
        }
    }
}