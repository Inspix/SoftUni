using System;

class BitPaths
{
    static void Main(string[] args)
    {
        int[] numbers = { 0, 0, 0, 0, 0, 0, 0, 0 };
        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            string[] steps = Console.ReadLine().Split(',');
            int step = 0;
            for (int bit = 0; bit < numbers.Length; bit++)
            {
                if (bit == 0)
                {
                    step = Convert.ToInt32(steps[0]);
                }
                else
                {
                    step += Convert.ToInt32(steps[bit]);
                }
                numbers[bit] = numbers[bit] ^ (1 << (3 - step));
            }
        }
        int sum = 0;
        foreach (var item in numbers)
        {
            sum += item;
        }
        Console.WriteLine(Convert.ToString(sum,2));
        Console.WriteLine("{0:X}",sum);
    }
}
