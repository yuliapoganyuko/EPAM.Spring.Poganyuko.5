using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Task2Logic;

namespace Task2LogicTests
{
    [TestClass]
    public class GcdTest
    {
        [TestMethod]
        public void GetGcd_2and3gcd_6returned()
        {
            double expected = 6;
            double actual = Gcd.GetGcd(2, 3);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetGcd_2_3_5_gcd_30returned()
        {
            double expected = 30;
            double actual = Gcd.GetGcd(2, 3, 5);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetBinaryGcd_2and3gcd_6returned()
        {
            double expected = 6;
            double actual = Gcd.GetBinaryGcd(2, 3);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetBinaryGcd_2_3_5_gcd_30returned()
        {
            double expected = 30;
            double actual = Gcd.GetBinaryGcd(2, 3, 5);
            Assert.AreEqual(expected, actual);
        }
    }
}
