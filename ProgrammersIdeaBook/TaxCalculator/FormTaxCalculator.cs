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

using System.ComponentModel;
using System.Diagnostics;
using System.Windows.Forms;

namespace TaxCalculator
{
    public partial class FormTaxCalculator : Form
    {
        private readonly BindingList<ItemModel> items = new BindingList<ItemModel>();

        public FormTaxCalculator()
        {
            InitializeComponent();

            listBoxItems.DataSource = items;
            listBoxItems.DisplayMember = nameof(ItemModel.Display);
        }

        private void linkLabelGitHub_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(new ProcessStartInfo("https://github.com/JoyfulReaper") { UseShellExecute = true });
        }

        private void buttonAdd_Click(object sender, System.EventArgs e)
        {
            if(!ValidateAddItems())
            {
                return;
            }

            ItemModel item = new ItemModel(textBoxName.Text, decimal.Parse(textBoxPrice.Text), checkBoxTaxable.Checked);
            items.Add(item);

            textBoxPrice.Text = "";
            textBoxName.Text = "";
        }

        private bool ValidateAddItems()
        {
            if (textBoxName.Text == "" || textBoxPrice.Text == "")
            {
                MessageBox.Show("Please fill both the name and the price of the item!");
                return false;
            }

            if (!decimal.TryParse(textBoxPrice.Text, out _))
            {
                MessageBox.Show("Price must be a valid number!");
                return false;
            }

            return true;
        }

        private void buttonRemove_Click(object sender, System.EventArgs e)
        {
            ItemModel selected = (ItemModel) listBoxItems.SelectedItem;

            if(selected != null)
            {
                items.Remove(selected);
            }
        }

        private void buttonAdd_Calculate(object sender, System.EventArgs e)
        {
            decimal taxRate;
            decimal total = 0;
            decimal subtotal = 0;
            decimal taxTotal = 0;

            if (!decimal.TryParse(textBoxTaxRate.Text, out taxRate))
            {
                MessageBox.Show("Please enter a valid tax rate!");
                return;
            }

            if(items.Count < 1)
            {
                MessageBox.Show("Please add at least one item first!");
                return;
            }

            taxRate = decimal.Divide(taxRate, 100);

            foreach (var item in items)
            {
                decimal tax = 0;

                subtotal += item.Price;
                if(item.Taxable)
                {
                    tax = item.Price * taxRate;
                    taxTotal += tax;
                    total += item.Price + tax;
                }
                else
                {
                    total += item.Price;
                }
            }

            MessageBox.Show($"Subtotal: {subtotal:C2}\n Total: {total:C2}\n Tax: {taxTotal:C2}");
        }

        private void buttonClear_Click(object sender, System.EventArgs e)
        {
            items.Clear();
        }
    }
}
