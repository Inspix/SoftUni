using System;

namespace _03.CompareSortingAlgorithyms
{
    public static class RandomData
    {
        private static Random rng = new Random();

        public static int[] RandomIntArray(int length)
        {
            int[] result = new int[length];
            for (int i = 0; i < length; i++)
            {
                result[i] = rng.Next(0, int.MaxValue);
            }
            return result;
        }

        public static int[] RandomDuplicateIntArray(int length, int uniqueNumberCount)
        {
            int[] numbers = new int[uniqueNumberCount];
            for (int i = 0; i < uniqueNumberCount; i++)
            {
                numbers[i] = rng.Next(0, int.MaxValue);
            }

            int[] result = new int[length];
            for (int i = 0; i < length; i++)
            {
                result[i] = numbers[rng.Next(0, numbers.Length)];
            }

            return result;
        }

        public static int[] ReversedOrderIntArray(int length)
        {
            int[] result = new int[length];
            for (int i = 0; i < length; i++)
            {
                result[length - 1 - i] = i;
            }
            return result;
        }
    }
}
