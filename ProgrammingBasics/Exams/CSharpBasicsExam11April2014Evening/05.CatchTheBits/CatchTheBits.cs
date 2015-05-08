using System;

internal class CatchTheBits
{
    private static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int step = int.Parse(Console.ReadLine());
        int index = 0;
        string bits = "";
        for (int i = 0; i < n; i++)
        {
            int number = int.Parse(Console.ReadLine());
            for (int bitN = 7; bitN >= 0; bitN--)
            {
                if (index == 0)
                {
                    index++;
                    continue;
                }
                if (step == 1 || index % step == 1)
                {
                    if ((number & (1 << bitN)) != 0)
                    {
                        bits = bits + "1";
                    }
                    else
                    {
                        bits = bits + "0";
                    }
                }
                index++;
            }
        }
        while (bits.Length != 0)
        {
            if (bits.Length >= 8)
            {
                Console.WriteLine(Convert.ToInt32(bits.Substring(0, 8), 2));
                bits = bits.Remove(0, 8);
            }
            else
            {
                bits = bits.PadRight(8, '0');
                Console.WriteLine(Convert.ToInt32(bits, 2));
                bits = bits.Remove(0, 8);
            }
        }
    }
}