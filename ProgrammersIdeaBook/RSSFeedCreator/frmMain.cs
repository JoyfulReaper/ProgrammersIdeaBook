/*
MIT License

Copyright(c) 2021 Kyle Givler
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

using RSSFeedCreator.Helpers;
using RSSFeedCreator.Models;
using System;
using System.ComponentModel;
using System.IO;
using System.Windows.Forms;

namespace RSSFeedCreator
{
    public partial class frmMain : Form
    {
        private Rss _rss = new Rss { Channel = new Channel() };
        private bool _editMode = false;
        private readonly BindingList<Item> _items = new BindingList<Item>();

        public frmMain()
        {
            InitializeComponent();
        }

        private void btnAddChannel_Click(object sender, EventArgs e)
        {
            frmChannel frmChannel = new frmChannel(this, _rss.Channel);
            frmChannel.ShowDialog(this);

            if(_rss.Channel != null)
            {
                textChannel.Text = _rss.Channel.Title;
            }
        }

        public void SetChannel(Channel channel)
        {
            _rss.Channel = channel;
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            _rss.Channel.Items.Clear();
            foreach(Item item in _items)
            {
                _rss.Channel.Items.Add(item);
            }

            XmlHelper.SerializeXml(_rss);

            if (_items.Count >= 10)
            {
                var generate = MessageBox.Show("It is not reccomended to have more than about 10 items in an RSS feed. Continue?",
                    "Warning",
                    MessageBoxButtons.YesNo);

                if (generate == DialogResult.No)
                {
                    return;
                }
            }

            MessageBox.Show("Done!");
            _items.Clear();

            LoadDataFromRss();
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            int index = 0;

            if (!ValidateRequiredFields())
            {
                return;
            }

            if(_editMode)
            {
                index = listEntries.SelectedIndex;
            }

            AddItem(index);
        }

        private void AddItem(int index)
        {
            Item item;

            if (_editMode)
            {
                btnAddItem.Text = "Add";
                _editMode = false;
            }

            item = new Item();
            SetupItem(item);

            _items.Insert(index, item);

            ClearTextBoxes();
        }

        private void EditItem(Item item)
        {
            _items.Remove(item);

            _editMode = true;
            btnAddItem.Text = "Update";
            PopulateTextBoxes(item);
        }

        private void PopulateTextBoxes(Item item)
        {
            textTitle.Text = item.Title;
            textDesc.Text = item.Description;
            textLink.Text = item.Link;
        }

        private Item SetupItem(Item item)
        {
            item.Title = StringHelper.AssignNullIfEmpty(textTitle.Text);
            item.Description = StringHelper.AssignNullIfEmpty(textDesc.Text);
            item.Link = StringHelper.AssignNullIfEmpty(textLink.Text);
            item.Guid = StringHelper.AssignNullIfEmpty(textLink.Text);

            return item;
        }

        private void ClearTextBoxes()
        {
            textTitle.Text = string.Empty;
            textLink.Text = string.Empty;
            textDesc.Text = string.Empty;
        }

        private bool ValidateRequiredFields()
        {
            string message = string.Empty;

            if (String.IsNullOrWhiteSpace(textTitle.Text))
            {
                message += "Title is required.\n";
            }

            if (String.IsNullOrWhiteSpace(textLink.Text))
            {
                message += "Link is required.\n";
            }

            if (!UrlValidator.ValidateUrl(textLink.Text))
            {
                message += "Link Url is not valid!";
            }

            if (String.IsNullOrWhiteSpace(textDesc.Text))
            {
                message += "Description is required.\n";
            }

            if (message != String.Empty)
            {
                MessageBox.Show(message);
                return false;
            }

            return true;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            listEntries.DataSource = _items;
            listEntries.DisplayMember = nameof(Item.Title);

            LoadDataFromRss();
        }

        private void LoadDataFromRss()
        {
            try
            {
                _rss = XmlHelper.DeserializeXml<Rss>("rss2.xml");
            }
            catch (FileNotFoundException)
            {
                _rss = null;
            }

            if (_rss != null)
            {
                foreach (var item in _rss.Channel.Items)
                {
                    _items.Add(item);
                }

                textChannel.Text = _rss.Channel.Title;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var selectedItem = (Item)listEntries.SelectedItem;
            if(selectedItem == null)
            {
                return;
            }

            _items.Remove(selectedItem);
        }

        private void listEntries_DoubleClick(object sender, EventArgs e)
        {
            var selectedItem = (Item)listEntries.SelectedItem;
            if (selectedItem == null)
            {
                return;
            }

            EditItem(selectedItem);
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            MoveItem(-1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MoveItem(1);
        }

        private void MoveItem(int direction)
        {
            Item selected = (Item)listEntries.SelectedItem;

            if (selected == null || listEntries.SelectedIndex < 0)
            {
                return;
            }

            int newIndex = listEntries.SelectedIndex + direction;

            if (newIndex < 0 || newIndex >= listEntries.Items.Count)
            {
                return;
            }

            _items.Remove(selected);
            _items.Insert(newIndex, selected);

            listEntries.ClearSelected();
            listEntries.SelectedIndex = newIndex;
        }
    }
}
