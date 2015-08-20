using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomLinkedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomLinkedList.Tests
{
    [TestClass()]
    public class DynamicListTests
    {
        private DynamicList<string> Init()
        {
            DynamicList<string> testingList = new DynamicList<string>();
            testingList.Add("test1");
            testingList.Add("test2");
            testingList.Add("test3");
            testingList.Add("test4");
            testingList.Add("test5");
            testingList.Add("test6");
            return testingList;
        }

        [TestMethod()]
        public void IndexerTest()
        {
            var testValue = Init();

            string testString = "test4";
            string indexTestOne = testValue[3];
            Assert.AreSame(testString, indexTestOne, string.Format("The expected value of {0} did not match the actual value of {1}", testString, indexTestOne));

            string testString2 = "test6";
            string indexTestTwo = testValue[5];
            Assert.AreSame(testString, indexTestOne, string.Format("The expected value of {0} did not match the actual value of {1}", testString2, indexTestTwo));

        }

        [TestMethod()]
        public void DynamicListTest()
        {
            var testValue = new DynamicList<string>();

            int expected = 0;
            Assert.AreEqual(expected, testValue.Count, string.Format("The expected count of {0} did not match the actual value of {1}", expected,testValue.Count));            
        }

        [TestMethod()]
        public void AddTest()
        {
            var testValue = new DynamicList<string>();

            testValue.Add("test1");
            int expected = 1;
            Assert.AreEqual(expected, testValue.Count, string.Format("The expected count of {0} did not match the actual value of {1}", expected, testValue.Count));

            testValue.Add("test2");
            int expected2 = 2;
            Assert.AreEqual(expected2, testValue.Count, string.Format("The expected count of {0} did not match the actual value of {1}", expected2, testValue.Count));


        }

        [TestMethod()]
        public void RemoveAtTest()
        {
            var testValue = Init();

            int expected = 6;
            Assert.AreEqual(expected, testValue.Count, string.Format("The expected count of {0} did not match the actual value of {1}", expected, testValue.Count));

            testValue.RemoveAt(2);
            int expected2 = 5;
            Assert.AreEqual(expected2, testValue.Count, string.Format("The expected count of {0} did not match the actual value of {1}", expected2, testValue.Count));

        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void RemoveAtTestInvalidIndex()
        {
            var testValue = Init();
            testValue.RemoveAt(10);
        }

        [TestMethod()]
        public void RemoveTest()
        {
            var testValue = Init();

            string removeTest = "test5";
            testValue.Remove(removeTest);
            int expectedCount = 5;
            Assert.AreEqual(expectedCount, testValue.Count, string.Format("The expected count of {0} did not match the actual value of {1}", expectedCount, testValue.Count));

            bool contains = testValue.Contains(removeTest);
            Assert.IsFalse(contains,"Expected false, when checking for removed value, but got True");
        }

        [TestMethod()]
        public void IndexOfTest()
        {
            var testValue = Init();

            int validIndexTest = testValue.IndexOf("test6");
            int expectedOnValidIndex = 5;
            Assert.AreEqual(expectedOnValidIndex, validIndexTest,string.Format("Expected {0} when searching for the index of existing item, but got {1} as result.",expectedOnValidIndex,validIndexTest));

            int invalidIndexTest = testValue.IndexOf("Wrong Value");
            int expectedOnInvalidIndex = -1;
            Assert.AreEqual(expectedOnInvalidIndex, invalidIndexTest,string.Format("Expected {0} when searching for the index of non existend item, but got {1} as result.", expectedOnInvalidIndex,invalidIndexTest));
        }

        [TestMethod()]
        public void ContainsTest()
        {
            var testValue = Init();

            bool containtedValue = testValue.Contains("test4");
            Assert.IsTrue(containtedValue,"Expected 'true' on Contains test one, but got false as result.");

            bool containtedValueTwo = testValue.Contains("test1");
            Assert.IsTrue(containtedValueTwo, "Expected 'true' on Contains test two, but got false as result.");

            bool missingValue = testValue.Contains("Invalid value");
            Assert.IsFalse(missingValue, "Expected 'false' on Contains test three, but got true as result.");
        }
    }
}
