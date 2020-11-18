
namespace CreditCardValidator
{
    partial class frmLuhnChecker
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
            this.buttonValidate = new System.Windows.Forms.Button();
            this.textBoxCardNumber = new System.Windows.Forms.TextBox();
            this.buttonComputeCheck = new System.Windows.Forms.Button();
            this.lblHeader = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonValidate
            // 
            this.buttonValidate.Location = new System.Drawing.Point(121, 141);
            this.buttonValidate.Name = "buttonValidate";
            this.buttonValidate.Size = new System.Drawing.Size(75, 23);
            this.buttonValidate.TabIndex = 0;
            this.buttonValidate.Text = "Validate";
            this.buttonValidate.UseVisualStyleBackColor = true;
            this.buttonValidate.Click += new System.EventHandler(this.buttonValidate_Click);
            // 
            // textBoxCardNumber
            // 
            this.textBoxCardNumber.Location = new System.Drawing.Point(48, 86);
            this.textBoxCardNumber.Name = "textBoxCardNumber";
            this.textBoxCardNumber.Size = new System.Drawing.Size(302, 23);
            this.textBoxCardNumber.TabIndex = 1;
            // 
            // buttonComputeCheck
            // 
            this.buttonComputeCheck.Location = new System.Drawing.Point(202, 141);
            this.buttonComputeCheck.Name = "buttonComputeCheck";
            this.buttonComputeCheck.Size = new System.Drawing.Size(75, 23);
            this.buttonComputeCheck.TabIndex = 2;
            this.buttonComputeCheck.Text = "Compute Check Digit";
            this.buttonComputeCheck.UseVisualStyleBackColor = true;
            this.buttonComputeCheck.Click += new System.EventHandler(this.buttonComputeCheck_Click);
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Location = new System.Drawing.Point(27, 18);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(344, 45);
            this.lblHeader.TabIndex = 3;
            this.lblHeader.Text = "Enter a number and press Validate to use the Luhn Algorithm to \r\nvalidate the che" +
    "ck digit.Press Computer to computer the check\r\n digit using the Luhn Algorithm.";
            // 
            // frmLuhnChecker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 196);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.buttonComputeCheck);
            this.Controls.Add(this.textBoxCardNumber);
            this.Controls.Add(this.buttonValidate);
            this.Name = "frmLuhnChecker";
            this.Text = "Luhn Validator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonValidate;
        private System.Windows.Forms.TextBox textBoxCardNumber;
        private System.Windows.Forms.Button buttonComputeCheck;
        private System.Windows.Forms.Label lblHeader;
    }
}

