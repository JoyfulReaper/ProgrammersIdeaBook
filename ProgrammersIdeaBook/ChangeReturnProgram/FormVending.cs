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

// TODO Do something about the duplicated code in the button events. 

namespace ChangeReturnProgram
{
    public partial class FormVending : Form
    {
        private readonly List<Product> products = new List<Product>();
        private readonly Dictionary<Button, decimal> creditButtons = new Dictionary<Button, decimal>();
        private readonly Dictionary<Button, int> ProductButtons = new Dictionary<Button, int>();
        private readonly List<CurrencyUnit> coins = CurrencyHelper.GetUSDCommonCoins();
        private decimal credit;

        public FormVending()
        {
            InitializeComponent();

            CreateProducts(); // Just add some demo products

            AssociateProductsToButtons(); // Put name and price text on the buttons

            CreateButtonDictionaries(); // Add the buttons to a Dictionary so we can use one even for all of them
        }

        private void CreateButtonDictionaries()
        {
            // Add the buttons to a dictionary
            creditButtons.Add(buttonDollar, 1.00m);
            creditButtons.Add(buttonQuarter, 0.25m);
            creditButtons.Add(buttonDime, 0.10m);
            creditButtons.Add(buttonNickel, 0.05m);
            creditButtons.Add(buttonPenny, 0.01m);

            ProductButtons.Add(buttonProduct1, 0);
            ProductButtons.Add(buttonProduct2, 1);
            ProductButtons.Add(buttonProduct3, 2);
            ProductButtons.Add(buttonProduct4, 3);
        }

        private void AssociateProductsToButtons()
        {
            //Put the product info on the buttons
            buttonProduct1.Text = $"{products[0].Name}\n{products[0].Price}";
            buttonProduct2.Text = $"{products[1].Name}\n{products[1].Price}";
            buttonProduct3.Text = $"{products[2].Name}\n{products[2].Price}";
            buttonProduct4.Text = $"{products[3].Name}\n{products[3].Price}";
        }

        private void CreateProducts()
        {
            // Create some demo products
            //TODO create product editor, maybe store the info in a DB
            products.Add(new Product("Lemon Soda", 1.75m));
            products.Add(new Product("Tomato Juice", 2.50m));
            products.Add(new Product("Yummy snack", 2.99m));
            products.Add(new Product("Healthy snack", 5.15m));
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
            int productToBuy = ProductButtons[(Button)sender];
            BuyProduct(productToBuy);
        }

        private void BuyProduct(int itemNumber)
        {
            decimal price = products[itemNumber].Price;

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

            lblQuaters.Text = "Quaters: " + quarters.ToString();
            lblDimes.Text = "Dimes: " + dimes.ToString();
            lblNickels.Text = "Nickels: " + nickels.ToString();
            lblPennies.Text = "Pennies: " + pennies.ToString();
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
    }
}
