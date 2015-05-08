using System;

class NumbersNotDivisableBy3n7
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        for (int i = 1; i <= n; i++)
        {
            if (i % 3 == 0 || i % 7 == 0)
            {
                continue;
            }
            else
            {
                Console.WriteLine("{0} ",i);
            }
        }
    }
}
