using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class GenericArraySort
{
    static void Main()
    {
        int[] numbers = { 4, 3, 7, 6, 4, 1, 2, 7, 8, 9, 44 };
        string[] strings = { "abc", "azis", "zaz", "cba" };
        DateTime[] dates = { new DateTime(2002, 3, 1), new DateTime(2015, 5, 6), new DateTime(2014, 1, 1) };

        numbers = ArraySort(numbers);
        strings = ArraySort(strings);
        dates = ArraySort(dates);

        Console.WriteLine("Sorted Integers");
        foreach (var item in numbers)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine("\n\nStrings Sorted");
        foreach (var item in strings)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine("\n\nDates Sorted");
        foreach (var item in dates)
        {
            Console.WriteLine(item);
        }

    }

    static T[] ArraySort<T>(T[] array) where T: IComparable
    {
        while (true)
        {
            int iteration = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (i + 1 == array.Length)
                {
                    iteration++;
                    break;
                }
                else
                {
                    if (array[i].CompareTo(array[i+1]) > 0)
                    {
                        Swap(ref array[i], ref array[i + 1]);
                        continue;
                    }
                    else
                    {
                        iteration++;
                    }
                }
            }
            if (iteration != array.Length)
            {
                continue;
            }
            else
            {
                break;
            }
        } return array;
    }

    static void Swap<T>(ref T x, ref T y)
    {
        T temp = x;
        x = y;
        y = temp;
    }

}
