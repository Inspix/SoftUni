using System;

internal class OddEvenSum
{
    private static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        int index = 1;
        int num1 = 0;
        int num2 = 0;
        for (int i = 0; i < n * 2; i++)
        {
            if (index % 2 == 1)
            {
                num1 += int.Parse(Console.ReadLine());
                index++;
            }
            else
            {
                num2 += int.Parse(Console.ReadLine());
                index++;
            }
        }

        if (num1 == num2)
        {
            Console.WriteLine("Yes, sum={0}", num1);
        }
        else
        {
            Console.WriteLine("No, diff={0}", Math.Abs(num1 - num2));
        }
    }
}