﻿/*
MIT License

Copyright(c) 2020 Kyle Givler
https://github.com/JoyfulReaper

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.
*/

using System;

namespace Fractions
{
    public static class FractionHelper
    {
        /// <summary>
        /// Return the number of places after the decimal point
        /// </summary>
        /// <param name="model">The FractionModel to check</param>
        /// <returns>The number of places after the decimal point</returns>
        public static int NumberOfDecimalPlaces(FractionModel model)
        {
            decimal number = decimal.Divide(model.Numerator, model.Denominator);

            return NumberOfDecimalPlaces(number);
        }

        /// <summary>
        /// Return the number of places after the decimal point
        /// </summary>
        /// <param name="d">The decimal to check</param>
        /// <returns>The number of places after the decimal point</returns>
        public static int NumberOfDecimalPlaces(decimal d)
        {
            string[] digits = d.ToString().Split('.');

            if (digits.Length != 2)
            {
                return 0;
            }

            return digits[1].Length;
        }

        /// <summary>
        /// Finds the greatest common divisor of a fraction
        /// </summary>
        /// <param name="model">The fraction model to find the GCD of</param>
        /// <returns>The greatest common divisor</returns>
        public static ulong FindGreatestCommonDivisor(FractionModel model)
        {
            return FindGreatestCommonDivisor((ulong)model.Denominator, (ulong)model.Numerator);
        }

        /// <summary>
        /// Finds the greatest common divisor of two positive numbers
        /// </summary>
        /// <param name="a">First number</param>
        /// <param name="b">Second number</param>
        /// <returns>The greatest Common Divisor</returns>
        public static ulong FindGreatestCommonDivisor(ulong a, ulong b)
        {
            //Euclid's algorithm
            while (a != 0 && b != 0)
            {
                if (a > b)
                    a %= b;
                else
                    b %= a;
            }

            return a | b;
        }

        /// <summary>
        /// Convert a decimal to a fraction
        /// </summary>
        /// <param name="d">The decimal to convert</param>
        /// <returns>The decimal represented as a fraction</returns>
        public static FractionModel ConvertDecimalToFraction(decimal d)
        {
            double decimalPlaces = NumberOfDecimalPlaces(d);
            int multiplier = (int) Math.Pow(10, decimalPlaces);

            FractionModel fraction = new FractionModel((int)(d * multiplier), multiplier);

            ReduceFraction(fraction);

            return fraction;
        }

        /// <summary>
        /// Reduce a fraction
        /// </summary>
        /// <param name="m">The fraction to reduce</param>
        public static void ReduceFraction(FractionModel m)
        {
            ulong gcd = FindGreatestCommonDivisor(m);
            m.Denominator /= (int)gcd;
            m.Numerator /= (int)gcd;
        }
    }
}
