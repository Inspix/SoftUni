using System;

class RandomNumbersInGivenRange
{
    static void Main(string[] args)
    {
        Random rnd = new Random();
        int n = int.Parse(Console.ReadLine());
        int min = int.Parse(Console.ReadLine());
        int max = int.Parse(Console.ReadLine());

        
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine(rnd.Next(min,max+1));
        }
    }
}

