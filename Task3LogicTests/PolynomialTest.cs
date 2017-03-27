using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Task3Logic;

namespace Task3LogicTests
{
    [TestClass]
    public class PolynomialTest
    {
        [TestMethod]
        public void Result()
        {
            Polynomial polynomial = new Polynomial(5, 7);
            double expected = polynomial.Result(2);
            Assert.AreEqual(19, expected);
        }

        [TestMethod]
        public void Sum_Polynomials()
        {
            Polynomial firstPolynomial = new Polynomial(2, 3);
            Polynomial secondPolynomial = new Polynomial(-2, -3);

            Polynomial result = firstPolynomial + secondPolynomial;
            Assert.AreEqual(0, result.Result(1));
        }

        [TestMethod]
        public void Sum_PolynomialAndNumber()
        {
            Polynomial polynomial = new Polynomial(5, 7);
            Polynomial result = -5 + polynomial;
            Assert.AreEqual(7, result.Result(1));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Addition_PolynomialAndNull()
        {
            Polynomial polynomial = new Polynomial(5, 7);
            Polynomial result = null + polynomial;
            Assert.AreEqual(7, result.Result(1));
        }

        [TestMethod]
        public void Substract_TwoPolynomials()
        {
            Polynomial firstPolynomial = new Polynomial(5, 7);
            Polynomial secondPolynomial = new Polynomial(5, 7);

            Polynomial result = firstPolynomial - secondPolynomial;
            Assert.AreEqual(0, result.Result(1));
        }

        [TestMethod]
        public void Substract_NumberMinusPolynomial()
        {
            Polynomial polynomial = new Polynomial(5, 7);
            Polynomial result = 5 - polynomial;

            Assert.AreEqual(-7, result.Result(1));
        }

        [TestMethod]
        public void Substract_PolynomialMinusNumber()
        {
            Polynomial polynomial = new Polynomial(5, 7);
            Polynomial result = polynomial - 5;

            Assert.AreEqual(7, result.Result(1));
        }

        [TestMethod]
        public void Multiply_PolynomialAndNumber()
        {
            Polynomial polynomial = new Polynomial(5, 7);
            Polynomial result = 3 * polynomial;

            Assert.AreEqual(36, result.Result(1));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Multiply_PolynomialAndNull()
        {
            Polynomial polynomial = null;

            Polynomial result = 5 * polynomial;
            Assert.AreEqual(7, result.Result(1));
        }

        [TestMethod]
        public void Equals_Polynomials()
        {
            Polynomial firstPolynomial = new Polynomial(5, 7);
            Polynomial secondPolynomial = new Polynomial(5, 7);

            Assert.IsTrue(firstPolynomial.Equals(secondPolynomial));
        }

        [TestMethod]
        public void Equals_Null_Reference()
        {
            Polynomial firstPolynomial = new Polynomial(5, 7);
            Polynomial secondPolynomial = null;

            Assert.IsFalse(firstPolynomial.Equals(secondPolynomial));
        }

        [TestMethod]
        public void NonEquals_Polynomials()
        {
            Polynomial firstPolynomial = new Polynomial(5, 7);
            Polynomial secondPolynomial = new Polynomial(3, 7, 8);

            Assert.IsFalse(firstPolynomial.Equals(secondPolynomial));
        }

    }
}
