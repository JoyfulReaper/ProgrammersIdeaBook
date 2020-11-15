using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ChangeReturnProgram
{
    public partial class FormVending : Form
    {
        private List<Product> products = new List<Product>();
        private decimal credit;

        public FormVending()
        {
            InitializeComponent();
            CreateProducts();
            UpdateButtons();
        }

        private void UpdateButtons()
        {
            buttonProduct1.Text = $"{products[0].Name}\n{products[0].Price}";
            buttonProduct2.Text = $"{products[1].Name}\n{products[1].Price}";
        }

        private void CreateProducts()
        {
            products.Add(new Product("Lemon Soda", 1.50m));
            products.Add(new Product("Yummy snack", 3.00m));
        }

        private void buttonProduct_MouseEnter(object sender, EventArgs e)
        {
             Button x = (Button)sender;
            x.Image = Properties.Resources.button2;
        }

        private void buttonProduct_MouseLeave(object sender, EventArgs e)
        {
            Button x = (Button)sender;
            x.Image = Properties.Resources.button;
        }

        private void buttonDollar_Click(object sender, EventArgs e)
        {
            credit += 1.00m;
            UpdateCredit();
        }

        private void buttonQuarter_Click(object sender, EventArgs e)
        {
            credit += 0.25m;
            UpdateCredit();
        }

        private void buttonDime_Click(object sender, EventArgs e)
        {
            credit += 0.10m;
            UpdateCredit();
        }

        private void buttonNickel_Click(object sender, EventArgs e)
        {
            credit += 0.05m;
            UpdateCredit();
        }

        private void buttonPenny_Click(object sender, EventArgs e)
        {
            credit += 0.01m;
            UpdateCredit();
        }

        private void UpdateCredit()
        {
            lblCredit.Text = $"Credit {credit:C2}";
        }
    }
}
