using System;
using System.Linq;
using ImplementAnArrayBasedStack;
using NUnit.Framework;

namespace UnitTests
{
    [TestFixture]
    public class ArrayBasedStackTests
    {
        [Test]
        public void PushPopElement()
        {
            ArrayStack<int> testStack = new ArrayStack<int>();
            Assert.AreEqual(0,testStack.Count);
            testStack.Push(1);
            Assert.AreEqual(1,testStack.Count);
        }

        [Test]
        public void PushPopElements()
        {
            ArrayStack<string> testStack = new ArrayStack<string>();
            for (int i = 0; i < 1000; i++)
            {
                Assert.AreEqual(i,testStack.Count);
                testStack.Push("test");
            }
            for (int i = 1000; i >= 1; i--)
            {
                Assert.AreEqual(i, testStack.Count);
                testStack.Pop();
            }
            Assert.AreEqual(0, testStack.Count);

        }

        [Test]
        public void PopEmptyStack()
        {
            ArrayStack<string> testStack = new ArrayStack<string>();
            Assert.Throws<IndexOutOfRangeException>(() =>
                {
                    testStack.Pop();
                });
        }

        [Test]
        public void PopPushElementCheck()
        {
            ArrayStack<int> testStack = new ArrayStack<int>();
            Assert.IsTrue(0 == testStack.Count);

            int firstNum = 25;
            int secondNum = 55;

            testStack.Push(firstNum);
            Assert.IsTrue(1 == testStack.Count);

            testStack.Push(secondNum);
            Assert.IsTrue(2 == testStack.Count);

            Assert.AreEqual(testStack.Pop(), secondNum);
            Assert.IsTrue(1 == testStack.Count);

            Assert.AreEqual(testStack.Pop(), firstNum);
            Assert.IsTrue(0 == testStack.Count);
        }

        [TestCase(new int[] {3,5,-7,2,15,-34})]
        public void ToArray(int[] data)
        {
            ArrayStack<int> testStack = new ArrayStack<int>();
            for (int i = 0; i < data.Length; i++)
            {
                testStack.Push(data[i]);
            }
            int[] result = testStack.ToArray();
            CollectionAssert.AreEqual(data.Reverse(),result);
        }

        [Test]
        public void ToArrayEmpty()
        {
            ArrayStack<int> testStack = new ArrayStack<int>();
            int[] result = testStack.ToArray();
            CollectionAssert.AreEqual(result, new int[0]);
        }
    }
}
