﻿
namespace RSSFeedCreator
{
    partial class frmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.textDesc = new System.Windows.Forms.TextBox();
            this.textLink = new System.Windows.Forms.TextBox();
            this.textTitle = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblLink = new System.Windows.Forms.Label();
            this.lblChanTittle = new System.Windows.Forms.Label();
            this.lblChannel = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnAddChannel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.Location = new System.Drawing.Point(12, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(137, 21);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "RSS Feed Creator";
            // 
            // textDesc
            // 
            this.textDesc.Location = new System.Drawing.Point(87, 191);
            this.textDesc.Multiline = true;
            this.textDesc.Name = "textDesc";
            this.textDesc.Size = new System.Drawing.Size(369, 81);
            this.textDesc.TabIndex = 13;
            // 
            // textLink
            // 
            this.textLink.Location = new System.Drawing.Point(87, 127);
            this.textLink.Name = "textLink";
            this.textLink.Size = new System.Drawing.Size(369, 29);
            this.textLink.TabIndex = 12;
            // 
            // textTitle
            // 
            this.textTitle.Location = new System.Drawing.Point(87, 92);
            this.textTitle.Name = "textTitle";
            this.textTitle.Size = new System.Drawing.Size(369, 29);
            this.textTitle.TabIndex = 11;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(7, 167);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(98, 21);
            this.lblDescription.TabIndex = 10;
            this.lblDescription.Text = "Description:";
            // 
            // lblLink
            // 
            this.lblLink.AutoSize = true;
            this.lblLink.Location = new System.Drawing.Point(7, 130);
            this.lblLink.Name = "lblLink";
            this.lblLink.Size = new System.Drawing.Size(44, 21);
            this.lblLink.TabIndex = 9;
            this.lblLink.Text = "Link:";
            // 
            // lblChanTittle
            // 
            this.lblChanTittle.AutoSize = true;
            this.lblChanTittle.Location = new System.Drawing.Point(7, 95);
            this.lblChanTittle.Name = "lblChanTittle";
            this.lblChanTittle.Size = new System.Drawing.Size(46, 21);
            this.lblChanTittle.TabIndex = 8;
            this.lblChanTittle.Text = "Title:";
            // 
            // lblChannel
            // 
            this.lblChannel.AutoSize = true;
            this.lblChannel.Location = new System.Drawing.Point(7, 60);
            this.lblChannel.Name = "lblChannel";
            this.lblChannel.Size = new System.Drawing.Size(72, 21);
            this.lblChannel.TabIndex = 14;
            this.lblChannel.Text = "Channel:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(87, 57);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(369, 29);
            this.comboBox1.TabIndex = 16;
            // 
            // btnAddChannel
            // 
            this.btnAddChannel.Location = new System.Drawing.Point(477, 56);
            this.btnAddChannel.Name = "btnAddChannel";
            this.btnAddChannel.Size = new System.Drawing.Size(75, 29);
            this.btnAddChannel.TabIndex = 17;
            this.btnAddChannel.Text = "Add";
            this.btnAddChannel.UseVisualStyleBackColor = true;
            this.btnAddChannel.Click += new System.EventHandler(this.btnAddChannel_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(600, 318);
            this.Controls.Add(this.btnAddChannel);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lblChannel);
            this.Controls.Add(this.textDesc);
            this.Controls.Add(this.textLink);
            this.Controls.Add(this.textTitle);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblLink);
            this.Controls.Add(this.lblChanTittle);
            this.Controls.Add(this.lblTitle);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.DodgerBlue;
            this.Name = "frmMain";
            this.Text = "RSS Feed Creator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox textDesc;
        private System.Windows.Forms.TextBox textLink;
        private System.Windows.Forms.TextBox textTitle;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblLink;
        private System.Windows.Forms.Label lblChanTittle;
        private System.Windows.Forms.Label lblChannel;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnAddChannel;
    }
}
