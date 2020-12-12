using System;
using System.Collections.Generic;
using System.Text;

namespace CheckIfPalindrome
{
    public class TextHelper
    {
        /// <summary>
        /// Reverse a string (Just use a library function not this... This was made for a "challenge")
        /// </summary>
        /// <param name="input">The string to reverse</param>
        /// <returns>Input reversed</returns>
        public static string Reverse(string input)
        {
            StringBuilder sb = new StringBuilder();

            for(int i = input.Length - 1; i >= 0; i--)
            {
                sb.Append(input[i]);
            }

            return sb.ToString();
        }

        public static bool isPalindrome(string input)
        {
            input = input.Replace(" ", string.Empty).ToUpperInvariant();

            return input == Reverse(input).ToUpperInvariant();
        }
    }
}
