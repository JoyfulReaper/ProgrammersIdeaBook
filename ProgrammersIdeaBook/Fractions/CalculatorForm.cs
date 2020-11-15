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
using System.ComponentModel;
using System.Diagnostics;
using System.Windows.Forms;

namespace Fractions
{
    public partial class CalculatorForm : Form
    {
        private BindingList<FractionModel> fractions = new BindingList<FractionModel>();
        private FractionModel mostRecentResult;

        public CalculatorForm()
        {
            InitializeComponent();

            listBoxFractions.DataSource = fractions;
            listBoxFractions.DisplayMember = nameof(FractionModel.Display);
        }

        private void buttonAdd_Click(object sender, System.EventArgs e)
        {
            if(textBoxFraction.Text.Length == 0 )
            {
                AddFromNumDemTextBoxes();
            }
            else
            {
                AddFromFractionTextBox();
            }

            textBoxFraction.Text = "";
            textBoxNumerator.Text = "";
            textBoxDenominator.Text = "";
        }

        private void AddFromFractionTextBox()
        {
            if (textBoxNumerator.Text.Length > 0 || textBoxDenominator.Text.Length > 0)
            {
                MessageBox.Show("Please use only one method of creating a fraction at a time!");
                return;
            }
            FractionModel res;

            if (FractionModel.TryParse(textBoxFraction.Text, out res))
            {
                fractions.Add(res);
            }
            else
            {
                MessageBox.Show("Please enter a valid fraction");
            }
        }

        private void AddFromNumDemTextBoxes()
        {
            int numerator;
            int denominator;

            if (!int.TryParse(textBoxNumerator.Text, out numerator))
            {
                MessageBox.Show("Please enter a valid numerator!");
                textBoxNumerator.Text = "";
                return;
            }
            if (!int.TryParse(textBoxDenominator.Text, out denominator) || denominator == 0)
            {
                MessageBox.Show("Please enter a valid denominator!");
                textBoxDenominator.Text = "";
                return;
            }

            FractionModel fraction = new FractionModel(numerator, denominator);
            fractions.Add(fraction);
        }

        private void buttonCalculate_Click(object sender, System.EventArgs e)
        {
            if(fractions.Count < 2)
            {
                MessageBox.Show("Please add a least two fractions first.");
                return;
            }

            FractionModel res = fractions[0];

            for (int i = 1; i < fractions.Count; i++)
            {
                if (radioAdd.Checked)
                {
                    res += fractions[i];
                }
                else if (radioSubtract.Checked)
                {
                    res -= fractions[i];
                }
                else if (radioMultiple.Checked)
                {
                    res *= fractions[i];
                }
                else if (radioDivide.Checked)
                {
                    res /= fractions[i];
                } 
            }

            mostRecentResult = res;

            lblResults.Visible = true;
            lblResults.Text = $"Result: { res }";
            buttonAddResult.Visible = true;
        }

        private void buttonClear_Click(object sender, System.EventArgs e)
        {
            fractions.Clear();
        }

        private void buttonDelete_Click(object sender, System.EventArgs e)
        {
            if(listBoxFractions.SelectedItem != null)
            {
                fractions.Remove((FractionModel)listBoxFractions.SelectedItem);
            }
        }

        private void buttonSimplify_Click(object sender, System.EventArgs e)
        {
            FractionModel f = (FractionModel)listBoxFractions.SelectedItem;
            if (listBoxFractions.SelectedItem != null)
            {
                f.Simplify();
                fractions.ResetBindings();
            }
        }

        private void buttonAddResult_Click(object sender, EventArgs e)
        {
            fractions.Add(mostRecentResult);
        }

        private void linkLabelGithub_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(new ProcessStartInfo("https://github.com/JoyfulReaper") { UseShellExecute = true });
        }
    }
}
