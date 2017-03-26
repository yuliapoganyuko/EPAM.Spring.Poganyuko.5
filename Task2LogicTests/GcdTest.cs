using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Task2Logic;

namespace Task2LogicTests
{
    [TestClass]
    public class GcdTest
    {
        #region GetGcd for 2 arguments

        [TestMethod]
        public void GetGcd_Positive_Numbers()
        {
            int expected = 2;
            int actual = Gcd.GetGcd(2, 8);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetGcd_Negative_Number()
        {
            int expected = 2;
            int actual = Gcd.GetGcd(2, -8);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void GetGcd_Zero_Argument()
        {
            Gcd.GetGcd(2, 0);
        }

        #endregion

        #region GetGcd for more than 2 arguments

        [TestMethod]
        public void GetGcd_3_Positive_Numbers()
        {
            int expected = 6;
            int actual = Gcd.GetGcd(18, 6, 24);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetGcd_3_Negative_Numbers()
        {
            int expected = 2;
            int actual = Gcd.GetGcd(-2, -8, -4);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void GetGcd_Zero_Arguments()
        {
            Gcd.GetGcd(2, 0, 0);
        }

        #endregion

        #region GetBinaryGcd for 2 arguments

        [TestMethod]
        public void GetBinaryGcd_Positive_Numbers()
        {
            int expected = 2;
            int actual = Gcd.GetBinaryGcd(2, 8);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetBinaryGcd_Negative_Number()
        {
            int expected = 2;
            int actual = Gcd.GetBinaryGcd(2, -8);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void GetBinaryGcd_Zero_Argument()
        {
            Gcd.GetBinaryGcd(2, 0);
        }

        #endregion

        #region GetBinaryGcd for more than 2 arguments

        [TestMethod]
        public void GetBinaryGcd_3_Positive_Numbers()
        {
            int expected = 6;
            int actual = Gcd.GetBinaryGcd(18, 6, 24);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetBinaryGcd_3_Negative_Numbers()
        {
            int expected = 2;
            int actual = Gcd.GetBinaryGcd(-2, -8, -4);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void GetBinaryGcd_Zero_Arguments()
        {
            Gcd.GetBinaryGcd(2, 0, 0);
        }

        #endregion
    }
}
