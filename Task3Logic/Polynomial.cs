using System;

namespace Task3Logic
{
    public class Polynomial
    {
        #region Fields

        private double[] coefficients;

        #endregion

        #region Constructors

        public Polynomial(params double[] _coefficients)
        {
            coefficients = new double[_coefficients.Length];
            for (int i = 0; i < _coefficients.Length; i++)
                coefficients[i] = _coefficients[i];
        }

        public Polynomial(): this(1, 1, 1)
        {
        }

        #endregion

        #region Public methods
        
        /// <summary>
        /// Gets result of polynomial.
        /// </summary>
        /// <param name="value"> Value of polynomial</param>
        /// <returns> Result of polynomial</returns>
        public double Result(double value)
        {
            double result = 0;
            for (int i = 0; i < coefficients.Length; i++)
                result += coefficients[i] * Math.Pow(value, i);
            return result;
        }

       
        /// <summary>
        /// Sums 2 polynomials.
        /// </summary>
        /// <param name="firstPolynomial"> First polynomial</param>
        /// <param name="secondPolynomial"> Second polynomial</param>
        /// <returns> Sum of polynomials</returns>
        public static Polynomial operator +(Polynomial firstPolynomial, Polynomial secondPolynomial)
        {
            if (ReferenceEquals(firstPolynomial, null))
                throw new ArgumentNullException();
            if (ReferenceEquals(secondPolynomial, null))
                throw new ArgumentNullException();

            Polynomial result, tempPolynomial;
            if (firstPolynomial.coefficients.Length > secondPolynomial.coefficients.Length)
            {
                result = Copy(firstPolynomial);
                tempPolynomial = secondPolynomial;
            }
            else
            {
                result = Copy(secondPolynomial);
                tempPolynomial = firstPolynomial;
            }

            for (int i = 0; i < tempPolynomial.coefficients.Length; i++)
                result.coefficients[i] += tempPolynomial.coefficients[i];

            return result;
        }

        /// <summary>
        /// Adds number to polynomial.
        /// </summary>
        /// <param name="number"> Number</param>
        /// <param name="polynomial"> Polynomial</param>
        /// <returns> Polynomial plus number</returns>
        public static Polynomial operator +(Polynomial polynomial, double number)
        {
            if (ReferenceEquals(polynomial, null))
                throw new ArgumentNullException();

            Polynomial sum = Copy(polynomial);
            sum.coefficients[0] += number;
            return sum;
        }

        /// <summary>
        /// Adds number to polynomial.
        /// </summary>
        /// <param name="number"> Number</param>
        /// <param name="polynomial"> Polynomial</param>
        /// <returns> Polynomial plus number</returns>
        public static Polynomial operator +(double number, Polynomial polynomial)
        {
            return polynomial + number;
        }

        /// <summary>
        /// Sums 2 polynomials.
        /// </summary>
        /// <param name="firstPolynomial"> First polynomial</param>
        /// <param name="secondPolynomial"> Second polynomial</param>
        /// <returns> Sum of polynomials</returns>
        public static Polynomial Add(Polynomial firstPolynomial, Polynomial secondPolynomial)
        {
            return firstPolynomial + secondPolynomial;
        }

        /// <summary>
        /// Adds number to polynomial.
        /// </summary>
        /// <param name="number"> Number</param>
        /// <param name="polynomial"> Polynomial</param>
        /// <returns> Polynomial plus number</returns>
        public static Polynomial Add(Polynomial polynomial, double number)
        {
            return polynomial + number;
        }

        /// <summary>
        /// Adds number to polynomial.
        /// </summary>
        /// <param name="number"> Number</param>
        /// <param name="polynomial"> Polynomial</param>
        /// <returns> Polynomial plus number</returns>
        public static Polynomial Add(double number, Polynomial polynomial)
        {
            return polynomial + number;
        }

        /// <summary>
        /// Opposites polynomial.
        /// </summary>
        /// <param name="polynomial"> Polynomial</param>
        /// <returns> Opposite polynomial</returns>
        public static Polynomial operator -(Polynomial polynomial)
        {
            if (ReferenceEquals(polynomial, null))
                throw new ArgumentNullException();

            Polynomial oppositePolynomial = Copy(polynomial);
            for (int i = 0; i < oppositePolynomial.coefficients.Length; i++)
                oppositePolynomial.coefficients[i] *= -1;

            return oppositePolynomial;
        }

        /// <summary>
        /// Subtracts 2 polynomials.
        /// </summary>
        /// <param name="firstPolynomial"> First polynomial</param>
        /// <param name="secondPolynomial"> Second polynomial</param>
        /// <returns> Subtracted polynomials</returns>
        public static Polynomial operator -(Polynomial firstPolynomial, Polynomial secondPolynomial)
        {
            return firstPolynomial + (-secondPolynomial);
        }

        /// <summary>
        /// Subtracts number and polynomial.
        /// </summary>
        /// <param name="number"> Number</param>
        /// <param name="polynomial"> Polynomial</param>
        /// <returns> Polynomial subtracted on number</returns>
        public static Polynomial operator -(Polynomial polynomial, double number)
        {
            return polynomial + (number * (-1));
        }

        /// <summary>
        /// Subtracts number and polynomial.
        /// </summary>
        /// <param name="number"> Number</param>
        /// <param name="polynomial"> Polynomial</param>
        /// <returns> Polynomial subtracted on number</returns>
        public static Polynomial operator -(double number, Polynomial polynomial)
        {
            Polynomial result = Copy(polynomial);
            result = -result;
            result.coefficients[0] += number;
            return result;
        }

