/*
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
    public class FractionModel
    {
        /// <summary>
        /// Represents a fraction's Numerator
        /// </summary>
        public int Numerator { get; set; }

        /// <summary>
        /// Represents a fraction's Denominator
        /// </summary>
        public int Denominator { get; set; }

        /// <summary>
        /// Construct a new Fraction Model
        /// </summary>
        /// <param name="numerator">Initial numerator</param>
        /// <param name="denominator">Inital denominator</param>
        public FractionModel(int numerator, int denominator)
        {
            if (denominator == 0)
            {
                throw new ArgumentOutOfRangeException("denominator cannot be zero.");
            }

            Numerator = numerator;
            Denominator = denominator;
        }

        public override string ToString()
        {
            return $"{Numerator}/{Denominator}";
        }

        // https://stackoverflow.com/questions/5360196/how-can-you-add-two-fractions By Jon
        public static implicit operator FractionModel(string value)
        {
            var tokens = value.Split('/');
            int num;
            int den;
            if (tokens.Length == 1 && int.TryParse(tokens[0], out num))
            {
                return new FractionModel(num, 1);
            }
            else if (tokens.Length == 2 && int.TryParse(tokens[0], out num) && int.TryParse(tokens[1], out den))
            {
                return new FractionModel(num, den);
            }
            throw new ArgumentException("Invalid fraction format");
        }
    }
}