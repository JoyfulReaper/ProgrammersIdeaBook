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
                Title = StringHelper.AssignNullIfEmpty(textTitle.Text),
                Description = StringHelper.AssignNullIfEmpty(textDesc.Text),
                Link = StringHelper.AssignNullIfEmpty(textLink.Text),
                Copyright = StringHelper.AssignNullIfEmpty(textCopyright.Text),
                ManagingEditor = StringHelper.AssignNullIfEmpty(textEditor.Text),
                WebMaster = StringHelper.AssignNullIfEmpty(textWebmaster.Text)
            };

            if (!ValidateRequiredFields(channel))
            {
                return;
            }

            _parent.SetChannel(channel);
            this.Close();
        }

        private bool ValidateRequiredFields(Channel channel)
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

            if(!UrlValidator.ValidateUrl(channel.Link))
            {
                message += "Link Url is not valid!";
            }

            if (message != String.Empty)
            {
                MessageBox.Show(message);
                return false;
            }

            return true;
        }

        private void textEditor_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
