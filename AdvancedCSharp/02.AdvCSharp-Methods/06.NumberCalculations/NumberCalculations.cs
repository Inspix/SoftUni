using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlTypes;

class NumberCalculations
{
    static void Main()
    {
        double[] doubles = { 0.2, 1.2, 2.4, 3.9, 4.5, 5.2, 6.1, 7.6, 8.98, 1.2 , 2.02};
        double dMax = GetMax(doubles);
        double dMin = GetMin(doubles);
        double dAvg = GetAvg(doubles);
        double dSum = GetSum(doubles);
        double dProduct = GetProduct(doubles);

        int[] integers = { 2, 1, 5, 3, 4, 8, 7, 9, 9, 55, 10 };
        int iMin = GetMin(integers);
        int iMax = GetMax(integers);
        int iAvg = GetAvg(integers);
        int iSum = GetSum(integers);
        int iProduct = GetProduct(integers);

        Console.WriteLine("Doubles\n----------");
        Console.WriteLine(dMin);
        Console.WriteLine(dMax);
        Console.WriteLine(dAvg);
        Console.WriteLine(dSum);
        Console.WriteLine(dProduct);
        Console.WriteLine("\nIntegers\n----------");
        Console.WriteLine(iMin);
        Console.WriteLine(iMax);
        Console.WriteLine(iAvg);
        Console.WriteLine(iSum);
        Console.WriteLine(iProduct);
    }

    static T GetMin<T>(IList<T> numbers) where T : IComparable<T>
    {
        T result = numbers[0];
        foreach (T item in numbers)
        {
            if (result == null)
            {
                result = item;
            }
            else
            {
                if (result.CompareTo(item) > 0)
                {
                    result = item;
                }
            }
        }
        return result;
    }

    static T GetMax<T>(IList<T> numbers) where T : IComparable<T>
    {
        T result = numbers[0];
        foreach (T item in numbers)
        {
            if (result == null)
            {
                result = item;
            }
            else
            {
                if (result.CompareTo(item) < 0)
                {
                    result = item;
                }
            }
        }
        return result;
    }

    static T GetAvg<T> (IList<T> numbers) where T : IConvertible
    {
        dynamic Sum = default(T);
        foreach (T item in numbers)
        {
            Sum = Sum + item;
        }
        dynamic result = Sum / numbers.Count;
        return (T)result;
    }

    static T GetSum<T>(IList<T> numbers)
    {
        dynamic sum = 0;
        foreach (T item in numbers)
        {
            sum += item;
        }
        return (T)sum;
    }

    static T GetProduct<T>(IList<T> numbers)
    {
        dynamic product = 1;
        foreach (T item in numbers)
        {
            product *= item;
        }
        return (T)product;
    }
}
