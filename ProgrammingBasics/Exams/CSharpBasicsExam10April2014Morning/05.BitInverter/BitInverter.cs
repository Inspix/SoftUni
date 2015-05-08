using System;

internal class BitInverter
{
    private static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int step = int.Parse(Console.ReadLine());
        int index = 1;
        for (int i = 0; i < n; i++)
        {
            int number = int.Parse(Console.ReadLine());
            for (int bitN = 7; bitN >= 0; bitN--)
            {
                if (step == 1 || index % step == 1)
                {
                    number = number ^ (1 << bitN);
                }
                index++;
            }
            Console.WriteLine(number);
        }
    }
}