using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using Problem1.SumandAverage;

namespace UnitTests
{
    [TestFixture]
    public class Problem1Tests
    {
        private IEnumerable TestDataSum
        {
            get
            {
                yield return new TestCaseData(new List<int>() {4, 5, 6}).Returns(15); 
                yield return new TestCaseData(new List<int>() {1,1}).Returns(2);
                yield return new TestCaseData(new List<int>()).Returns(0); 
                yield return new TestCaseData(new List<int>() {10}).Returns(10); 
                yield return new TestCaseData(new List<int>() { 2,2,1 }).Returns(5);
            }
        }

        private IEnumerable TestDataAverage
        {
            get
            {
                yield return new TestCaseData(new List<int>() { 4, 5, 6 }).Returns(5);
                yield return new TestCaseData(new List<int>() { 1, 1 }).Returns(1);
                yield return new TestCaseData(new List<int>()).Returns(0);
                yield return new TestCaseData(new List<int>() { 10 }).Returns(10);
                yield return new TestCaseData(new List<int>() { 2, 2, 1 }).Returns(1.6666666666666667d);
            }
        }

        [Test,TestCaseSource(nameof(TestDataSum))]
        public int Sum(List<int> data)
        {
            return Program.Sum(data);
        }

        [Test, TestCaseSource(nameof(TestDataAverage))]
        public double Average(List<int> data)
        {
            return Program.Average(data);
        }
    }

    
}
/*
4 5 6	Sum=15; Average=5
1 1	Sum=1; Average=1
	Sum=0; Average=0
10	Sum=10; Average=10
2 2 1	Sum=5; Average=1.66666666666667
*/
