using System;
using System.Linq;

class MaximalSum
{
    static void Main()
    {
        int[] size = GetIntArray();

        int[,] matrix = new int[size[0]+1, size[1]+1];
        for (int i = 0; i <= matrix.GetUpperBound(0); i++)
        {
            int[] numbers = GetIntArray();
            for (int n = 0; n < numbers.Length; n++)
            {
                matrix[i, n] = numbers[n];
            }
        }

        int? sum = null;
        int? maxSum = null;
        int[,] maxArray = new int[3, 3];
        int[,] result = new int[3, 3];;
        for (int x = 1; x < matrix.GetUpperBound(0); x++)
        {
            for (int y = 1; y < matrix.GetUpperBound(1); y++)
            {
                result = GetInnerArray(matrix, x, y, out sum);
                if (sum > maxSum || maxSum == null)
                {
                    maxSum = sum;
                    maxArray = result;
                }
            }
        }
        Console.WriteLine("Sum = " + maxSum);
        for (int x = 0; x <= maxArray.GetUpperBound(0); x++)
        {
            for (int y = 0; y <= maxArray.GetUpperBound(1); y++)
            {
                Console.Write(maxArray[x, y] + " ");
            }
            Console.WriteLine();
        }
    }

    static int[] GetIntArray()
    {
        int[] result = Console.ReadLine()
            .Split(new char[] { ' ', ',', ';' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse).ToArray();
        return result;
    }

    static int[,] GetInnerArray(int[,] matrix,int x,int y,out int? sum)
    {
        sum = 0;
        int[,] result = new int[3, 3];
        if ((x <= 0 || x >= matrix.GetUpperBound(0)) || (y <= 0 || y >= matrix.GetUpperBound(1)))
        {
            return result;
        }
        x--;
        y--;
        for (int rx = 0; rx <= result.GetUpperBound(0); rx++)
        {
            for (int ry = 0; ry <= result.GetUpperBound(1); ry++)
            {
                result[rx, ry] = matrix[rx + x, ry + y];
                sum += matrix[rx + x, ry + y];
            }
        }
        return result;
    }
}
