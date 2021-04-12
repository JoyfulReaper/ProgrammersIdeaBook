using RSSFeedCreator.Helpers;
using RSSFeedCreator.Models;
using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace RSSFeedCreator
{
    public partial class frmMain : Form
    {
        private Channel _channel = null;
        private readonly BindingList<Item> _items = new BindingList<Item>();

        public frmMain()
        {
            InitializeComponent();

            listEntries.DataSource = _items;
            listEntries.DisplayMember = nameof(Item.Title);
        }

        private void btnAddChannel_Click(object sender, EventArgs e)
        {
            frmChannel frmChannel = new frmChannel(this);
            frmChannel.ShowDialog(this);

            if(_channel != null)
            {
                textChannel.Text = _channel.Title;
            }
        }

        public void SetChannel(Channel channel)
        {
            _channel = channel;
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            FeedGenerator generator = new FeedGenerator();
            generator.GenerateXML(_channel);
            _items.Clear();

            MessageBox.Show("Done!");
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            Item item = new Item()
            {
                Title = textTitle.Text,
                Description = textDesc.Text,
                Link = textLink.Text,
                Guid = textLink.Text
            };

            if(!ValidateRequiredFields(item))
            {
                return;
            }

            _channel.Items.Add(item);
            _items.Add(item);

            textTitle.Text = string.Empty;
            textLink.Text = string.Empty;
            textDesc.Text = string.Empty;
        }

        private bool ValidateRequiredFields(Item item)
        {
            string message = string.Empty;

            if (String.IsNullOrWhiteSpace(item.Title))
            {
                message += "Title is required.\n";
            }

            if (String.IsNullOrWhiteSpace(item.Link))
            {
                message += "Link is required.\n";
            }

            if (!UrlValidator.ValidateUrl(item.Link))
            {
                message += "Link Url is not valid!";
            }

            if (String.IsNullOrWhiteSpace(item.Description))
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
    }
}
