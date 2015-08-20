using System;
using System.IO;

namespace _02.PerformanceOfOperations
{
    class Program
    {
        static void Main(string[] args)
        {            
            PerformanceTable table = TestMethods.TestAll(500);
            PerformanceTable table2 = TestMethods.TestAll(500);
            PerformanceTable table3 = TestMethods.TestAll(500);
            PerformanceTable table4 = TestMethods.TestAll(500);
            PerformanceTable table5 = TestMethods.TestAll(500);

            var avgTable = PerformanceTable.Average(table,table2, table3, table4, table5);
            Console.WriteLine(table);
            Console.WriteLine(table2);
            Console.WriteLine(table3);
            Console.WriteLine(table4);
            Console.WriteLine(table5);
            Console.WriteLine(avgTable);

            using(StreamWriter sr = new StreamWriter("../../Result.txt"))
            {
                sr.WriteLine(table);
                sr.WriteLine(table2);
                sr.WriteLine(table3);
                sr.WriteLine(table4);
                sr.WriteLine(table5);

                sr.WriteLine(avgTable);
            }
        }
    }
}
