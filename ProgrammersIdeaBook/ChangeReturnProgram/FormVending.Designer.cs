
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
            this.buttonDollar.Click += new System.EventHandler(this.buttonDollar_Click);
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
            this.buttonQuarter.Click += new System.EventHandler(this.buttonQuarter_Click);
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
            this.buttonDime.Click += new System.EventHandler(this.buttonDime_Click);
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
            this.buttonNickel.Click += new System.EventHandler(this.buttonNickel_Click);
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
            this.buttonPenny.Click += new System.EventHandler(this.buttonPenny_Click);
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
            // FormVending
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(503, 525);
            this.Controls.Add(this.lblCredit);
            this.Controls.Add(this.buttonNickel);
            this.Controls.Add(this.buttonPenny);
            this.Controls.Add(this.buttonDime);
            this.Controls.Add(this.buttonQuarter);
            this.Controls.Add(this.buttonDollar);
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
        private System.Windows.Forms.Label labelCredit;
        private System.Windows.Forms.Label lblCredit;
    }
}

