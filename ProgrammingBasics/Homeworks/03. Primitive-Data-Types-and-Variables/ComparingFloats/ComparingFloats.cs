/* Problem: Write a program that safely compares floating-point numbers (double) 
 * with precision eps = 0.000001. Note that we cannot directly compare two floating-point 
 * numbers a and b by a==b because of the nature of the floating-point arithmetic. 
 * Therefore, we assume two numbers are equal if they are more closely to each other 
 * than a fixed constant eps.*/
using System;

namespace ComparingFloats
{
    internal class ComparingFloats
    {
        private static void Main(string[] args)
        {
            double eps = 1e-6; // which is 0.000001
            double[] x = new double[6] { 5.3, 5.00000001, 5.00000005, -0.0000007/* or -7e-07*/, -4.999999, 4.999999 };
            double[] y = new double[6] { 6.01, 5.00000003, 5.00000001, 0.00000007/*or 7e-08*/, -4.999998, 4.999998 };

            for (int i = 0; i < x.Length; i++)
            {
                bool result = Math.Abs(x[i] - y[i]) < eps;
                Console.Write("{0} | {1} = ", (decimal)x[i], (decimal)y[i]); //Casting to decimal so the output is the whole number and not -7e07 etc.
                Console.WriteLine(result);
            }
        }
    }
}