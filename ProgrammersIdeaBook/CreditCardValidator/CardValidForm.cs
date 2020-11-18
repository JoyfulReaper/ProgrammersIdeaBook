using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CreditCardValidator
{
    public partial class frmLuhnChecker : Form
    {
        public frmLuhnChecker()
        {
            InitializeComponent();
        }

        private void buttonValidate_Click(object sender, EventArgs e)
        {
            var valid = LuhnChecker.LuhnValidate(textBoxCardNumber.Text);
            MessageBox.Show(valid.ToString());
        }

        private void buttonComputeCheck_Click(object sender, EventArgs e)
        {
            MessageBox.Show(LuhnChecker.LuhnCreate(textBoxCardNumber.Text, out _).ToString());
        }
    }
}
