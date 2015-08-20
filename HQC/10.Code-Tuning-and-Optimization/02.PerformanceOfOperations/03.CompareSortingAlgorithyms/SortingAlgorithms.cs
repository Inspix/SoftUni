using System;
using System.Collections.Generic;

namespace _03.CompareSortingAlgorithyms
{
    public static class SortingAlgorithms
    {
        private static TimeSpan BreakTime = TimeSpan.FromSeconds(30);

        public static void SelectionSort<T>(T[] toSort) where T : IComparable, IComparable<T>
        {
            if (toSort.Length <= 1)
            {
                return;
            }
            for (int i = 0; i < toSort.Length-1; i++)
            {
                if (Tests.GlobalWatch.ElapsedMilliseconds > BreakTime.TotalMilliseconds)
                {
                    Tests.tooLong = "Hangs up";
                    break;
                }
                int minIndex = MinIndex(ref toSort, i, toSort.Length);
                if (minIndex != i)
                {
                    Swap(ref toSort[i], ref toSort[minIndex]);
                }                
            }
        }

        public static void InsertionSort<T>(T[] toSort) where T : IComparable, IComparable<T>
        {
            if (toSort.Length <= 1)
            {
                return;
            }
            for (int i = 0; i < toSort.Length; i++)
            {
                if (Tests.GlobalWatch.ElapsedMilliseconds > BreakTime.TotalMilliseconds)
                {
                    Tests.tooLong = "Hangs up";
                    break;
                }
                int j = i;
                while (j > 0 && toSort[j].CompareTo(toSort[j-1]) < 0)
                {
                    Swap(ref toSort[j], ref toSort[j - 1]);
                    j--;
                }
            }
        }

        public static void InsertionSortVariation<T>(T[] toSort) where T : IComparable, IComparable<T>
        { 
            if (toSort.Length <= 1)
            {
                return;
            }
            for (int i = 0; i < toSort.Length; i++)
            {
                if (Tests.GlobalWatch.ElapsedMilliseconds > BreakTime.TotalMilliseconds)
                {
                    Tests.tooLong = "Hangs up";
                    break;
                }
                T temp = toSort[i];
                int j = i;
                while (j > 0 && toSort[j-1].CompareTo(temp) > 0)
                {
                    toSort[j] = toSort[j - 1];
                    j--;
                }
                toSort[j] = temp;
            }
        }

        public static void QuickSort<T>(T[] toSort) where T : IComparable, IComparable<T>
        {
            toSort.QuickSortHelper(0, toSort.Length - 1);
        }

        private static void QuickSortHelper<T>(this T[] array,int start,int end) where T : IComparable, IComparable<T>
        {
            int left = start;
            int right = end;
            int pivot = start;
            start++;

            while (end >= start)
            {
                if (Tests.GlobalWatch.ElapsedMilliseconds > BreakTime.TotalMilliseconds)
                {
                    Tests.tooLong = "Hangs up";
                    break;
                }
                if (array[start].CompareTo(array[pivot]) >= 0 && array[end].CompareTo(array[pivot]) < 0)
                {
                    Swap(ref array[start], ref array[end]);
                }
                else if (array[start].CompareTo(array[pivot]) >= 0)
                {
                    end--;
                }
                else if (array[end].CompareTo(array[pivot]) < 0)
                {
                    start++;
                }
                else
                {
                    end--;
                    start++;
                }
            }

            Swap(ref array[pivot], ref array[end]);
            pivot = end;
            if (pivot > left)
            {
                array.QuickSortHelper(left, pivot);
            }
            if (right > pivot + 1)
            {
                array.QuickSortHelper(pivot + 1, right);
            }
        }

                
        public static void MergeSort<T>(T[] toSort) where T : IComparable, IComparable<T>
        {
            if (toSort.Length <= 1)
            {
                return;
            }

            T[] temp = new T[toSort.Length];
            int length = toSort.Length;
            for (int width = 1; width < length; width = 2 * width)
            {

                for (int i = 0; i < toSort.Length; i = i + 2 * width)
                {
                    BottomUpMerge(toSort, i, Math.Min(i + width, length), Math.Min(i + 2 * width, length), temp);
                }

                Array.Copy(temp, toSort, length);
            }
        }

        private static void BottomUpMerge<T>(T[] A, int iLeft, int iRight, int iEnd, T[] B) where T : IComparable, IComparable<T>
        {
            if (A.Length <= 1)
            {
                return;
            }
            int left = iLeft;
            int right = iRight;
            int index;
            
            for (index = iLeft; index < iEnd; index++)
            {
                if (Tests.GlobalWatch.ElapsedMilliseconds > BreakTime.TotalMilliseconds)
                {
                    Tests.tooLong = "Hangs up";
                    break;
                }
                if (left < iRight && (right >= iEnd || A[left].CompareTo(A[right]) <= 0))
                {
                    B[index] = A[left];
                    left = left + 1;
                }
                else
                {
                    B[index] = A[right];
                    right = right + 1;
                }
            }
        }

        private static int MinIndex<T>(ref T[] values,int startIndex,int endIndex) where T : IComparable, IComparable<T>
        {
            int min = startIndex;
            for (int i = startIndex+1; i < endIndex; i++)
            {
                if (values[min].CompareTo(values[i]) > 0)
                {
                    min = i;
                }
            }
            return min;
        }

        private static void Swap<T>(ref T elementOne, ref T elementTwo) where T : IComparable<T>
        {
            T temp = elementOne;
            elementOne = elementTwo;
            elementTwo = temp;
        }
    }
}
