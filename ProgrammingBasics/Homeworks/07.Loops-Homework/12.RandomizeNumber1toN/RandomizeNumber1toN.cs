using System;
using System.Linq;

class RandomizeNumber1toN
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int[] numbers = new int[n];
        Random rnd = new Random();
        int num = 0;
        for (int i = 0; i < n; i++)
        {
            while (true)
            {
                num = rnd.Next(1,n+1);
                if (!numbers.Contains(num))
                {
                    numbers[i] = num;
                    break;
                }
            }
        }
        foreach (int item in numbers)
        {
            Console.Write(item + " ");
        }
    }
}
