namespace RefactoringCode.Tests
{
    using System;
    using RefactoringCode;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class MatrixWalkTests
    {
        [TestMethod]
        public void MatrixWalkTest()
        {
            var mat = new MatrixWalk(5);

            int expectedDimension1Size = 5;
            int expectedDimension2Size = 5;

            Assert.AreEqual(expectedDimension1Size, mat.Matrix.GetLength(0));
            Assert.AreEqual(expectedDimension2Size, mat.Matrix.GetLength(1));
        }

        [TestMethod]
        public void CalculateTest()
        {
            var mat = new MatrixWalk(6);
            mat.Calculate();
            mat.Print();

            var expected = new int[6,6]{{1, 16, 17, 18, 19, 20},
                                    {15, 2, 27, 28, 29, 21},
                                    {14, 31, 3, 26, 30, 22},
                                    {13, 36, 32, 4, 25, 23},
                                    {12, 35, 34, 33, 5, 24},
                                    {11, 10, 9, 8, 7, 6}

            };

            CollectionAssert.AreEqual(expected, mat.Matrix);
        }

        [TestMethod]
        [ExpectedException(
            typeof(ArgumentOutOfRangeException))]
        public void
        MatrixWalkSizeTest()
        {
            var mat = new MatrixWalk(0);
        }

        [TestMethod]
        [ExpectedException(
            typeof(ArgumentOutOfRangeException))]
        public void
        MatrixWalkMaxSizeTest()
        {
            var mat = new MatrixWalk(101);
        }
    }
}
