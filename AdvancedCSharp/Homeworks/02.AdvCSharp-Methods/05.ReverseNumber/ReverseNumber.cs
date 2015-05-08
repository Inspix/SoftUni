using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Threading;

class ReverseNumber
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

        Console.WriteLine(Reverse(256));
        Console.WriteLine(Reverse(123.5));
        Console.WriteLine(Reverse(0.12));
    }


    static double Reverse(double x)
    {
        char[] n = Convert.ToString(x).ToCharArray();
        Array.Reverse(n);
        return Convert.ToDouble(new string(n));
    }
}