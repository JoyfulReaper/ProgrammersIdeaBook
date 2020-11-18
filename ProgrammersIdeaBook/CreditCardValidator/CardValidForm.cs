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
using System.Windows.Forms;
using System.Collections.Generic;

namespace CreditCardValidator
{
    public partial class frmLuhnChecker : Form
    {
        List<string> options = PopulateOptions();

        public frmLuhnChecker()
        {
            InitializeComponent();

            comboBoxType.DataSource = options;
        }

        private static List<string> PopulateOptions()
        {
            return new List<string> { "Luhn Check", "Visa" };
        }

        private void buttonValidate_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(textBoxCardNumber.Text))
            {
                MessageBox.Show("Please enter a valid number!");
                return;
            }

            bool valid = false;

            switch((string)comboBoxType.SelectedItem)
            {
                case "Luhn Check":
                    valid = LuhnChecker.LuhnValidate(textBoxCardNumber.Text);
                    break;
                case "Visa":
                    valid = LuhnChecker.LuhnValidate(textBoxCardNumber.Text, LuhnChecker.checkType.Visa);
                    break;
                default:
                    throw new Exception("Something went wrong!");
            }

            MessageBox.Show(valid ? "Valid" : "Not Valid");
        }

        private void buttonComputeCheck_Click(object sender, EventArgs e)
        {
            MessageBox.Show(LuhnChecker.LuhnCreate(textBoxCardNumber.Text, out _).ToString());
        }
    }
}
