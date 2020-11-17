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

using System.Collections.Generic;

namespace ChangeReturnProgram
{
    public static class CurrencyHelper
    {
        public static Dictionary<CurrencyUnit, int> CalculateChange(decimal totalChange, List<CurrencyUnit> currencyUnits)
        {
            Dictionary<CurrencyUnit, int> change = new Dictionary<CurrencyUnit, int>();

            foreach (var currencyUnit in currencyUnits)
            {
                int count;

                count = (int)(totalChange / currencyUnit.Value);
                change.Add(currencyUnit, count);
                totalChange %= currencyUnit.Value;
            }

            return change;
        }

        public static List<CurrencyUnit> GetUSDCommonCoins()
        {
            List<CurrencyUnit> coins = new List<CurrencyUnit>();

            coins.Add(new CurrencyUnit(0.25m, "quarter"));
            coins.Add(new CurrencyUnit(0.10m, "dime"));
            coins.Add(new CurrencyUnit(0.05m, "nickel"));
            coins.Add(new CurrencyUnit(0.01m, "penny", "pennies"));

            return coins;
        }

        public static List<CurrencyUnit> GetUSDCommonBills()
        {
            List<CurrencyUnit> bills = new List<CurrencyUnit>();

            bills.Add(new CurrencyUnit(1.00m, "one dollar bill"));
            bills.Add(new CurrencyUnit(5.00m, "five dollar bill"));
            bills.Add(new CurrencyUnit(10.00m, "ten dollar bill"));
            bills.Add(new CurrencyUnit(20.00m, "twenty dollar bill"));
            bills.Add(new CurrencyUnit(50.00m, "fifty dollar bill"));
            bills.Add(new CurrencyUnit(100.00m, "one hundred dollar bill"));

            return bills;
        }
    }
}
