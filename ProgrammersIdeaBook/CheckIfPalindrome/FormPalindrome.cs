using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheckIfPalindrome
{
    public partial class FormPalindromeCheker : Form
    {
        public FormPalindromeCheker()
        {
            InitializeComponent();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            var message = $"{textBoxInput.Text} {(TextHelper.isPalindrome(textBoxInput.Text) ? "is" : "is not")} a palindrome";
            MessageBox.Show(message);

            textBoxInput.Text = "";
        }
    }
}
