using System;
using System.Collections.Generic;
using NUnit.Framework;
using Task3Logic;

namespace Task3LogicNUnitTests
{
    public class PolynomialTest
    {
        public IEnumerable<TestCaseData> TestDataResult
        {
            get
            {
                yield return new TestCaseData(new Polynomial(5, 7), 2).Returns(19);
            }
        }

        [Test, TestCaseSource("TestDataResult")]
        public static double Result_Test(Polynomial polynomial, double value)
        {
            return polynomial.Result(value);
        }

        public IEnumerable<TestCaseData> TestDataSumPolynomials
        {
            get
            {
                yield return new TestCaseData(new Polynomial(2, 3), new Polynomial(-2, -3)).Returns(0);
                yield return new TestCaseData(new Polynomial(5, 7), null).Throws(typeof(ArgumentNullException));

            }
        }

        [Test, TestCaseSource("TestDataSumPolynomials")]
        public double Sum_Polynomials(Polynomial firstPolynomial, Polynomial secondPolynomial)
        {
            Polynomial result = firstPolynomial + secondPolynomial;
            return result.Result(1);
        }

        public IEnumerable<TestCaseData> TestDataSumPolynomialAndNumber
        {
            get
            {
                yield return new TestCaseData(new Polynomial(5, 7), -5).Returns(7);
            }
        }

        [Test, TestCaseSource("TestDataSumPolynomialAndNumber")]
        public double Sum_PolynomialAndNumber(Polynomial firstPolynomial, double number)
        {
            Polynomial result = firstPolynomial + number;
            return result.Result(1);
        }

        public IEnumerable<TestCaseData> TestDataSubtractPolynomials
        {
            get
            {
                yield return new TestCaseData(new Polynomial(2, 3), new Polynomial(2, 3)).Returns(0);
                yield return new TestCaseData(new Polynomial(5, 7), null).Throws(typeof(ArgumentNullException));

            }
        }

        [Test, TestCaseSource("TestDataSubtractPolynomials")]
        public double Subtract_Polynomials(Polynomial firstPolynomial, Polynomial secondPolynomial)
        {
            Polynomial result = firstPolynomial - secondPolynomial;
            return result.Result(1);
        }

        public IEnumerable<TestCaseData> TestDataSubtractPolynomialAndNumber
        {
            get
            {
                yield return new TestCaseData(new Polynomial(5, 7), 5).Returns(7);
            }
        }

        [Test, TestCaseSource("TestDataSubtractPolynomialAndNumber")]
        public double Subtract_PolynomialAndNumber(Polynomial polynomial, double number)
        {
            Polynomial result = polynomial - number;
            return result.Result(1);
        }

        public IEnumerable<TestCaseData> TestDataSubtractNumberAndPolynomial
        {
            get
            {
                yield return new TestCaseData(new Polynomial(5, 7), 5).Returns(-7);
            }
        }

        [Test, TestCaseSource("TestDataSubtractNumberAndPolynomial")]
        public double Subtract_NumberAndPolynomial(Polynomial polynomial, double number)
        {
            Polynomial result = number - polynomial;
            return result.Result(1);
        }

        public IEnumerable<TestCaseData> TestDataMultyplyNumberAndPolynomial
        {
            get
            {
                yield return new TestCaseData(new Polynomial(5, 7), 3).Returns(36);
                yield return new TestCaseData(null, 5).Throws(typeof(ArgumentNullException));
            }
        }
        
        [Test, TestCaseSource("TestDataMultyplyNumberAndPolynomial")]
        public double Multyply_NumberAndPolynomial(Polynomial polynomial, double number)
        {
            Polynomial result = number * polynomial;
            return result.Result(1);
        }
        
        public IEnumerable<TestCaseData> TestDataEquality
        {
            get
            {
                yield return new TestCaseData(new Polynomial(5, 7), new Polynomial(5, 7)).Returns(true);
                yield return new TestCaseData(null, new Polynomial(5, 7)).Throws(typeof(NullReferenceException));
                yield return new TestCaseData(new Polynomial(5, 7), null).Returns(false);
                yield return new TestCaseData(new Polynomial(5, 7), new Polynomial(1, 5, 7)).Returns(false);
            }
        }

        [Test, TestCaseSource("TestDataEquality")]
        public bool Equals_Test(Polynomial firstPolynomial, Polynomial secondPolynomial)
        {
            return firstPolynomial.Equals(secondPolynomial);
        }
        
    }
}
