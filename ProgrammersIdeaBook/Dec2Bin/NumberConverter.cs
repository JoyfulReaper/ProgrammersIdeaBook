namespace Dec2Bin
{
    public static class NumberConverter
    {
        public static string DecToBin(int number)
        {
            string result = string.Empty;
            while (number > 0)
            {
                result = number % 2 + result;
                number /= 2;
            }

            return result == "" ? "0" : result;
        }

        public static int BinToDec(string number)
        {
            if (!int.TryParse(number, out _))
            {
                throw new ArgumentException(nameof(number) + " could not be converted to an integer!");
            }

            int result = 0;
            int place = 0;
            for (int i = number.Length - 1; i >= 0; i--)
            {
                var curr = int.Parse(number[i].ToString());
                if (curr == 1)
                {
                    result = result + (int)Math.Pow(2, place);
                }
                place++;
            }

            return result;
        }
    }
}
