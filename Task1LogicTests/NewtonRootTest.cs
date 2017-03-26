using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Task1Logic;

namespace Task1LogicTests
{
    [TestClass]
    public class NewtonRootTest
    {
        [TestMethod]
        public void Root_2rootof9_3returned()
        {
            double expected = 3;
            double actual = NewtonRoot.Root(9, 2, double.Epsilon);
            Assert.AreEqual(expected, actual);
        }
        
        [TestMethod]
        public void Root_negativepower()
        {
            double expected = Math.Pow(8, 1.0/(-3));
            double actual = NewtonRoot.Root(8, -3, double.Epsilon);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Root_0power()
        {
            double actual = NewtonRoot.Root(2, 0, double.Epsilon);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Root_0number()
        {
            double actual = NewtonRoot.Root(0, 2, double.Epsilon);
        }
    }
}
