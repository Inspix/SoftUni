using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using Problem5.CountofOccurences;

namespace UnitTests
{
    [TestFixture]
    public class Problem5Tests
    {
        private static IEnumerable TestData
        {
            get
            {
                yield return new TestCaseData(new[] {3, 4, 4, 2, 3, 3, 4, 3, 2})
                    .Returns(new SortedDictionary<int, int> {{2, 2}, {3, 4}, {4, 3}});
                yield return new TestCaseData(new[] { 1000 })
                   .Returns(new SortedDictionary<int, int> { { 1000, 1 }});
                yield return new TestCaseData(new[] { 0, 0, 0 })
                   .Returns(new SortedDictionary<int, int> { { 0, 3 }});
                yield return new TestCaseData(new[] { 7, 6, 5, 5, 6 })
                   .Returns(new SortedDictionary<int, int> { { 5, 2 }, { 6, 2 }, { 7, 1 } });
            }
        }

        [Test,TestCaseSource(nameof(TestData))]
        public static SortedDictionary<int, int> CountOccurences(int[] data)
        {
            return Program.CountOccurences(data);
        } 
    }
}
