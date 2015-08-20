using System;
using System.Collections.Generic;
using System.Text;

namespace _02.PerformanceOfOperations
{
    public class PerformanceTable
    {
        private string TestName { get; set; }
        private Dictionary<TestType, List<PerformanceTime>> tests;
        private int average = 1;

        public PerformanceTable(string testname,int average = 1)
        {
            this.average = average;
            this.TestName = testname;
            this.tests = new Dictionary<TestType, List<PerformanceTime>>();
        }

        public Dictionary<TestType,List<PerformanceTime>> Tests
        {
            get { return tests; }
        }

        public void AddTest(PerformanceTime entry)
        {
            if (!tests.ContainsKey(entry.Test))
            {
                tests[entry.Test] = new List<PerformanceTime>();
            }
            tests[entry.Test].Add(entry);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            string header = string.Format("{0,-12}|{1,-20}|{2,-20}|{3,-20}|{4,-20}", TestName, "Int", "Long", "Double", "Decimal");
            string delimeter = new string('-', header.Length);
            sb.AppendLine(header).AppendLine(delimeter);
            foreach (var test in tests)
            {
                sb.AppendFormat("{0,-12}|{1,-20}|{2,-20}|{3,-20}|{4,-20}", test.Key.GetEnumDescription(), test.Value[0].TimeElapsed.TotalMilliseconds / average,
                    test.Value[1].TimeElapsed.TotalMilliseconds / average, test.Value[2].TimeElapsed.TotalMilliseconds / average,
                    test.Value[3].TimeElapsed.TotalMilliseconds / average).AppendLine();
            }
            sb.AppendLine(delimeter);
            return sb.ToString();
        }

        public static PerformanceTable Average(params PerformanceTable[] args)
        {
            PerformanceTable result = new PerformanceTable("Average",args.Length);
            foreach (PerformanceTable table in args)
            {
                foreach (var item in table.Tests)
                {
                    if (result.Tests.ContainsKey(item.Key))
                    {
                        for (int i = 0; i < item.Value.Count; i++)
                        {
                            result.Tests[item.Key][i].TimeElapsed += item.Value[i].TimeElapsed;
                        }
                    }
                    else
                    {
                        result.Tests.Add(item.Key, item.Value);
                    }
                }
            }                        
            return result;
        }
    }
}
