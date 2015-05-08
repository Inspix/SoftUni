using System;

internal class SumOfElements
{
    private static void Main(string[] args)
    {
        string input = Console.ReadLine();
        Tuple<bool, long> result = calc(input);
        if (result.Item1)
        {
            Console.WriteLine("Yes, sum={0}", result.Item2);
        }
        else
        {
            Console.WriteLine("No, diff={0}", result.Item2);
        }
    }

    private static Tuple<bool, long> calc(string nums)
    {
        string[] numberstr = nums.Split(' ');
        long[] numbers = new long[numberstr.Length];
        for (int i = 0; i < numberstr.Length; i++)
        {
            numbers[i] = Convert.ToInt32(numberstr[i]);
        }
        long mindiff = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            long sum = 0;
            for (long y = 0; y < numbers.Length; y++)
            {
                sum += numbers[y];
            }
            sum -= numbers[i];
            if (sum == numbers[i])
            {
                return new Tuple<bool, long>(true, sum);
            }
            else
            {
                if (mindiff == 0)
                {
                    mindiff = Math.Abs(numbers[i] - sum);
                }
                else
                {
                    mindiff = Math.Min(mindiff, Math.Abs(numbers[i] - sum));
                }
            }
        }
        return new Tuple<bool, long>(false, mindiff);
    }
}