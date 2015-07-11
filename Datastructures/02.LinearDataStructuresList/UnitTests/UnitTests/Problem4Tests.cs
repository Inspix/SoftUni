using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using Problem4.RemoveOddOccurences;

namespace UnitTests
{
    [TestFixture]
    public class Problem4Tests
    {
        private IEnumerable TestData
        {
            get
            {
                yield return new TestCaseData(new List<int> { 1 ,2, 3, 4, 1 }).Returns(new List<int> {1,1});
                yield return new TestCaseData(new List<int> {1, 2, 3, 4, 5, 3, 6, 7, 6, 7, 6}).Returns(new List<int>{3,3,7,7,});
                yield return new TestCaseData(new List<int> {1, 2, 1, 2, 1, 2}).Returns(new List<int>());
                yield return new TestCaseData(new List<int> {3, 7, 3, 3, 4, 3, 4, 3, 7}).Returns(new List<int> {7, 4, 4, 7});
                yield return new TestCaseData(new List<int> {1, 2, 3, 4, 1}).Returns(new List<int> {1, 1});
                yield return new TestCaseData(new List<int> {1, 1}).Returns(new List<int>() {1, 1});
            }
        }

        [Test,TestCaseSource(nameof(TestData))]
        public static List<int> RemoveOddOccurances(List<int> data)
        {
            data.RemoveOddOccurences();
            return data;
        }
    }
}
