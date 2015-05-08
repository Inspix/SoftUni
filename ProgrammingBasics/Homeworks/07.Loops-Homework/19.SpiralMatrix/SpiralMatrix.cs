using System;

internal class SpiralMatrix
{
    private static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int[,] matrix = new int[n, n];

        int position = 1;
        int count = n;
        int value = -n;
        int sum = -1;

        do
        {
            value = -1 * value / n;
            for (int i = 0; i < count; i++)
            {
                sum += value;
                matrix[sum / n, sum % n] = position++;
            }
            value *= n;
            count--;
            for (int i = 0; i < count; i++)
            {
                sum += value;
                matrix[sum / n, sum % n] = position++;
            }
        } while (count > 0);
        for (int i = 0; i < n; i++)
        {
            for (int y = 0; y < n; y++)
            {
                Console.Write(matrix[i, y] + " ");
            }
            Console.WriteLine();
        }
    }
}