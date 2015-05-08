using System;
using System.Collections.Generic;

internal class Triple
{
    public int Sum { get; set; }

    public string Numbers { get; set; }

    public Triple(int sum, string numbers)
    {
        Sum = sum;
        Numbers = numbers;
    }
}

internal class BiggestTripple
{
    private static void Main(string[] args)
    {
        List<Triple> triples = new List<Triple>();
        string n = Console.ReadLine();

        string[] numbers = n.Split(' ');
        int index = 0;
        int sum = 0;
        string partial = "";
        int maxSum = -1000;
        for (int i = 0; i < numbers.Length; i++)
        {
            if (index != 0 && index % 3 == 0)
            {
                triples.Add(new Triple(sum, partial));
                sum = 0;
                partial = "";
            }
            if (String.IsNullOrEmpty(partial))
            {
                partial = numbers[i];
            }
            else
            {
                partial = partial + " " + numbers[i];
            }
            sum += Convert.ToInt32(numbers[i]);
            index++;
        }
        triples.Add(new Triple(sum, partial));
        foreach (Triple item in triples)
        {
            maxSum = Math.Max(maxSum, item.Sum);
        }
        foreach (Triple item in triples)
        {
            if (maxSum == item.Sum)
            {
                Console.WriteLine(item.Numbers);
                break;
            }
        }
    }
}