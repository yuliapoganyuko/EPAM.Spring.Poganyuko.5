using System;
using System.Collections.Generic;
using Task2Logic;
using NUnit.Framework;

namespace Task2LogicNUnitTests
{
    public class GcdTest
    {
        #region GetGcd for 2 arguments

        public IEnumerable<TestCaseData> TestDataGetGcdFor2Arguments
        {
            get
            {
                yield return new TestCaseData(2, 8).Returns(2);
                yield return new TestCaseData(2, -8).Returns(2);
                yield return new TestCaseData(0, 0).Throws(typeof(ArgumentOutOfRangeException));
            }
        }

        [Test, TestCaseSource("TestDataGetGcdFor2Arguments")]
        public static double GetGcd_2Arguments_Test(int firstNumber, int secondNumber)
        {
            return Gcd.GetGcd(firstNumber, secondNumber);
        }

        #endregion

        #region GetGcd for more than 2 arguments

        public IEnumerable<TestCaseData> TestDataGetGcdForMoreThan2Arguments
        {
            get
            {
                yield return new TestCaseData(18, 6, new int[] { 24 }).Returns(6);
                yield return new TestCaseData(-2, -8, new int[] { -4 }).Returns(2);
                yield return new TestCaseData(0, 0, new int[] { 0, 0 }).Throws(typeof(ArgumentOutOfRangeException));
                yield return new TestCaseData(0, 0, null).Throws(typeof(ArgumentNullException));
            }
        }

        [Test, TestCaseSource("TestDataGetGcdForMoreThan2Arguments")]
        public static double GetGcd_MoreThan2Arguments_Test(int firstNumber, int secondNumber, params int[] numbers)
        {
            return Gcd.GetGcd(firstNumber, secondNumber, numbers);
        }

        #endregion

        #region GetBinaryGcd for 2 arguments

        public IEnumerable<TestCaseData> TestDataGetBinaryGcdFor2Arguments
        {
            get
            {
                yield return new TestCaseData(2, 8).Returns(2);
                yield return new TestCaseData(2, -8).Returns(2);
                yield return new TestCaseData(0, 0).Throws(typeof(ArgumentOutOfRangeException));
            }
        }

        [Test, TestCaseSource("TestDataGetBinaryGcdFor2Arguments")]
        public static double GetBinaryGcd_MoreThan2Arguments_Test(int firstNumber, int secondNumber)
        {
            return Gcd.GetBinaryGcd(firstNumber, secondNumber);
        }


        #endregion

        #region GetBinaryGcd for more than 2 arguments

        public IEnumerable<TestCaseData> TestDataGetBinaryGcdForMoreThan2Arguments
        {
            get
            {
                yield return new TestCaseData(18, 6, new int[] {24} ).Returns(6);
                yield return new TestCaseData(-2, -8, new int[] { -4 }).Returns(2);
                yield return new TestCaseData(0, 0, new int[] { 0, 0 }).Throws(typeof(ArgumentOutOfRangeException));
                yield return new TestCaseData(0, 0, null).Throws(typeof(ArgumentNullException));
            }
        }

        [Test, TestCaseSource("TestDataGetBinaryGcdForMoreThan2Arguments")]
        public static double GetBinaryGcd_MoreThan2Arguments_Test(int firstNumber, int secondNumber, params int[] numbers)
        {
            return Gcd.GetBinaryGcd(firstNumber, secondNumber, numbers);
        }

        #endregion
    }
}
