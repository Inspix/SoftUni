using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Problem3.LongestSubsequence;

namespace UnitTests
{
    [TestFixture]
    public class Problem3Tests
    {
        private IEnumerable TestData
        {
            get
            {
                yield return new TestCaseData(new List<int> { 12, 2, 7, 4, 3, 3, 8 }).Returns(new List<int> {3,3});
                yield return new TestCaseData(new List<int> { 2, 2, 2, 3, 3, 3 }).Returns(new List<int> { 2, 2, 2 });
                yield return new TestCaseData(new List<int> { 2, 2, 2, 3, 3, 3 }).Returns(new List<int> { 2, 2, 2 });
                yield return new TestCaseData(new List<int> { 1, 2, 3 }).Returns(new List<int> { 1 });
                yield return new TestCaseData(new List<int> { 0 }).Returns(new List<int> { 0 });
            }
        }

        [Test,TestCaseSource(nameof(TestData))]
        public static List<int> FindLongestSubsequence(List<int> data)
        {
            return Program.FindLongestSubsequence(data);
        }
    }
}
