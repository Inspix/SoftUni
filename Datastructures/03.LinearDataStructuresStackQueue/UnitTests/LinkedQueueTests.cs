using System;
using NUnit.Framework;
using _07.LinkedQueue;

namespace UnitTests
{
    [TestFixture]
    public class LinkedQueueTests
    {
        [Test]
        public void EnqueueDequeueElement()
        {
            LinkedQueue<int> testQueue = new LinkedQueue<int>();
            Assert.AreEqual(0, testQueue.Count);
            testQueue.Enqueue(1);
            Assert.AreEqual(1, testQueue.Count);
        }

        [Test]
        public void EnqueueDequeueElements()
        {
            LinkedQueue<string> testQueue = new LinkedQueue<string>();
            for (int i = 0; i < 1000; i++)
            {
                Assert.AreEqual(i, testQueue.Count);
                testQueue.Enqueue("test");
            }
            for (int i = 1000; i >= 1; i--)
            {
                Assert.AreEqual(i, testQueue.Count);
                testQueue.Dequeue();
            }
            Assert.AreEqual(0, testQueue.Count);

        }

        [Test]
        public void DequeueEmptyStack()
        {
            LinkedQueue<string> testQueue = new LinkedQueue<string>();
            Assert.Throws<NullReferenceException>(() =>
            {
                testQueue.Dequeue();
            });
        }

        [Test]
        public void DequeueEnqueueElementCheck()
        {
            LinkedQueue<int> testQueue = new LinkedQueue<int>();
            Assert.IsTrue(0 == testQueue.Count);

            int firstNum = 25;
            int secondNum = 55;

            testQueue.Enqueue(firstNum);
            Assert.IsTrue(1 == testQueue.Count);

            testQueue.Enqueue(secondNum);
            Assert.IsTrue(2 == testQueue.Count);

            Assert.AreEqual(testQueue.Dequeue(), firstNum);
            Assert.IsTrue(1 == testQueue.Count);

            Assert.AreEqual(testQueue.Dequeue(), secondNum);
            Assert.IsTrue(0 == testQueue.Count);
        }

        [TestCase(new int[] {3, 5, -7, 2, 15, -34})]
        public void ToArray(int[] data)
        {
            LinkedQueue<int> testQueue = new LinkedQueue<int>();
            for (int i = 0; i < data.Length; i++)
            {
                testQueue.Enqueue(data[i]);
            }
            int[] result = testQueue.ToArray();
            CollectionAssert.AreEqual(data,result);
        }

        [Test]
        public void ToArrayEmpty()
        {
            LinkedQueue<int> testQueue = new LinkedQueue<int>();
            int[] result = testQueue.ToArray();
            CollectionAssert.AreEqual(result, new int[0]);
        }
    }
}
