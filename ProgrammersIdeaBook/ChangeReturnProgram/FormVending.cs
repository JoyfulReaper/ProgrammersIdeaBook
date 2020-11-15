using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ChangeReturnProgram
{
    public partial class FormVending : Form
    {
        private List<Product> products = new List<Product>();

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
    }
}
