
namespace RSSFeedCreator
{
    partial class frmChannel
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblChanTittle = new System.Windows.Forms.Label();
            this.lblLink = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.textTitle = new System.Windows.Forms.TextBox();
            this.textLink = new System.Windows.Forms.TextBox();
            this.textDesc = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.textCopyright = new System.Windows.Forms.TextBox();
            this.lblCopyright = new System.Windows.Forms.Label();
            this.textWebmaster = new System.Windows.Forms.TextBox();
            this.lblWebmaster = new System.Windows.Forms.Label();
            this.textEditor = new System.Windows.Forms.TextBox();
            this.lblEditor = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.Location = new System.Drawing.Point(202, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(127, 25);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Add Channel:";
            // 
            // lblChanTittle
            // 
            this.lblChanTittle.AutoSize = true;
            this.lblChanTittle.Location = new System.Drawing.Point(-2, 46);
            this.lblChanTittle.Name = "lblChanTittle";
            this.lblChanTittle.Size = new System.Drawing.Size(46, 21);
            this.lblChanTittle.TabIndex = 1;
            this.lblChanTittle.Text = "Title:";
            // 
            // lblLink
            // 
            this.lblLink.AutoSize = true;
            this.lblLink.Location = new System.Drawing.Point(0, 81);
            this.lblLink.Name = "lblLink";
            this.lblLink.Size = new System.Drawing.Size(44, 21);
            this.lblLink.TabIndex = 2;
            this.lblLink.Text = "Link:";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(1, 245);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(98, 21);
            this.lblDescription.TabIndex = 3;
            this.lblDescription.Text = "Description:";
            // 
            // textTitle
            // 
            this.textTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textTitle.Location = new System.Drawing.Point(100, 43);
            this.textTitle.Name = "textTitle";
            this.textTitle.Size = new System.Drawing.Size(369, 29);
            this.textTitle.TabIndex = 0;
            // 
            // textLink
            // 
            this.textLink.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textLink.Location = new System.Drawing.Point(100, 78);
            this.textLink.Name = "textLink";
            this.textLink.Size = new System.Drawing.Size(369, 29);
            this.textLink.TabIndex = 1;
            // 
            // textDesc
            // 
            this.textDesc.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textDesc.Location = new System.Drawing.Point(81, 269);
            this.textDesc.Multiline = true;
            this.textDesc.Name = "textDesc";
            this.textDesc.Size = new System.Drawing.Size(369, 81);
            this.textDesc.TabIndex = 5;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(222, 356);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(99, 39);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // textCopyright
            // 
            this.textCopyright.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textCopyright.Location = new System.Drawing.Point(100, 116);
            this.textCopyright.Name = "textCopyright";
            this.textCopyright.Size = new System.Drawing.Size(369, 29);
            this.textCopyright.TabIndex = 2;
            // 
            // lblCopyright
            // 
            this.lblCopyright.AutoSize = true;
            this.lblCopyright.Location = new System.Drawing.Point(0, 119);
            this.lblCopyright.Name = "lblCopyright";
            this.lblCopyright.Size = new System.Drawing.Size(87, 21);
            this.lblCopyright.TabIndex = 8;
            this.lblCopyright.Text = "Copyright:";
            // 
            // textWebmaster
            // 
            this.textWebmaster.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textWebmaster.Location = new System.Drawing.Point(102, 196);
            this.textWebmaster.Name = "textWebmaster";
            this.textWebmaster.Size = new System.Drawing.Size(369, 29);
            this.textWebmaster.TabIndex = 4;
            // 
            // lblWebmaster
            // 
            this.lblWebmaster.AutoSize = true;
            this.lblWebmaster.Location = new System.Drawing.Point(0, 199);
            this.lblWebmaster.Name = "lblWebmaster";
            this.lblWebmaster.Size = new System.Drawing.Size(99, 21);
            this.lblWebmaster.TabIndex = 12;
            this.lblWebmaster.Text = "Webmaster:";
            // 
            // textEditor
            // 
            this.textEditor.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textEditor.Location = new System.Drawing.Point(102, 158);
            this.textEditor.Name = "textEditor";
            this.textEditor.Size = new System.Drawing.Size(369, 29);
            this.textEditor.TabIndex = 3;
            this.textEditor.TextChanged += new System.EventHandler(this.textEditor_TextChanged);
            // 
            // lblEditor
            // 
            this.lblEditor.AutoSize = true;
            this.lblEditor.Location = new System.Drawing.Point(0, 161);
            this.lblEditor.Name = "lblEditor";
            this.lblEditor.Size = new System.Drawing.Size(59, 21);
            this.lblEditor.TabIndex = 10;
            this.lblEditor.Text = "Editor:";
            // 
            // frmChannel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(530, 406);
            this.Controls.Add(this.textWebmaster);
            this.Controls.Add(this.lblWebmaster);
            this.Controls.Add(this.textEditor);
            this.Controls.Add(this.lblEditor);
            this.Controls.Add(this.textCopyright);
            this.Controls.Add(this.lblCopyright);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.textDesc);
            this.Controls.Add(this.textLink);
            this.Controls.Add(this.textTitle);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblLink);
            this.Controls.Add(this.lblChanTittle);
            this.Controls.Add(this.lblTitle);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.DodgerBlue;
            this.Name = "frmChannel";
            this.Text = "Channel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblChanTittle;
        private System.Windows.Forms.Label lblLink;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox textTitle;
        private System.Windows.Forms.TextBox textLink;
        private System.Windows.Forms.TextBox textDesc;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox textCopyright;
        private System.Windows.Forms.Label lblCopyright;
        private System.Windows.Forms.TextBox textWebmaster;
        private System.Windows.Forms.Label lblWebmaster;
        private System.Windows.Forms.TextBox textEditor;
        private System.Windows.Forms.Label lblEditor;
    }
}