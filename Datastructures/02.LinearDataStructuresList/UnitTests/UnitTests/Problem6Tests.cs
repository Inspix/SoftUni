using System;
using System.Collections;
using NUnit.Framework;
using Problem6;
using Problem6.ImplementtheDataStructureReversedList;

namespace UnitTests
{
    [TestFixture]
    public class Problem6Tests
    {
        private IEnumerable AddTestData
        {
            get
            {
                yield return new TestCaseData(new [] {1,2,3});
                yield return new TestCaseData(new[] {0,3,5,33,1232323213});
                yield return new TestCaseData(new [] {3,4,5,6,2,3,14,2,6,45,3,4,2,3,5,151,32312,43,24,5});
                yield return new TestCaseData(new int [0]);
            }
        }

        private IEnumerable RemoveTestData
        {
            get
            {
                yield return new TestCaseData(new[] { 1, 2, 3 },new [] {2});
                yield return new TestCaseData(new[] { 0, 3, 5, 33, 1232323213 },new [] {0,1,1});
                yield return new TestCaseData(new[] { 3, 4, 5, 6, 2, 3, 14, 2, 6, 45, 3, 4, 2, 3, 5, 151, 32312, 43, 24, 5 },new [] {2,3,5,10});
            }
        }

        private IEnumerable CapacityTestData
        {
            get
            {
                yield return new TestCaseData(new[] { 1, 2, 3,4 }).Returns(4);
                yield return new TestCaseData(new[] { 0, 3, 5, 33, 1232323213 }).Returns(8);
                yield return new TestCaseData(new[] { 3, 4, 5, 6, 2, 3, 14, 2, 6, 45, 3, 4, 2, 3, 5, 151, 32312, 43, 24, 5 }).Returns(32);
            }
        }



        [Test,TestCaseSource(nameof(AddTestData))]
        public static void ReversedListAdd(int[] data)
        {
            ReverseList<int> testList = new ReverseList<int>();
            foreach (var i in data)
            {
                testList.Add(i);
            }
            Assert.AreEqual(data.Length, testList.Count);
            int count = testList.Count;
            for (int i = 0; i < count; i++)
            {
                Assert.AreEqual(data[count-1-i], testList[i]);
            }
        }

        [Test, TestCaseSource(nameof(RemoveTestData))]
        public static void ReversedListRemove(int[] data,int[] indexToRemove)
        {

            ReverseList<int> testList = new ReverseList<int>();
            foreach (var i in data)
            {
                testList.Add(i);
            }
            foreach (var i in indexToRemove)
            {
                testList.Remove(i);
            }
            Assert.AreEqual(testList.Count, data.Length - indexToRemove.Length);
        }


        [Test,TestCaseSource(nameof(CapacityTestData))]
        public static int ReversedListCapacity(int[] data)
        {
            ReverseList<int> testList = new ReverseList<int>();
            foreach (var i in data)
            {
                testList.Add(i);
            }
            return testList.Capacity;
        }

        private static void IndexOutOfBounds()
        {
            throw new IndexOutOfRangeException("Invalid index.");
        }

        private static void ThrowNullReference()
        {
            throw new NullReferenceException();
        }
    }
}
