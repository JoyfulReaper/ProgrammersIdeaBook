
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
            this.btnAddChannel = new System.Windows.Forms.Button();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.listEntries = new System.Windows.Forms.ListBox();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.textChannel = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUp = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
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
            // btnAddChannel
            // 
            this.btnAddChannel.Location = new System.Drawing.Point(477, 56);
            this.btnAddChannel.Name = "btnAddChannel";
            this.btnAddChannel.Size = new System.Drawing.Size(75, 29);
            this.btnAddChannel.TabIndex = 17;
            this.btnAddChannel.Text = "Setup";
            this.btnAddChannel.UseVisualStyleBackColor = true;
            this.btnAddChannel.Click += new System.EventHandler(this.btnAddChannel_Click);
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(305, 290);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(97, 29);
            this.btnGenerate.TabIndex = 18;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // listEntries
            // 
            this.listEntries.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listEntries.FormattingEnabled = true;
            this.listEntries.ItemHeight = 17;
            this.listEntries.Location = new System.Drawing.Point(468, 91);
            this.listEntries.Name = "listEntries";
            this.listEntries.Size = new System.Drawing.Size(172, 191);
            this.listEntries.TabIndex = 19;
            this.listEntries.DoubleClick += new System.EventHandler(this.listEntries_DoubleClick);
            // 
            // btnAddItem
            // 
            this.btnAddItem.Location = new System.Drawing.Point(202, 290);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(97, 29);
            this.btnAddItem.TabIndex = 20;
            this.btnAddItem.Text = "Add";
            this.btnAddItem.UseVisualStyleBackColor = true;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // textChannel
            // 
            this.textChannel.Enabled = false;
            this.textChannel.Location = new System.Drawing.Point(87, 60);
            this.textChannel.Name = "textChannel";
            this.textChannel.Size = new System.Drawing.Size(369, 29);
            this.textChannel.TabIndex = 21;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(516, 290);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 29);
            this.btnDelete.TabIndex = 22;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUp
            // 
            this.btnUp.Location = new System.Drawing.Point(646, 92);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(40, 29);
            this.btnUp.TabIndex = 23;
            this.btnUp.Text = "^";
            this.btnUp.UseVisualStyleBackColor = true;
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(646, 122);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(40, 29);
            this.button1.TabIndex = 24;
            this.button1.Text = "v";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(696, 328);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnUp);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.textChannel);
            this.Controls.Add(this.btnAddItem);
            this.Controls.Add(this.listEntries);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.btnAddChannel);
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
            this.Load += new System.EventHandler(this.frmMain_Load);
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
        private System.Windows.Forms.Button btnAddChannel;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.ListBox listEntries;
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.TextBox textChannel;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.Button button1;
    }
}

