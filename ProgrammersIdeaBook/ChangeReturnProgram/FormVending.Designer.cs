
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
            this.SuspendLayout();
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblHeader.Location = new System.Drawing.Point(84, 9);
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
            this.buttonProduct2.Location = new System.Drawing.Point(84, 168);
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
            this.buttonProduct1.Location = new System.Drawing.Point(84, 74);
            this.buttonProduct1.Name = "buttonProduct1";
            this.buttonProduct1.Size = new System.Drawing.Size(293, 88);
            this.buttonProduct1.TabIndex = 1;
            this.buttonProduct1.UseVisualStyleBackColor = true;
            this.buttonProduct1.MouseEnter += new System.EventHandler(this.buttonProduct_MouseEnter);
            this.buttonProduct1.MouseLeave += new System.EventHandler(this.buttonProduct_MouseLeave);
            // 
            // FormVending
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(471, 641);
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
    }
}

