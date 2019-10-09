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
            Assert.AreEqual(true, traingle.triangleCheck(3, 4, 5));
        }

        [TestCase]

        public void Test_NotTraingleValues()
        {
            bool result = traingle.triangleCheck(1, 4, 5);
            Assert.AreNotEqual(true, result);
        }

        [TestCase]

        public void Test_ZiroValue()
        {
            bool result = traingle.triangleCheck(0, 4, 5);
              Assert.IsFalse(result);
        }

        [TestCase]

        public void Test_ZiroValue2()
        {
            bool result = traingle.triangleCheck(0, 0, 0);
            Assert.IsFalse(result);
        }

        [TestCase]

        public void Test_NegativeValues()
        {
            bool result = traingle.triangleCheck(-2, -3, -5);
            Assert.IsFalse(result);
        }

        public void Test_NegativeValues2()
        {
            bool result = traingle.triangleCheck(-1, 3, 5);
            Assert.IsFalse(result);
        }

        [TestCase]

        public void Test_Values()
        {
            bool result = traingle.triangleCheck(10, 15, 15);
            Assert.IsTrue(result);
        }

        [TestCase]

        public void Test_Values2()
        {
            bool result = traingle.triangleCheck(5, 7, 9);
            Assert.IsTrue(result);
        }

        [TestCase]

        public void Test_Values3()
        {
            bool result = traingle.triangleCheck(1, 2, 1);
            Assert.IsFalse(result);
        }

        [TestCase]

        public void Test_Values4()
        {
            bool result = traingle.triangleCheck(0.4, 4, 4);
            Assert.IsTrue(result);
        }
    }
}
