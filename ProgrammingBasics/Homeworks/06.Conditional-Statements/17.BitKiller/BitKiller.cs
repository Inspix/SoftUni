using System;

namespace BitKiller
{
    internal class BitKiller
    {
        private static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int step = int.Parse(Console.ReadLine());

            string[] bits = new string[n];
            int index = 0;
            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                bits[i] = Convert.ToString(number, 2).PadLeft(8, '0');
                for (int bitN = 0; bitN < 8; bitN++)
                {
                    if (index == 0)
                    {
                        index++;
                        continue;
                    }
                    else
                    {
                        if (step == 1 || index % step == 1)
                        {
                            bits[i] = bits[i].Remove(bitN, 1).Insert(bitN, "x");
                        }
                    }
                    
                    index++;
                } bits[i] = bits[i].Replace("x", "");
            }
            string ready = "";
            foreach (var item in bits)
            {
                ready = ready + item;
            }
            while (ready.Length != 0)
            {
                if (ready.Length <= 8)
                {
                    Console.WriteLine(Convert.ToInt32(ready.PadRight(8, '0'), 2));
                    break;
                }
                if (ready.Length >= 8)
                {
                    Console.WriteLine(Convert.ToInt32(ready.Substring(0, 8), 2));
                    ready = ready.Remove(0, 8);
                }
            }
        }
    }
}