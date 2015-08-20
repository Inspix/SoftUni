using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.CompareSortingAlgorithyms
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] iterations = new int[] { 10, 100, 1000 }; // Used to 'init' the sorting algorithms to skip first time results anomaly
            int[] bigIterations = new int[] { 10, 100, 1000, 10000, 100000,1000000,10000000 };

            Tuple<string, Action<int[]>>[] algos = new Tuple<string, Action<int[]>>[]
            {
                new Tuple<string, Action<int[]>>("Selection",SortingAlgorithms.SelectionSort),
                new Tuple<string, Action<int[]>>("Insertion",SortingAlgorithms.InsertionSort),
                new Tuple<string, Action<int[]>>("InsertionVar",SortingAlgorithms.InsertionSortVariation),
                new Tuple<string, Action<int[]>>("Merge",SortingAlgorithms.MergeSort),
                new Tuple<string, Action<int[]>>("Quick",SortingAlgorithms.QuickSort)
            };

            // Used because the Quick sort implementation is with reccursion and gives stackoverflow on big numbers.
            Tuple<string, Action<int[]>>[] algos2 = new Tuple<string, Action<int[]>>[]
            {
                new Tuple<string, Action<int[]>>("Selection",SortingAlgorithms.SelectionSort),
                new Tuple<string, Action<int[]>>("Insertion",SortingAlgorithms.InsertionSort),
                new Tuple<string, Action<int[]>>("InsertionVar",SortingAlgorithms.InsertionSortVariation),
                new Tuple<string, Action<int[]>>("Merge",SortingAlgorithms.MergeSort)
            };


            Tests.SortingIntAlgoIterations(ValueType.Random, iterations, algos);
            
            string result = Tests.SortingIntAlgoIterations(ValueType.Random, bigIterations, algos);
            string result2 = Tests.SortingIntAlgoIterations(ValueType.Duplicate, bigIterations, algos2);
            string result3 = Tests.SortingIntAlgoIterations(ValueType.Reversed, bigIterations, algos2);
            File.WriteAllText("../../resultRandom.txt", result);
            File.WriteAllText("../../resultDuplicate.txt", result);
            File.WriteAllText("../../resultReversed.txt", result);
            Console.WriteLine(result);
        }
    }
}
