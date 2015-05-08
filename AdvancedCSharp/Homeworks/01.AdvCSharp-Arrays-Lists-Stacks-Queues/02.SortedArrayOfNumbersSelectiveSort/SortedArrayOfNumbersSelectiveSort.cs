using System;
using System.Collections.Generic;
using System.Linq;

class SortedArrayOfNumbersSelectiveSort
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();
        int[] SortedNumbers = SelectiveSort(GetNumArray(input));

        foreach (int i in SortedNumbers)
        {
            Console.Write(i + " ");
        }

    }

    static int[] SelectiveSort(int[] numbers)
    {
        for (int i = 0; i < numbers.Length; i++)
        {
            for (int j = i + 1; j < numbers.Length; j++)
            {
                if (numbers[i] > numbers[j])
                {
                    int temp = numbers[i];
                    numbers[i] = numbers[j];
                    numbers[j] = temp;
                }
            }
        }
        return numbers;
    }

    static int[] GetNumArray(string x)
    {
        List<int> numbers = new List<int>();
        Array.ForEach(x.Split(' '), s =>
        {
            int currentNumber;
            if (Int32.TryParse(s, out currentNumber))
            {
                numbers.Add(currentNumber);
            }

        });
        return numbers.ToArray();
    }
}