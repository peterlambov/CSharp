using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Ex04Tests
{
    [TestClass]
    public class TestsForEx04
    {
        [TestMethod]
        public void TestMethodAll()
        {
            int[] array = new int[] { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 };
            int testNumber=1;
            int expectedCount = array.Length;
            int realCount = NumberInArray.NumberOfTimes(array, testNumber);
            Assert.AreEqual(expectedCount, realCount);
        }
        [TestMethod]
        public void TestMethodFew()
        {
            int[] array = new int[] { 5,0,0,0,0,5,0,0,0,0,5 };
            int testNumber = 5;
            int expectedCount = 3;
            int realCount = NumberInArray.NumberOfTimes(array, testNumber);
            Assert.AreEqual(expectedCount, realCount);
        }
        [TestMethod]
        public void TestMethodOnlyOne()
        {
            int[] array = new int[] { -1, 0, 0, 1, 0, 2, 0, 3, 0, 0, 4 };
            int testNumber = -1;
            int expectedCount = 1;
            int realCount = NumberInArray.NumberOfTimes(array, testNumber);
            Assert.AreEqual(expectedCount, realCount);
        }
    }
}
