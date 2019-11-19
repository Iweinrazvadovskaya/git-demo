using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTests
{
    [TestFixture]
    public class TestCaseNUnit
    {
        private MathLogic traingle = new MathLogic();

        [TestCase]
        public  void Test_TraingleValues()
        {
            Assert.AreEqual(true, traingle.TriangleCheck(3, 4, 5));
        }

        [TestCase]
        public void Test_NotTraingleValues()
        {
             Assert.IsFalse(traingle.TriangleCheck(1, 4, 5)); 
        }

        [TestCase]
        public void Test_FirstValueIsZero()
        {
              Assert.IsFalse(traingle.TriangleCheck(0, 4, 5));
        }

        [TestCase]

        public void Test_AllValueAreZero()
        {
              Assert.IsFalse(traingle.TriangleCheck(0, 0, 0));
        }

        [TestCase]

        public void Test_AllNegativeValues()
        {
            Assert.IsFalse(traingle.TriangleCheck(-2, -3, -5));
        }

        public void Test_OneNegativeValues()
        {
            Assert.IsFalse(traingle.TriangleCheck(-1, 3, 5));
        }

        [TestCase]

        public void Test_RightValues()
        {
            Assert.IsTrue(traingle.TriangleCheck(10, 15, 15));
        }

        [TestCase]

        public void Test_RightUnequalValues()
        {
            Assert.IsTrue(traingle.TriangleCheck(5, 7, 9));
        }

        [TestCase]

        public void Test_RightEqualValues()
        {
            Assert.IsFalse(traingle.TriangleCheck(1, 2, 1));
        }

        [TestCase]

        public void Test_NotIntegerValue()
        {
            Assert.IsTrue(traingle.TriangleCheck(0.4, 4, 4));
        }
    }
}