        /// <summary>
        /// Subtracts 2 polynomials.
        /// </summary>
        /// <param name="firstPolynomial"> First polynomial</param>
        /// <param name="secondPolynomial"> Second polynomial</param>
        /// <returns> Subtracted polynomials</returns>
        public static Polynomial Subtract(Polynomial firstPolynomial, Polynomial secondPolynomial)
        {
            return firstPolynomial - secondPolynomial;
        }

        /// <summary>
        /// Subtracts number and polynomial.
        /// </summary>
        /// <param name="number"> Number</param>
        /// <param name="polynomial"> Polynomial</param>
        /// <returns> Polynomial subtracted on number</returns>
        public static Polynomial Subtract(Polynomial polynomial, double number)
        {
            return polynomial - number;
        }

        /// <summary>
        /// Subtracts number and polynomial.
        /// </summary>
        /// <param name="number"> Number</param>
        /// <param name="polynomial"> Polynomial</param>
        /// <returns> Polynomial subtracted on number</returns>
        public static Polynomial Subtract(double number, Polynomial polynomial)
        {
            return number - polynomial;
        }

        /// <summary>
        /// Multyplies number and polynomial.
        /// </summary>
        /// <param name="number"> Number</param>
        /// <param name="polynomial"> Polynomial</param>
        /// <returns> Polynomial multyplied on number</returns>
        public static Polynomial operator *(Polynomial polynomial, double number)
        {
            if (ReferenceEquals(polynomial, null))
                throw new ArgumentNullException();

            Polynomial result = Copy(polynomial);
            for (int i = 0; i < result.coefficients.Length; i++)
                result.coefficients[i] *= number;
            return result;
        }

        /// <summary>
        /// Multyplies number and polynomial.
        /// </summary>
        /// <param name="number"> Number</param>
        /// <param name="polynomial"> Polynomial</param>
        /// <returns> Polynomial multyplied on number</returns>
        public static Polynomial operator *(double number, Polynomial polynomial)
        {
            return polynomial * number;
        }

        /// <summary>
        /// Multyplies number and polynomial.
        /// </summary>
        /// <param name="number"> Number</param>
        /// <param name="polynomial"> Polynomial</param>
        /// <returns> Polynomial multyplied on number</returns>
        public static Polynomial Multiply(Polynomial polynomial, double number)
        {
            return polynomial * number;
        }

        /// <summary>
        /// Multyplies number and polynomial.
        /// </summary>
        /// <param name="number"> Number</param>
        /// <param name="polynomial"> Polynomial</param>
        /// <returns> Polynomial multyplied on number</returns>
        public static Polynomial Multiply(double number, Polynomial polynomial)
        {
            return polynomial * number;
        }

        public bool Equals(Polynomial polynomial)
        {
            if (ReferenceEquals(polynomial, null))
                return false;

            if (coefficients.Length != polynomial.coefficients.Length)
                return false;
            for (int i = 0; i < coefficients.Length; i++)
                if (coefficients[i] != polynomial.coefficients[i])
                    return false;
            return true;
        }

        /// <summary>
        /// Compares 2 polynomials.
        /// </summary>
        /// <param name="firstPolynomial"> First polynomial</param>
        /// <param name="secondPolynomial"> Second polynomial</param>
        /// <returns> True if polynomials are equal, otherwise false</returns>
        public static bool operator ==(Polynomial firstPolynomial, Polynomial secondPolynomial)
        {
            return firstPolynomial.Equals(secondPolynomial);
        }

        /// <summary>
        /// Compares number and polynomial.
        /// </summary>
        /// <param name="polynomial"> Polynomial</param>
        /// <param name="number"> Number</param>
        /// <returns> True if number and polynomial are equal, otherwise false</returns>
        public static bool operator ==(Polynomial polynomial, double number)
        {
            return polynomial.Equals(number);
        }

        /// <summary>
        /// Compares number and polynomial.
        /// </summary>
        /// <param name="number"> Number</param>
        /// <param name="polynomial"> Polynomial</param>
        /// <returns> True if number and polynomial are equal, otherwise false</returns>
        public static bool operator ==(double number, Polynomial polynomial)
        {
            return polynomial.Equals(number);
        }

        /// <summary>
        /// Compares 2 polynomials.
        /// </summary>
        /// <param name="firstPolynomial"> First polynomial</param>
        /// <param name="secondPolynomial"> Second polynomial</param>
        /// <returns> True if polynomials are not equal, otherwise false</returns>
        public static bool operator !=(Polynomial firstPolynomial, Polynomial secondPolynomial)
        {
            return !firstPolynomial.Equals(secondPolynomial);
        }

        /// <summary>
        /// Compares number and polynomial.
        /// </summary>
        /// <param name="polynomial"> Polynomial</param>
        /// <param name="number"> Number</param>
        /// <returns> True if number and polynomial are not equal, otherwise false</returns>
        public static bool operator !=(Polynomial polynomial, double number)
        {
            return !polynomial.Equals(number);
        }

        /// <summary>
        /// Compares number and polynomial.
        /// </summary>
        /// <param name="number"> Number</param>
        /// <param name="polynomial"> Polynomial</param>
        /// <returns> True if number and polynomial are not equal, otherwise false</returns>
        public static bool operator !=(double number, Polynomial polynomial)
        {
            return !polynomial.Equals(number);
        }
        
        #endregion

        #region Private methods

        /// <summary>
        /// Gets copy of the polynomial.
        /// </summary>
        /// <param name="polynomial"> Polynomial</param>
        /// <returns> Copy of input polynomial</returns>
        private static Polynomial Copy(Polynomial polynomial)
        {
            double[] copiedCoefficients = new double[polynomial.coefficients.Length];
            Polynomial copy = new Polynomial(copiedCoefficients);
            for (int i = 0; i < polynomial.coefficients.Length; i++)
                copy.coefficients[i] = polynomial.coefficients[i];
            return copy;
        }

        #endregion
    }
}
