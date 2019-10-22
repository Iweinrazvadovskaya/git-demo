using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTests
{
    [TestFixture]
    class TestCaseNUnit
    {
        MathLogic traingle = new MathLogic();
        [TestCase]

        public  void Test_TraingleValues()
        {
            Assert.AreEqual(true, traingle.TriangleCheck(3, 4, 5));
        }

        [TestCase]

        public void Test_NotTraingleValues()
        {
            bool result = traingle.TriangleCheck(1, 4, 5);
            Assert.AreNotEqual(true, result);
        }

        [TestCase]

        public void Test_FirstValueIsZiro()
        {
            bool result = traingle.TriangleCheck(0, 4, 5);
              Assert.IsFalse(result);
        }

        [TestCase]

        public void Test_AllValueAreZiro()
        {
            bool result = traingle.TriangleCheck(0, 0, 0);
            Assert.IsFalse(result);
        }

        [TestCase]

        public void Test_AllNegativeValues()
        {
            bool result = traingle.TriangleCheck(-2, -3, -5);
            Assert.IsFalse(result);
        }

        public void Test_OneNegativeValues()
        {
            bool result = traingle.TriangleCheck(-1, 3, 5);
            Assert.IsFalse(result);
        }

        [TestCase]

        public void Test_RightValues()
        {
            bool result = traingle.TriangleCheck(10, 15, 15);
            Assert.IsTrue(result);
        }

        [TestCase]

        public void Test_RightUnequalValues()
        {
            bool result = traingle.TriangleCheck(5, 7, 9);
            Assert.IsTrue(result);
        }

        [TestCase]

        public void Test_RightEqualValues()
        {
            bool result = traingle.TriangleCheck(1, 2, 1);
            Assert.IsFalse(result);
        }

        [TestCase]

        public void Test_NotIntegerValue()
        {
            bool result = traingle.TriangleCheck(0.4, 4, 4);
            Assert.IsTrue(result);
        }
    }
}
