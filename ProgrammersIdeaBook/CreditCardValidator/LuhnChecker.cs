namespace CreditCardValidator
{
    public static class LuhnChecker
    {
        /// <summary>
        /// Validate the check digit using the Luhn Algorithm
        /// </summary>
        /// <param name="number">The number to validate as a string</param>
        /// <returns>True if check digit is valid, false otherwise</returns>
        public static bool LuhnValidate(string number)
        {
            var check = ComputeCheckDigit(number.Substring(0, number.Length - 1));
            var test = int.Parse(number.Substring(number.Length - 1));
            return check == test;
        }

        /// <summary>
        /// Adds the check digit to a number using the Lugn Algorithm
        /// </summary>
        /// <param name="number">The number to calculate the check digit of</param>
        /// <param name="checkDigit">The check digit</param>
        /// <returns></returns>
        public static string LuhnCreate(string number, out int checkDigit)
        {
            checkDigit = ComputeCheckDigit(number);
            return $"{number}{checkDigit}";
        }

        /// <summary>
        /// Compute the check digit for the given number using the Luhn Algorithm
        /// </summary>
        /// <param name="luhn">The number to computer the check digit for as a string</param>
        /// <returns>The check digit</returns>
        public static int ComputeCheckDigit(string number)
        {
            int nDigits = number.Length;
            int sum = 0;
            int parity = nDigits % 2;

            for (int i = 0; i < nDigits; i++)
            {
                int digit = int.Parse(number[i].ToString());

                if (i % 2 != parity)
                {
                    digit *= 2;
                }

                if (digit > 9)
                {
                    digit -= 9;
                }

                sum += digit;
            }

            return (sum * 9) % 10;
        }
    }
}
