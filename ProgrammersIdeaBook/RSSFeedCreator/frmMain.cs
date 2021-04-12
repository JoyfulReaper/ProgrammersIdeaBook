﻿using RSSFeedCreator.Models;
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

        public frmMain()
        {
            InitializeComponent();

            comboChannel.DataSource = _channels;
            comboChannel.DisplayMember = nameof(Channel.Title);
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

        }
    }
}
