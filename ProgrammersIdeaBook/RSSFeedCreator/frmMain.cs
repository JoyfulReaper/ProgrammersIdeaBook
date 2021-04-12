using RSSFeedCreator.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RSSFeedCreator
{
    public partial class frmMain : Form
    {
        private readonly BindingList<Channel> _channels = new BindingList<Channel>();
        private readonly BindingList<Item> _items = new BindingList<Item>();

        public frmMain()
        {
            InitializeComponent();

            comboChannel.DataSource = _channels;
            comboChannel.DisplayMember = nameof(Channel.Title);

            listEntries.DataSource = _items;
            listEntries.DisplayMember = nameof(Item.Title);
        }

        private void btnAddChannel_Click(object sender, EventArgs e)
        {
            frmChannel frmChannel = new frmChannel(this);
            frmChannel.ShowDialog(this);
        }

        public void AddChannel(Channel channel)
        {
            _channels.Add(channel);
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            FeedGenerator generator = new FeedGenerator();
            generator.GenerateXML(_channels.ToList());
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            Channel channel = (Channel)comboChannel.SelectedItem;

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

            channel.Items.Add(item);
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
