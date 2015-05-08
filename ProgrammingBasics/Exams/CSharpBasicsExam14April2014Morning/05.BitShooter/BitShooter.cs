using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class BitShooter
{
    static void Main(string[] args)
    {
        ulong number = ulong.Parse(Console.ReadLine());
        List<Shots> shots = new List<Shots>();
        for (int i = 0; i < 3; i++)
        {
            string[] n = Console.ReadLine().Split(' ');
            shots.Add(new Shots { Center = Convert.ToInt32(n[0]), Size = Convert.ToInt32(n[1]) });
        }

        foreach (Shots item in shots)
        {
            for (int i = item.Center - item.Size/2; i < (item.Center - item.Size /2) + item.Size; i++)
			{
                if (i < 0 || i > 63) { }
                else
                {
                    number = number & ~((ulong)1 << i);
                }
            } 
        }

        string right = Convert.ToString((long)number,2).PadLeft(64,'0');
        string left = right.Substring(0, 32);
        right = right.Remove(0, 32);

        int left0 = Convert.ToInt32(left, 2);
        int right0 = Convert.ToInt32(right, 2);

        Console.WriteLine("left: " + NumberOfSetBits(left0));
        Console.WriteLine("right: " + NumberOfSetBits(right0));

    }
    private static int NumberOfSetBits(int i)
    {
        i = i - ((i >> 1) & 0x55555555);
        i = (i & 0x33333333) + ((i >> 2) & 0x33333333);
        return (((i + (i >> 4)) & 0x0F0F0F0F) * 0x01010101) >> 24;
    }

    public static string ConvertToBinary(ulong value)
    {
        if (value == 0) return "0";
        StringBuilder b = new StringBuilder();
        while (value != 0)
        {
            b.Insert(0, ((value & 1) == 1) ? '1' : '0');
            value >>= 1;
        }
        return b.ToString();
    }
}
public class Shots
{
    public int Center { get; set; }
    public int Size { get; set; }
}

