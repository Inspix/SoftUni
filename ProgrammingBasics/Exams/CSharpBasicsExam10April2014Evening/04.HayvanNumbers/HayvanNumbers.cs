using System;

internal class HayvanNumbers
{
    public static int sum;
    public static bool hasMatch = false;

    private static void Main(string[] args)
    {
        sum = int.Parse(Console.ReadLine());
        int diff = int.Parse(Console.ReadLine());
        int abc;
        int def;
        int ghi;
        for (int i = 555; i <= 999; i++)
        {
            abc = i;
            def = i + diff;
            ghi = def + diff;
            if (CheckValidN(abc) && CheckValidN(def) && CheckValidN(ghi) && CheckSum(abc, def, ghi))
            {
                Console.WriteLine("{0}{1}{2}", abc, def, ghi);
                hasMatch = true;
            }
        }
        if (!hasMatch)
        {
            Console.WriteLine("No");
        }
    }

    private static bool CheckSum(int abc, int def, int ghi)
    {
        int currentSum = 0;
        string numbers = "" + abc.ToString() + def.ToString() + ghi.ToString();
        foreach (char item in numbers)
        {
            currentSum += Convert.ToInt32(item) - 48;
        }
        if (currentSum == sum)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    private static bool CheckValidN(int num)
    {
        if (num < 555 || num > 999)
        {
            return false;
        }
        else
        {
            while (num != 0)
            {
                if (num % 10 >= 5 && num % 10 <= 9)
                {
                    num = num / 10;
                }
                else
                {
                    return false;
                }
            }
            return true;
        }
    }
}