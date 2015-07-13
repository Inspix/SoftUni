using System;
using System.Collections;
using NUnit.Framework;
using ReverseNum;

namespace UnitTests
{
    [TestFixture]
    public class Problem1Test
    {
        private IEnumerable ReverseNumbersData
        {
            get
            {
                yield return new TestCaseData(new int[] {1,2,3,4,5},new int[] {5,4,3,2,1});
                yield return new TestCaseData(new int[] {1}, new int[] {1});
                yield return new TestCaseData(null,null);
                yield return new TestCaseData(new int[] {1, -2}, new int[] {-2, 1});
            }
        }


        [Test,TestCaseSource(nameof(ReverseNumbersData))]
        public void ReverseNumbers(int[] data,int[] result)
        {
            data.ReverseNumbers();
            Assert.AreEqual(data,result);
        }
    }
}
