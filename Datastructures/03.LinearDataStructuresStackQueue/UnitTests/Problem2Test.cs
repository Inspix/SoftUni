using System;
using System.Collections;
using System.Collections.Generic;
using CalculateSequence;
using NUnit.Framework;

namespace UnitTests
{
    [TestFixture]
    public class Problem2Test
    {
        private IEnumerable QueueSequenceData
        {
            get
            {
                yield return new TestCaseData(2).Returns(new List<int>
                {
                    2,3,5,4,4,7,5,6,11,7,5,9,6,5,9,6,8,15,9,6,11,7,7,13,8,12,23,
                    13,8,15,9,6,11,7,10,19,11,7,13,8,6,11,7,10,19,11,7,13,8,9
                });
                yield return new TestCaseData(-1).Returns(new List<int>
                {
                    -1,0,-1,1,1,1,2,0,-1,1,2,3,3,2,3,3,2,3,3,3,5,4,1,1,2,
                    0,-1,1,2,3,3,3,5,4,4,7,5,4,7,5,3,5,4,4,7,5,4,7,5,3
                });

                yield return new TestCaseData(1000).Returns(new List<int>
                {
                    1000,1001,2001,1002,1002,2003,1003,2002,4003,2003,1003,2005,1004,
                    1003,2005,1004,2004,4007,2005,1004,2007,1005,2003,4005,2004,4004,
                    8007,4005,2004,4007,2005,1004,2007,1005,2006,4011,2007,1005,2009,
                    1006,1004,2007,1005,2006,4011,2007,1005,2009,1006,2005
                });
            }
        }


        [Test,TestCaseSource(nameof(QueueSequenceData))]
        public List<int> QueueSequence(int data)
        {
            return Calculations.QueueSequence(data);
        }
    }
}
