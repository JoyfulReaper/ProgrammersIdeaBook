using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ChangeReturnProgram
{
    public partial class FormProducts : Form
    {
        private IProductListRequester callingForm;
        private List<Product> products;
        private List<TextBox> productNames = new List<TextBox>();
        private List<TextBox> productPrices = new List<TextBox>();

        public FormProducts(IProductListRequester caller, List<Product> products)
        {
            InitializeComponent();

            this.callingForm = caller;
            this.products = products;

            AddTextBoxesToLists();

            PopulateProducts();
        }

        private void AddTextBoxesToLists()
        {
            productNames.Add(productName1);
            productNames.Add(productName2);
            productNames.Add(productName3);
            productNames.Add(productName4);

            productPrices.Add(productPrice1);
            productPrices.Add(productPrice2);
            productPrices.Add(productPrice3);
            productPrices.Add(productPrice4);
        }

        private void PopulateProducts()
        {
            for (int i = 0; i < 4; i++)
            {
                productNames[i].Text = products[i].Name;
                productPrices[i].Text = products[i].Price.ToString();
            }
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            products.Clear();

            for(int i = 0; i < 4; i++)
            {
                Product p = new Product("Out Of Stock", 0);
                
                if(productNames[i].Text != "")
                {
                    p.Name = productNames[i].Text;
                }

                if(decimal.TryParse(productPrices[i].Text, out decimal price) && price > 0)
                {
                    p.Price = price;
                }

                products.Add(p);
            }

            callingForm.ProductsUpdates(products);

            this.Close();
        }
    }
}
