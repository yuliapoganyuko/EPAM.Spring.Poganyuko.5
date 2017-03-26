﻿using System;
using System.Collections.Generic;
using Task1Logic;
using NUnit.Framework;

namespace Task1LogicNUnitTests
{
    public class NewtonRootTest
    {
        public IEnumerable<TestCaseData> TestData
        {
            get
            {
                yield return new TestCaseData(9, 2, double.Epsilon).Returns(3);
                yield return new TestCaseData(8, -3, double.Epsilon).Returns(Math.Pow(8, 1.0 / (-3)));
                yield return new TestCaseData(2, 0, double.Epsilon).Throws(typeof(ArgumentOutOfRangeException));
                yield return new TestCaseData(0, 2, double.Epsilon).Throws(typeof(ArgumentOutOfRangeException));
            }
        }

        [Test, TestCaseSource("TestData")]
        public static double Root_Test(double number, int power, double eps)
        {
            return NewtonRoot.Root(number, power, eps);
        }
    }
}
