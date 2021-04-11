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
    public partial class frmChannel : Form
    {
        private readonly frmMain _parent;

        public frmChannel(frmMain parent)
        {
            InitializeComponent();
            _parent = parent;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Channel channel = new Channel()
            {
                Title = textTitle.Text,
                Description = textDesc.Text,
                Link = textLink.Text,
                Copyright = textCopyright.Text,
                ManagingEditor = textEditor.Text,
                Webmaster = textWebmaster.Text
            };

            ValidateRequiredFields(channel);
        }

        private void ValidateRequiredFields(Channel channel)
        {
            string message = String.Empty;

            if(String.IsNullOrWhiteSpace(channel.Title))
            {
                message += "Title is required.\n";
            }

            if (String.IsNullOrWhiteSpace(channel.Description))
            {
                message += "Description is required.\n";
            }

            if (String.IsNullOrWhiteSpace(channel.Link))
            {
                message += "Link is required.\n";
            }

            if (message != String.Empty)
            {
                MessageBox.Show(message);
            }
        }
    }
}
