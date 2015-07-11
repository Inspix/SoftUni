using System.Collections;
using NUnit.Framework;
using Problem7.ImplementaLinkedList;

namespace UnitTests
{
    [TestFixture]
    public class Problem7Tests
    {
        private static IEnumerable AddTestData
        {
            get
            {
                yield return new TestCaseData(new long[] {12345,4323,455,33,4});
                yield return new TestCaseData(new long[] { 12345, 4323, 455, 33, 4 });
                yield return new TestCaseData(new long[] { 22, 33, 44, 55, 66,77,88,99,100,101 });
                yield return new TestCaseData(new long[] { 231 });
            }
        }

        private static IEnumerable RemoveTestData
        {
            get
            {
                yield return new TestCaseData(  new long[] { 12345, 4323, 455, 33, 4 },
                                                new int [] {1,1,1,1}, 
                                                new long[] {12345});

                yield return new TestCaseData(  new long[] { 12345, 4323, 455, 33, 4, 4323, 455, 33, 4 }, 
                                                new int [] { 5, 3, 6, 1 }, 
                                                new long[] { 12345, 455, 4, 455, 33 });

                yield return new TestCaseData(  new long[] {22, 33, 44, 55, 66, 77, 88, 99, 100, 101}, 
                                                new int [] {5, 5, 5, 5},
                                                new long[] {22, 33, 44, 55, 66, 101});

                yield return new TestCaseData(  new long[] { 231 },new int[] {0},new long[0]);
            }
        }

        [Test,TestCaseSource(nameof(AddTestData))]
        public static void LinkedListAddTestAndCount(long[] data)
        {
            LinkedList<long> testList = new LinkedList<long>();
            foreach (var l in data)
            {
               testList.Add(l);
            }
            for (int i = 0; i < data.Length; i++)
            {
                Assert.AreEqual(testList.FirstIndexOf(data[i]),i);
            }
            Assert.AreEqual(data.Length,testList.Count);
        }

        [Test, TestCaseSource(nameof(AddTestData))]
        public static void LinkedListEnumerator(long[] data)
        {
            LinkedList<long> testList = new LinkedList<long>();
            foreach (var l in data)
            {
                testList.Add(l);
            }
            var testlistenum = testList.GetEnumerator();
            var dataenum = data.GetEnumerator();
            for (int i = 0; i < data.Length; i++)
            {
                testlistenum.MoveNext();
                dataenum.MoveNext();
                Assert.AreEqual(testlistenum.Current, dataenum.Current);
            }
        }

        [Test,TestCaseSource(nameof(RemoveTestData))]
        public static void LinkedListRemove(long[] data,int[] indecies, long[] result)
        {
            LinkedList<long> testList = new LinkedList<long>();
            foreach (var l in data)
            {
                testList.Add(l);
            }
            foreach (var index in indecies)
            {
                testList.Remove(index);
            }
            var testlistEnum = testList.GetEnumerator();
            var resultEnum = result.GetEnumerator();
            for (int i = 0; i < result.Length; i++)
            {
                testlistEnum.MoveNext();
                resultEnum.MoveNext();
                Assert.AreEqual(testlistEnum.Current, resultEnum.Current);
            }
        }
    }
}
