﻿/*
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
using System.Media;
using System.Windows.Forms;

// TODO Do something about the duplicated code in the button events. 

namespace ChangeReturnProgram
{
    public partial class FormVending : Form
    {
        private readonly List<Product> products = new List<Product>();
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
            buttonProduct3.Text = $"{products[2].Name}\n{products[2].Price}";
            buttonProduct4.Text = $"{products[3].Name}\n{products[3].Price}";
        }

        private void CreateProducts()
        {
            products.Add(new Product("Lemon Soda", 1.75m));
            products.Add(new Product("Tomato Juice", 2.75m));
            products.Add(new Product("Yummy snack", 2.99m));
            products.Add(new Product("Healthy snack", 5.15m));
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
            PlayWavSound(Properties.Resources.coin);
            UpdateCredit();
        }

        private void buttonQuarter_Click(object sender, EventArgs e)
        {
            credit += 0.25m;
            PlayWavSound(Properties.Resources.coin);
            UpdateCredit();
        }

        private void buttonDime_Click(object sender, EventArgs e)
        {
            credit += 0.10m;
            PlayWavSound(Properties.Resources.coin);
            UpdateCredit();
        }

        private void buttonNickel_Click(object sender, EventArgs e)
        {
            credit += 0.05m;
            PlayWavSound(Properties.Resources.coin);
            UpdateCredit();
        }

        private void buttonPenny_Click(object sender, EventArgs e)
        {
            credit += 0.01m;
            PlayWavSound(Properties.Resources.coin);
            UpdateCredit();
        }

        private void UpdateCredit()
        {
            ToggleChangeVisible(false);
            lblCredit.Text = $"Credit {credit:C2}";
        }

        private static void PlayWavSound(UnmanagedMemoryStream res)
        {
            Stream stream = res;
            SoundPlayer soundplayer = new SoundPlayer(stream);
            soundplayer.Play();
        }

        private void buttonProduct1_Click(object sender, EventArgs e)
        {
            BuyProduct(0);
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
            int remaining = (int)(unusedCredit * 100); // Cents remaining
            int quarters;
            int dimes;
            int nickels;
            int pennies;

            quarters = remaining / 25;
            remaining -= quarters * 25;

            dimes = remaining / 10;
            remaining -= dimes * 10;

            nickels = remaining / 5;
            remaining -= nickels * 5;

            pennies = remaining / 1;

            credit = 0;
            UpdateCredit();

            ToggleChangeVisible(true);

            lblQuaters.Text = "Quaters: " + quarters.ToString();
            lblDimes.Text = "Dimes: " + dimes.ToString();
            lblNickels.Text = "Nickels: " + nickels.ToString();
            lblPennies.Text = "Pennies: " + pennies.ToString();
        }

        private void ToggleChangeVisible(bool visible)
        {
            lblChange.Visible = visible;
            lblQuaters.Visible = visible;
            lblDimes.Visible = visible;
            lblNickels.Visible = visible;
            lblPennies.Visible = visible;
        }

        private void buttonProduct2_Click(object sender, EventArgs e)
        {
            BuyProduct(1);
        }

        private void buttonProduct3_Click(object sender, EventArgs e)
        {
            BuyProduct(2);
        }

        private void buttonProduct4_Click(object sender, EventArgs e)
        {
            BuyProduct(3);
        }

        private void linkLabelGitHub_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(new ProcessStartInfo("https://github.com/JoyfulReaper") { UseShellExecute = true });
        }
    }
}
