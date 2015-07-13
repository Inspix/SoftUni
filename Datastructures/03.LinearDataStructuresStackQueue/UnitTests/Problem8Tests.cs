using System;
using System.Collections;
using NUnit.Framework;
using _08.SequenceNtoM;

namespace UnitTests
{
    [TestFixture]
    public class Problem8Tests
    {

        private IEnumerable SequenceTests
        {
            get
            {
                yield return new TestCaseData(3,10).Returns("3 -> 5 -> 10");
                yield return new TestCaseData(5, -5).Returns("(no solution)");
                yield return new TestCaseData(10, 30).Returns("10 -> 11 -> 13 -> 15 -> 30");
            }
        }

        [Test,TestCaseSource(nameof(SequenceTests))]
        public string SequenceTest(int start, int end)
        {
            Item result = Calculations.CalculateSequence(start, end);
            return Calculations.SequencePrint(result);
        }
    }
}
