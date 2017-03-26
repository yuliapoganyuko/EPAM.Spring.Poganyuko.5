﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1Logic
{
    /// <summary>
    /// Counts n-th root using Newton algorithm.
    /// </summary>
    public static class NewtonRoot
    {
        #region Public methods

        /// <summary>
        /// Counts n-th root using Newton algorithm.
        /// </summary>
        /// <param name="number">Number</param>
        /// <param name="power">Power</param>
        /// <param name="eps">Epsilon</param>
        /// <returns>n-th root</returns>
        public static double Root(double number, int power, double eps)
        {
            if (number <= 0 || eps <= 0 || eps > 1 || power == 0)
                throw new ArgumentOutOfRangeException();
            return Sqrt(number, power, eps);
        }

        #endregion

        #region Private methods

        /// <summary>
        /// Counts n-th root using Newton algorithm.
        /// </summary>
        /// <param name="number">Number</param>
        /// <param name="power">Power</param>
        /// <param name="eps">Epsilon</param>
        /// <returns>n-th root</returns>
        private static double Sqrt(double number, int power, double eps)
        {
            if (power < 0)
                return 1 / Sqrt(number, -power, eps);
            double x = number / power;
            double x0 = 0;
            double df = 0;

            while (Math.Abs(x - x0) >= eps)
            {
                df = (Math.Pow(x, power) - number) / (power * Math.Pow(x, power - 1));
                x0 = x;
                x = x - df;
            }
            return x;
        }

        #endregion
    }
}
