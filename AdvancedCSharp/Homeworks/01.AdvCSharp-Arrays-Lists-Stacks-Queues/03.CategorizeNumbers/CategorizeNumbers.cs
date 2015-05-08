using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Globalization;

class CategorizeNumbers
{
    static void Main(string[] args)
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

        List<int> wholeNumbers = new List<int>();
        List<double> floatNumbers = new List<double>();

        double[] numbers = GetNumbers(Console.ReadLine());

        foreach (double d in numbers)
        {
            if (d - (int)d != 0)
            {
                floatNumbers.Add(d);
            }
            else
            {
                wholeNumbers.Add((int)d);
            } 
        }
        

        string floatNumbersOutput = string.Empty;
        foreach (double d in floatNumbers)
        {
            floatNumbersOutput += d + " ,";
        }
        floatNumbersOutput = floatNumbersOutput.TrimEnd(',');

        string wholeNumbersOutput = string.Empty;
        foreach (int i in wholeNumbers)
        {
            wholeNumbersOutput += i + " ,";
        }
        wholeNumbersOutput = wholeNumbersOutput.TrimEnd(',');

        Console.WriteLine("[{0}] -> min:{1}, max:{2} , sum:{3}, average:{4} ", floatNumbersOutput, Math.Round(floatNumbers.Min(), 2), Math.Round(floatNumbers.Max(), 2),Math.Round(floatNumbers.Sum(),2), Math.Round(floatNumbers.Average(), 2));
        Console.WriteLine("[{0}] -> min:{1}, max:{2} , average:{3:0.00} ", wholeNumbersOutput, wholeNumbers.Min(), wholeNumbers.Max(), wholeNumbers.Average());
        
    }

    static double[] GetNumbers(string x)
    {
        List<double> numbers = new List<double>();
        Array.ForEach(x.Split(' '), s =>
        {
            double temp;
            if (double.TryParse(s,out temp))
            {
                numbers.Add(temp);
            }
        });
        return numbers.ToArray();
    }
}
