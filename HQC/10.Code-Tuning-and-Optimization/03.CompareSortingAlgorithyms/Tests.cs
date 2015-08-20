using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.CompareSortingAlgorithyms
{
    public enum ValueType
    {
        Random,Duplicate,Reversed
    }

    public static class Tests
    {
        private static Stopwatch watch = new Stopwatch();
        public static string tooLong = null;
        public static Stopwatch GlobalWatch = new Stopwatch();

        public static TimeSpan Sort<T>(T[] array, Action<T[]> sortingAlgorithm) where T : IComparable, IComparable<T>
        {
            T[] temp = (T[])array.Clone();
            watch.Restart();
            GlobalWatch.Restart();
            try
            {
                sortingAlgorithm.Invoke(temp);
            }
            catch(Exception e)
            {
                tooLong = e.Message;
            }
            watch.Stop();
            GlobalWatch.Stop();
            return watch.Elapsed;
        }


        public static string SortingIntAlgoIterations(ValueType type, int[] iterations,params Tuple<string,Action<int[]>>[] algos)
        {
            string[,] results = new string[algos.Length, iterations.Length+1];
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("|{0,-15}","Algorithm");
            foreach (int i in iterations)
            {
                sb.AppendFormat("|{0,-15}", i);
            }
            sb.AppendLine();
            int resultTab = 1;
            for (int i = 0; i < iterations.Length; i++)
            {               
                int[] toSort;
                switch (type)
                {

                    case ValueType.Duplicate:
                        toSort = RandomData.RandomDuplicateIntArray(iterations[i], 5);
                        break;
                    case ValueType.Reversed:
                        toSort = RandomData.ReversedOrderIntArray(iterations[i]);
                        break;
                    default:
                        toSort = RandomData.RandomIntArray(iterations[i]);
                        break;
                }
                int algo = 0;
                foreach (var tuple in algos)
                {
                    results[algo, 0] = tuple.Item1;
                    if (tuple.Item1 == "Quick" && toSort.Length > (type !=  ValueType.Random ? 50000 : 100000))
                    {
                        results[algo, resultTab] = "StackOverflow";
                        algo++;
                        continue;
                    }
                    if (results[algo,resultTab-1] == "Hangs up")
                    {
                        results[algo, resultTab] = "Hangs up";
                        algo++;
                        continue;
                    }
                    string result = Sort(toSort, tuple.Item2).ToString();
                    results[algo, resultTab] = tooLong ?? result;
                    tooLong = null;
                    algo++;

                }
                resultTab++;
            }
            
            
            for (int i = 0; i <= results.GetUpperBound(0); i++)
            {
                sb.AppendFormat("|{0,-15}", results[i, 0]);
                for (int j = 1; j <= results.GetUpperBound(1); j++)
                {
                    sb.AppendFormat("|{0,-15}",results[i,j]);
                }
                sb.AppendLine();
            }
            
            return sb.ToString();
        }

    }
}
