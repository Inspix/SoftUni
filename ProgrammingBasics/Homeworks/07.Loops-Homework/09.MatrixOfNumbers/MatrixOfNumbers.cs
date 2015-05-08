using System;

internal class MatrixOfNumbers
{
    private static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int[,] matrix = new int[n, n];

        for (int x = 0; x < n; x++)
        {
            for (int y = 0; y < n; y++)
            {
                matrix[x, y] = x + 1 + y;
                Console.Write("{0,-3}", matrix[x, y]);
            }
            Console.WriteLine();
        }
    }
}