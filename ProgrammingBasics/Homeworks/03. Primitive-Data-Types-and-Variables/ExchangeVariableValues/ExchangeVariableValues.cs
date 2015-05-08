/* Problem: Declare two integer variables a and b and assign them 
 * with 5 and 10 and after that exchange their values by using 
 * some programming logic. Print the variable values before and after the exchange.
 */

using System;

namespace ExchangeVariableValues
{
    internal class ExchangeVariableValues
    {
        private static void Main(string[] args)
        {
            int a = 5;
            int b = 10;
            int temp = a;

            Console.WriteLine("A = {0} \nB = {1}\n", a, b);

            a = b;
            b = temp;

            Console.WriteLine("A = {0} \nB = {1}", a, b);
        }
    }
}