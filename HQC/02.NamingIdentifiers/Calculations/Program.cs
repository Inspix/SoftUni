using System;

namespace Calculations
{
    class Program
    {
        static void Main(string[] args)
        {
            var matrixA = new double[,] { { 1, 3 }, { 5, 7 } };
            var matrixB = new double[,] { { 4, 2 }, { 1, 5 } };
            var multiplyResult = ColumnMajorMultiply(matrixA, matrixB);

            for (int x = 0; x < multiplyResult.GetLength(0); x++)
            {
                for (int y = 0; y < multiplyResult.GetLength(1); y++)
                {
                    Console.Write(multiplyResult[x, y] + " ");
                }
                Console.WriteLine();
            }

        }

        static double[,] ColumnMajorMultiply(double[,] matA, double[,] matB)
        {
            if (matA.GetLength(1) != matB.GetLength(0))
            {
                throw new Exception("Uneaqual lenghts of the arrays!");
            }

            var numberOfElements = matA.GetLength(1);
            var result = new double[matA.GetLength(0), matB.GetLength(1)];
            for (int i = 0; i < result.GetLength(0); i++)
                for (int j = 0; j < result.GetLength(1); j++)
                    for (int k = 0; k < numberOfElements; k++)
                        result[i, j] += matA[i, k] * matB[k, j];
            return result;
        }
    }
}
