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
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Media;
using System.Windows.Forms;

namespace ChangeReturnProgram
{
    public partial class FormVending : Form, IProductListRequester
    {
        private readonly Dictionary<Button, decimal> creditButtons = new Dictionary<Button, decimal>();
        private readonly Dictionary<Button, Product> productButtons = new Dictionary<Button, Product>();

        private readonly List<CurrencyUnit> coins = CurrencyHelper.GetUSDCommonCoins(); // TODO Associate credit buttons with CurrencyUnits

        private decimal credit;

        public FormVending()
        {
            InitializeComponent();

            CreateCreditButtonDictionary(); // Add crediting buttons to a dictionary with the value of the credit

            AssociateProductsToButtons(GetDemoProducts()); // Put name and price text on the buttons
            // TODO Save the products to a database or something!
        }

        private void CreateCreditButtonDictionary()
        {
            // Add the buttons to a dictionary
            creditButtons.Add(buttonDollar, 1.00m);
            creditButtons.Add(buttonQuarter, 0.25m);
            creditButtons.Add(buttonDime, 0.10m);
            creditButtons.Add(buttonNickel, 0.05m);
            creditButtons.Add(buttonPenny, 0.01m);
        }

        private void AssociateProductsToButtons(List<Product> products)
        {
            // Associate products to buttons
            if (productButtons.Count > 0)
            {
                productButtons.Clear();
            }

            productButtons.Add(buttonProduct1, products[0]);
            productButtons.Add(buttonProduct2, products[1]);
            productButtons.Add(buttonProduct3, products[2]);
            productButtons.Add(buttonProduct4, products[3]);

            UpdateButtonText();
        }

        private List<Product> GetDemoProducts()
        {
            List<Product> products = new List<Product>();

            products.Add(new Product("Lemon Soda", 1.75m));
            products.Add(new Product("Tomato Juice", 2.50m));
            products.Add(new Product("Yummy snack", 2.99m));
            products.Add(new Product("Healthy snack", 5.15m));

            return products;
        }

        private void UpdateButtonText()
        {
            foreach(var kvp in productButtons)
            {
                kvp.Key.Text = $"{kvp.Value.Name}\n{kvp.Value.Price}";
            }
        }

        private void buttonProduct_MouseEnter(object sender, EventArgs e)
        {
            // Change the image when mouse is over the button
            Button x = (Button)sender;
            x.Image = Properties.Resources.button2;
        }

        private void buttonProduct_MouseLeave(object sender, EventArgs e)
        {
            // Change back to normal when mouse no longer over button
            Button x = (Button)sender;
            x.Image = Properties.Resources.button;
        }

        // A button to credit an amount has been clicked
        // Lets add the credit!
        private void buttonCredit_Click(object sender, EventArgs e)
        {
            decimal creditAmount = creditButtons[(Button)sender];
            credit += creditAmount;
            PlayWavSound(Properties.Resources.coin);
            UpdateCredit();
        }

        private void buttonChangeProducts_Click(object sender, EventArgs e)
        {
            List<Product> products = new List<Product>();
            foreach (var b in productButtons)
            {
                products.Add(b.Value);
            }

            FormProducts frm = new FormProducts(this, products);
            frm.Show(this);
        }

        //Update label displaying the credit amount
        private void UpdateCredit()
        {
            ToggleChangeVisible(false);
            lblCredit.Text = $"Credit {credit:C2}";
        }

        // Play a sound
        private static void PlayWavSound(UnmanagedMemoryStream res)
        {
            Stream stream = res;
            SoundPlayer soundplayer = new SoundPlayer(stream);
            soundplayer.Play();
        }

        // A product button was pressed!
        private void buttonProduct_Click(object sender, EventArgs e)
        {
            Product p = productButtons[(Button)sender];
            BuyProduct(p);
        }

        private void BuyProduct(Product product)
        {
            decimal price = product.Price;

            if (credit >= price)
            {
                credit -= price;
                PlayWavSound(Properties.Resources.vend2);
                GiveChange(credit);
            }
            else
            {
                PlayWavSound(Properties.Resources.error);
            }
        }

        private void GiveChange(decimal unusedCredit)
        {
            var change = CurrencyHelper.CalculateChange(unusedCredit, coins);

            int quarters = change[coins.Where(x => x.Name == "quarter").First()];
            int dimes = change[coins.Where(x => x.Name == "dime").First()];
            int nickels = change[coins.Where(x => x.Name == "nickel").First()];
            int pennies = change[coins.Where(x => x.Name == "penny").First()];

            credit = 0;
            UpdateCredit();

            ToggleChangeVisible(true);

            lblChange.Text = "Total Change: " + unusedCredit;
            lblQuaters.Text = "Quaters: " + quarters;
            lblDimes.Text = "Dimes: " + dimes;
            lblNickels.Text = "Nickels: " + nickels;
            lblPennies.Text = "Pennies: " + pennies;
        }

        // Should we show the change labels?
        private void ToggleChangeVisible(bool visible)
        {
            lblChange.Visible = visible;
            lblQuaters.Visible = visible;
            lblDimes.Visible = visible;
            lblNickels.Visible = visible;
            lblPennies.Visible = visible;
        }

        // Go to my GitHub!! Awesome!
        private void linkLabelGitHub_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(new ProcessStartInfo("https://github.com/JoyfulReaper") { UseShellExecute = true });
        }

        public void ProductsUpdates(List<Product> products)
        {
            AssociateProductsToButtons(products);
        }
    }
}
