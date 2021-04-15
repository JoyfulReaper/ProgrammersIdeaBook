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
            XmlHelper.SerializeXml(_rss);

            MessageBox.Show("Done!");
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            if (!ValidateRequiredFields())
            {
                return;
            }

            Item item = new Item()
            {
                Title = StringHelper.AssignNullIfEmpty(textTitle.Text),
                Description = StringHelper.AssignNullIfEmpty(textDesc.Text),
                Link = StringHelper.AssignNullIfEmpty(textLink.Text),
                Guid = StringHelper.AssignNullIfEmpty(textLink.Text)
            };

            _rss.Channel.Items.Add(item);
            _items.Add(item);

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
            _rss.Channel.Items.Remove(selectedItem);
        }
    }
}
