
namespace TaxCalculator
{
    partial class FormTaxCalculator
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
            this.listBoxItems = new System.Windows.Forms.ListBox();
            this.lblHeader = new System.Windows.Forms.Label();
            this.linkLabelGitHub = new System.Windows.Forms.LinkLabel();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.checkBoxTaxable = new System.Windows.Forms.CheckBox();
            this.groupBoxItem = new System.Windows.Forms.GroupBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.textBoxTaxRate = new System.Windows.Forms.TextBox();
            this.lblRate = new System.Windows.Forms.Label();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.lblPercent = new System.Windows.Forms.Label();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.groupBoxItem.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxItems
            // 
            this.listBoxItems.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listBoxItems.FormattingEnabled = true;
            this.listBoxItems.ItemHeight = 17;
            this.listBoxItems.Location = new System.Drawing.Point(12, 73);
            this.listBoxItems.Name = "listBoxItems";
            this.listBoxItems.Size = new System.Drawing.Size(244, 225);
            this.listBoxItems.TabIndex = 0;
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblHeader.Location = new System.Drawing.Point(13, 13);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(172, 32);
            this.lblHeader.TabIndex = 1;
            this.lblHeader.Text = "Tax Calculator";
            // 
            // linkLabelGitHub
            // 
            this.linkLabelGitHub.AutoSize = true;
            this.linkLabelGitHub.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.linkLabelGitHub.Location = new System.Drawing.Point(191, 25);
            this.linkLabelGitHub.Name = "linkLabelGitHub";
            this.linkLabelGitHub.Size = new System.Drawing.Size(204, 17);
            this.linkLabelGitHub.TabIndex = 2;
            this.linkLabelGitHub.TabStop = true;
            this.linkLabelGitHub.Text = "https://github.com/JoyfulReaper";
            this.linkLabelGitHub.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelGitHub_LinkClicked);
            // 
            // textBoxName
            // 
            this.textBoxName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxName.Location = new System.Drawing.Point(116, 32);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(100, 25);
            this.textBoxName.TabIndex = 0;
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxPrice.Location = new System.Drawing.Point(116, 71);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(100, 25);
            this.textBoxPrice.TabIndex = 1;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(6, 29);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(109, 25);
            this.lblName.TabIndex = 4;
            this.lblName.Text = "Item Name";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(6, 68);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(54, 25);
            this.lblPrice.TabIndex = 4;
            this.lblPrice.Text = "Price";
            // 
            // checkBoxTaxable
            // 
            this.checkBoxTaxable.AutoSize = true;
            this.checkBoxTaxable.Checked = true;
            this.checkBoxTaxable.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxTaxable.Location = new System.Drawing.Point(121, 104);
            this.checkBoxTaxable.Name = "checkBoxTaxable";
            this.checkBoxTaxable.Size = new System.Drawing.Size(95, 29);
            this.checkBoxTaxable.TabIndex = 2;
            this.checkBoxTaxable.Text = "Taxable";
            this.checkBoxTaxable.UseVisualStyleBackColor = true;
            // 
            // groupBoxItem
            // 
            this.groupBoxItem.Controls.Add(this.buttonAdd);
            this.groupBoxItem.Controls.Add(this.lblName);
            this.groupBoxItem.Controls.Add(this.checkBoxTaxable);
            this.groupBoxItem.Controls.Add(this.textBoxName);
            this.groupBoxItem.Controls.Add(this.lblPrice);
            this.groupBoxItem.Controls.Add(this.textBoxPrice);
            this.groupBoxItem.Location = new System.Drawing.Point(303, 73);
            this.groupBoxItem.Name = "groupBoxItem";
            this.groupBoxItem.Size = new System.Drawing.Size(237, 224);
            this.groupBoxItem.TabIndex = 6;
            this.groupBoxItem.TabStop = false;
            this.groupBoxItem.Text = "Add Item";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(58, 148);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(121, 50);
            this.buttonAdd.TabIndex = 4;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // textBoxTaxRate
            // 
            this.textBoxTaxRate.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxTaxRate.Location = new System.Drawing.Point(382, 319);
            this.textBoxTaxRate.Name = "textBoxTaxRate";
            this.textBoxTaxRate.Size = new System.Drawing.Size(41, 25);
            this.textBoxTaxRate.TabIndex = 7;
            // 
            // lblRate
            // 
            this.lblRate.AutoSize = true;
            this.lblRate.Location = new System.Drawing.Point(292, 316);
            this.lblRate.Name = "lblRate";
            this.lblRate.Size = new System.Drawing.Size(84, 25);
            this.lblRate.TabIndex = 8;
            this.lblRate.Text = "Tax Rate";
            // 
            // buttonRemove
            // 
            this.buttonRemove.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonRemove.Location = new System.Drawing.Point(12, 304);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(121, 50);
            this.buttonRemove.TabIndex = 6;
            this.buttonRemove.Text = "Remove Selected";
            this.buttonRemove.UseVisualStyleBackColor = true;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // lblPercent
            // 
            this.lblPercent.AutoSize = true;
            this.lblPercent.Location = new System.Drawing.Point(429, 319);
            this.lblPercent.Name = "lblPercent";
            this.lblPercent.Size = new System.Drawing.Size(28, 25);
            this.lblPercent.TabIndex = 9;
            this.lblPercent.Text = "%";
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.Location = new System.Drawing.Point(481, 303);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(121, 50);
            this.buttonCalculate.TabIndex = 4;
            this.buttonCalculate.Text = "Calculate";
            this.buttonCalculate.UseVisualStyleBackColor = true;
            this.buttonCalculate.Click += new System.EventHandler(this.buttonAdd_Calculate);
            // 
            // buttonClear
            // 
            this.buttonClear.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonClear.Location = new System.Drawing.Point(139, 304);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(121, 50);
            this.buttonClear.TabIndex = 6;
            this.buttonClear.Text = "Clear List";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // FormTaxCalculator
            // 
            this.AcceptButton = this.buttonAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(612, 370);
            this.Controls.Add(this.buttonCalculate);
            this.Controls.Add(this.lblPercent);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonRemove);
            this.Controls.Add(this.lblRate);
            this.Controls.Add(this.textBoxTaxRate);
            this.Controls.Add(this.groupBoxItem);
            this.Controls.Add(this.linkLabelGitHub);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.listBoxItems);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.DarkBlue;
            this.Name = "FormTaxCalculator";
            this.Text = "Tax Calculator";
            this.groupBoxItem.ResumeLayout(false);
            this.groupBoxItem.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxItems;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.LinkLabel linkLabelGitHub;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.CheckBox checkBoxTaxable;
        private System.Windows.Forms.GroupBox groupBoxItem;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.TextBox textBoxTaxRate;
        private System.Windows.Forms.Label lblRate;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.Label lblPercent;
        private System.Windows.Forms.Button buttonCalculate;
        private System.Windows.Forms.Button buttonClear;
    }
}

