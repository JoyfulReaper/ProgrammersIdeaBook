
namespace ChangeReturnProgram
{
    partial class FormVending
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormVending));
            this.lblHeader = new System.Windows.Forms.Label();
            this.buttonProduct2 = new System.Windows.Forms.Button();
            this.buttonProduct1 = new System.Windows.Forms.Button();
            this.buttonDollar = new System.Windows.Forms.Button();
            this.buttonQuarter = new System.Windows.Forms.Button();
            this.buttonDime = new System.Windows.Forms.Button();
            this.buttonNickel = new System.Windows.Forms.Button();
            this.buttonPenny = new System.Windows.Forms.Button();
            this.lblCredit = new System.Windows.Forms.Label();
            this.buttonProduct3 = new System.Windows.Forms.Button();
            this.buttonProduct4 = new System.Windows.Forms.Button();
            this.lblChange = new System.Windows.Forms.Label();
            this.lblQuaters = new System.Windows.Forms.Label();
            this.lblDimes = new System.Windows.Forms.Label();
            this.lblNickels = new System.Windows.Forms.Label();
            this.lblPennies = new System.Windows.Forms.Label();
            this.linkLabelGitHub = new System.Windows.Forms.LinkLabel();
            this.buttonChangeProducts = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblHeader.Location = new System.Drawing.Point(100, 9);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(302, 37);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "Vending Machine Demo";
            // 
            // buttonProduct2
            // 
            this.buttonProduct2.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonProduct2.FlatAppearance.BorderSize = 0;
            this.buttonProduct2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonProduct2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonProduct2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonProduct2.Image = ((System.Drawing.Image)(resources.GetObject("buttonProduct2.Image")));
            this.buttonProduct2.Location = new System.Drawing.Point(12, 166);
            this.buttonProduct2.Name = "buttonProduct2";
            this.buttonProduct2.Size = new System.Drawing.Size(293, 88);
            this.buttonProduct2.TabIndex = 1;
            this.buttonProduct2.UseVisualStyleBackColor = true;
            this.buttonProduct2.Click += new System.EventHandler(this.buttonProduct_Click);
            this.buttonProduct2.MouseEnter += new System.EventHandler(this.buttonProduct_MouseEnter);
            this.buttonProduct2.MouseLeave += new System.EventHandler(this.buttonProduct_MouseLeave);
            // 
            // buttonProduct1
            // 
            this.buttonProduct1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonProduct1.FlatAppearance.BorderSize = 0;
            this.buttonProduct1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonProduct1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonProduct1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonProduct1.Image = ((System.Drawing.Image)(resources.GetObject("buttonProduct1.Image")));
            this.buttonProduct1.Location = new System.Drawing.Point(12, 72);
            this.buttonProduct1.Name = "buttonProduct1";
            this.buttonProduct1.Size = new System.Drawing.Size(293, 88);
            this.buttonProduct1.TabIndex = 1;
            this.buttonProduct1.UseVisualStyleBackColor = true;
            this.buttonProduct1.Click += new System.EventHandler(this.buttonProduct_Click);
            this.buttonProduct1.MouseEnter += new System.EventHandler(this.buttonProduct_MouseEnter);
            this.buttonProduct1.MouseLeave += new System.EventHandler(this.buttonProduct_MouseLeave);
            // 
            // buttonDollar
            // 
            this.buttonDollar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonDollar.Location = new System.Drawing.Point(344, 72);
            this.buttonDollar.Name = "buttonDollar";
            this.buttonDollar.Size = new System.Drawing.Size(124, 42);
            this.buttonDollar.TabIndex = 2;
            this.buttonDollar.Text = "Insert Dollar";
            this.buttonDollar.UseVisualStyleBackColor = true;
            this.buttonDollar.Click += new System.EventHandler(this.buttonCredit_Click);
            // 
            // buttonQuarter
            // 
            this.buttonQuarter.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonQuarter.Location = new System.Drawing.Point(344, 118);
            this.buttonQuarter.Name = "buttonQuarter";
            this.buttonQuarter.Size = new System.Drawing.Size(124, 42);
            this.buttonQuarter.TabIndex = 2;
            this.buttonQuarter.Text = "Insert Quarter";
            this.buttonQuarter.UseVisualStyleBackColor = true;
            this.buttonQuarter.Click += new System.EventHandler(this.buttonCredit_Click);
            // 
            // buttonDime
            // 
            this.buttonDime.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonDime.Location = new System.Drawing.Point(344, 166);
            this.buttonDime.Name = "buttonDime";
            this.buttonDime.Size = new System.Drawing.Size(124, 42);
            this.buttonDime.TabIndex = 2;
            this.buttonDime.Text = "Insert Dime";
            this.buttonDime.UseVisualStyleBackColor = true;
            this.buttonDime.Click += new System.EventHandler(this.buttonCredit_Click);
            // 
            // buttonNickel
            // 
            this.buttonNickel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonNickel.Location = new System.Drawing.Point(344, 212);
            this.buttonNickel.Name = "buttonNickel";
            this.buttonNickel.Size = new System.Drawing.Size(124, 42);
            this.buttonNickel.TabIndex = 2;
            this.buttonNickel.Text = "Insert Nickel";
            this.buttonNickel.UseVisualStyleBackColor = true;
            this.buttonNickel.Click += new System.EventHandler(this.buttonCredit_Click);
            // 
            // buttonPenny
            // 
            this.buttonPenny.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonPenny.Location = new System.Drawing.Point(344, 260);
            this.buttonPenny.Name = "buttonPenny";
            this.buttonPenny.Size = new System.Drawing.Size(124, 42);
            this.buttonPenny.TabIndex = 2;
            this.buttonPenny.Text = "Insert Penny";
            this.buttonPenny.UseVisualStyleBackColor = true;
            this.buttonPenny.Click += new System.EventHandler(this.buttonCredit_Click);
            // 
            // lblCredit
            // 
            this.lblCredit.AutoSize = true;
            this.lblCredit.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCredit.Location = new System.Drawing.Point(344, 316);
            this.lblCredit.Name = "lblCredit";
            this.lblCredit.Size = new System.Drawing.Size(72, 25);
            this.lblCredit.TabIndex = 3;
            this.lblCredit.Text = "Credit: ";
            // 
            // buttonProduct3
            // 
            this.buttonProduct3.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonProduct3.FlatAppearance.BorderSize = 0;
            this.buttonProduct3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonProduct3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonProduct3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonProduct3.Image = ((System.Drawing.Image)(resources.GetObject("buttonProduct3.Image")));
            this.buttonProduct3.Location = new System.Drawing.Point(12, 260);
            this.buttonProduct3.Name = "buttonProduct3";
            this.buttonProduct3.Size = new System.Drawing.Size(293, 88);
            this.buttonProduct3.TabIndex = 1;
            this.buttonProduct3.UseVisualStyleBackColor = true;
            this.buttonProduct3.Click += new System.EventHandler(this.buttonProduct_Click);
            this.buttonProduct3.MouseEnter += new System.EventHandler(this.buttonProduct_MouseEnter);
            this.buttonProduct3.MouseLeave += new System.EventHandler(this.buttonProduct_MouseLeave);
            // 
            // buttonProduct4
            // 
            this.buttonProduct4.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonProduct4.FlatAppearance.BorderSize = 0;
            this.buttonProduct4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonProduct4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonProduct4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonProduct4.Image = ((System.Drawing.Image)(resources.GetObject("buttonProduct4.Image")));
            this.buttonProduct4.Location = new System.Drawing.Point(12, 354);
            this.buttonProduct4.Name = "buttonProduct4";
            this.buttonProduct4.Size = new System.Drawing.Size(293, 88);
            this.buttonProduct4.TabIndex = 1;
            this.buttonProduct4.UseVisualStyleBackColor = true;
            this.buttonProduct4.Click += new System.EventHandler(this.buttonProduct_Click);
            this.buttonProduct4.MouseEnter += new System.EventHandler(this.buttonProduct_MouseEnter);
            this.buttonProduct4.MouseLeave += new System.EventHandler(this.buttonProduct_MouseLeave);
            // 
            // lblChange
            // 
            this.lblChange.AutoSize = true;
            this.lblChange.Location = new System.Drawing.Point(12, 442);
            this.lblChange.Name = "lblChange";
            this.lblChange.Size = new System.Drawing.Size(89, 30);
            this.lblChange.TabIndex = 4;
            this.lblChange.Text = "Change:";
            this.lblChange.Visible = false;
            // 
            // lblQuaters
            // 
            this.lblQuaters.AutoSize = true;
            this.lblQuaters.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblQuaters.Location = new System.Drawing.Point(12, 472);
            this.lblQuaters.Name = "lblQuaters";
            this.lblQuaters.Size = new System.Drawing.Size(87, 25);
            this.lblQuaters.TabIndex = 5;
            this.lblQuaters.Text = "Quaters: ";
            this.lblQuaters.Visible = false;
            // 
            // lblDimes
            // 
            this.lblDimes.AutoSize = true;
            this.lblDimes.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDimes.Location = new System.Drawing.Point(190, 472);
            this.lblDimes.Name = "lblDimes";
            this.lblDimes.Size = new System.Drawing.Size(68, 25);
            this.lblDimes.TabIndex = 5;
            this.lblDimes.Text = "Dimes:";
            this.lblDimes.Visible = false;
            // 
            // lblNickels
            // 
            this.lblNickels.AutoSize = true;
            this.lblNickels.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNickels.Location = new System.Drawing.Point(12, 497);
            this.lblNickels.Name = "lblNickels";
            this.lblNickels.Size = new System.Drawing.Size(81, 25);
            this.lblNickels.TabIndex = 5;
            this.lblNickels.Text = "Nickels: ";
            this.lblNickels.Visible = false;
            // 
            // lblPennies
            // 
            this.lblPennies.AutoSize = true;
            this.lblPennies.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPennies.Location = new System.Drawing.Point(190, 497);
            this.lblPennies.Name = "lblPennies";
            this.lblPennies.Size = new System.Drawing.Size(81, 25);
            this.lblPennies.TabIndex = 5;
            this.lblPennies.Text = "Pennies:";
            this.lblPennies.Visible = false;
            // 
            // linkLabelGitHub
            // 
            this.linkLabelGitHub.AutoSize = true;
            this.linkLabelGitHub.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.linkLabelGitHub.Location = new System.Drawing.Point(12, 532);
            this.linkLabelGitHub.Name = "linkLabelGitHub";
            this.linkLabelGitHub.Size = new System.Drawing.Size(234, 21);
            this.linkLabelGitHub.TabIndex = 6;
            this.linkLabelGitHub.TabStop = true;
            this.linkLabelGitHub.Text = "https://github.com/JoyfulReaper";
            this.linkLabelGitHub.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelGitHub_LinkClicked);
            // 
            // buttonChangeProducts
            // 
            this.buttonChangeProducts.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonChangeProducts.ForeColor = System.Drawing.Color.DodgerBlue;
            this.buttonChangeProducts.Location = new System.Drawing.Point(367, 508);
            this.buttonChangeProducts.Name = "buttonChangeProducts";
            this.buttonChangeProducts.Size = new System.Drawing.Size(124, 42);
            this.buttonChangeProducts.TabIndex = 2;
            this.buttonChangeProducts.Text = "Change Products";
            this.buttonChangeProducts.UseVisualStyleBackColor = true;
            this.buttonChangeProducts.Click += new System.EventHandler(this.buttonChangeProducts_Click);
            // 
            // FormVending
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(503, 562);
            this.Controls.Add(this.linkLabelGitHub);
            this.Controls.Add(this.lblDimes);
            this.Controls.Add(this.lblNickels);
            this.Controls.Add(this.lblPennies);
            this.Controls.Add(this.lblQuaters);
            this.Controls.Add(this.lblChange);
            this.Controls.Add(this.lblCredit);
            this.Controls.Add(this.buttonNickel);
            this.Controls.Add(this.buttonPenny);
            this.Controls.Add(this.buttonDime);
            this.Controls.Add(this.buttonQuarter);
            this.Controls.Add(this.buttonChangeProducts);
            this.Controls.Add(this.buttonDollar);
            this.Controls.Add(this.buttonProduct3);
            this.Controls.Add(this.buttonProduct4);
            this.Controls.Add(this.buttonProduct1);
            this.Controls.Add(this.buttonProduct2);
            this.Controls.Add(this.lblHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.DarkBlue;
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "FormVending";
            this.Text = "Change Return Program";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Button buttonProduct2;
        private System.Windows.Forms.Button buttonProduct1;
        private System.Windows.Forms.Button buttonDollar;
        private System.Windows.Forms.Button buttonQuarter;
        private System.Windows.Forms.Button buttonDime;
        private System.Windows.Forms.Button buttonNickel;
        private System.Windows.Forms.Button buttonPenny;
        private System.Windows.Forms.Label lblCredit;
        private System.Windows.Forms.Button buttonProduct3;
        private System.Windows.Forms.Button buttonProduct4;
        private System.Windows.Forms.Label lblChange;
        private System.Windows.Forms.Label lblQuaters;
        private System.Windows.Forms.Label lblDimes;
        private System.Windows.Forms.Label lblNickels;
        private System.Windows.Forms.Label lblPennies;
        private System.Windows.Forms.LinkLabel linkLabelGitHub;
        private System.Windows.Forms.Button buttonChangeProducts;
    }
}

