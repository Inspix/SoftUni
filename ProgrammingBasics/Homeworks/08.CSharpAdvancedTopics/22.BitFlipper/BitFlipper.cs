using System;

class BitFlipper
{
    public static void Main(string[] args)
    {
        ulong number = ulong.Parse(Console.ReadLine());

        for (int bitN = 63; bitN >= 2; bitN--)
        {
            if ((number & ((ulong)1 << bitN)) != 0 && (number & ((ulong)1 << bitN - 1)) != 0 && (number & ((ulong)1 << bitN - 2)) != 0)
            {
                number = number ^ ((ulong)1 << bitN);
                number = number ^ ((ulong)1 << bitN - 1);
                number = number ^ ((ulong)1 << bitN - 2);
                bitN -= 2;
            }
            else if ((number & ((ulong)1 << bitN)) == 0 && (number & ((ulong)1 << bitN - 1)) == 0 && (number & ((ulong)1 << bitN - 2)) == 0)
            {
                number = number ^ ((ulong)1 << bitN);
                number = number ^ ((ulong)1 << bitN - 1);
                number = number ^ ((ulong)1 << bitN - 2);
                bitN -= 2;
            }
        }
        Console.WriteLine(number);
    }
}