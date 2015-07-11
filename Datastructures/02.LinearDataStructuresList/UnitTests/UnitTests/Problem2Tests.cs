using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using Problem2.SortWords;

namespace UnitTests
{
    [TestFixture]
    public class Problem2Tests
    {
        private IEnumerable TestData
        {
            get
            {
                yield return
                    new TestCaseData(new List<string>() {"wow", "softuni", "alpha"})
                    {
                        ExpectedResult = new List<string>() {"alpha", "softuni", "wow"}
                    };
                yield return
                    new TestCaseData(new List<string>() {"hi"}) {ExpectedResult = new List<string>() {"hi"}};
                yield return
                    new TestCaseData(new List<string>() {"rakiya", "beer", "wine", "vodka", "whiskey"})
                    {
                        ExpectedResult = new List<string>() {"beer", "rakiya", "vodka", "whiskey", "wine"}
                    };
            }
                 
        } 

        [Test,TestCaseSource(nameof(TestData))]
        public List<string> Sort(List<string> data)
        {
            Program.Sort(data);
            return data;
        }
    }
}
