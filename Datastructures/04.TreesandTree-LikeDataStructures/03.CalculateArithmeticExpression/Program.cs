using System;
using System.Collections.Generic;
using System.Threading;
using System.Globalization;

namespace _03.CalculateArithmeticExpression
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            Tree<string> arithmeticTree = new Tree<string>("=");
            string input = "5 + 6";
            string input1 = "1.5 - 2.5 * 2 * (-3)";
            string input2 = "2 + 3 * 1.5 - 1";
            string input3 = "1 / 2";
            string input4 = "3 ++ 4";
            string input5 = "-2 - -1"; // Google says that the result is -1 not 3, i cant figure it out how to make it 3
            string input6 = "(2 + 3) * 4.5";

            List<string> inputs = new List<string>();
            inputs.Add(input);
            inputs.Add(input1);
            inputs.Add(input2);
            inputs.Add(input3);
            inputs.Add(input4);
            inputs.Add(input5);
            inputs.Add(input6);

            foreach (var str in inputs)
            {
                Console.WriteLine("Expression: " + str);
                try
                {
                    arithmeticTree = Calculation.CreateArithmeticTree(str);
                }
                catch (Exception)
                {
                    Console.WriteLine("\n---Error\n");
                    continue;
                }
                
                arithmeticTree.Print();
                var result = Calculation.CalculateArithmeticTree(arithmeticTree);
                Console.Write("\n--- Answer:");
                Console.WriteLine(result + Environment.NewLine);
            }
        }        
    }
}
