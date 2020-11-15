using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace Fractions
{
    public partial class CalculatorForm : Form
    {
        private BindingList<FractionModel> fractions = new BindingList<FractionModel>();
        public CalculatorForm()
        {
            InitializeComponent();

            listBoxFractions.DataSource = fractions;
            listBoxFractions.DisplayMember = nameof(FractionModel.Display);
        }

        private void buttonAdd_Click(object sender, System.EventArgs e)
        {
            int numerator;
            int denominator;

            if(!int.TryParse(textBoxNumerator.Text, out numerator))
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

            textBoxNumerator.Text = "";
            textBoxDenominator.Text = "";
        }

        private void buttonCalculate_Click(object sender, System.EventArgs e)
        {
            if(fractions.Count < 2)
            {
                MessageBox.Show("Please add a least two fractions first.");
                return;
            }

            FractionModel res = new FractionModel(0, 1);

            if(radioAdd.Checked)
            {

            }
            else if(radioSubtract.Checked)
            {

            }
            else if (radioMultiple.Checked)
            {

            }
            else if(radioDivide.Checked)
            {

            }
        }
    }
}
