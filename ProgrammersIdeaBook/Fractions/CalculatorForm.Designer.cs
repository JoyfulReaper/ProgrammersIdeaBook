
namespace Fractions
{
    partial class CalculatorForm
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
            this.groupBoxOperation = new System.Windows.Forms.GroupBox();
            this.listBoxFractions = new System.Windows.Forms.ListBox();
            this.radioAdd = new System.Windows.Forms.RadioButton();
            this.radioSubtract = new System.Windows.Forms.RadioButton();
            this.radioMultiple = new System.Windows.Forms.RadioButton();
            this.radioDivide = new System.Windows.Forms.RadioButton();
            this.lblHeader = new System.Windows.Forms.Label();
            this.groupBoxOperation.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxOperation
            // 
            this.groupBoxOperation.Controls.Add(this.radioDivide);
            this.groupBoxOperation.Controls.Add(this.radioMultiple);
            this.groupBoxOperation.Controls.Add(this.radioSubtract);
            this.groupBoxOperation.Controls.Add(this.radioAdd);
            this.groupBoxOperation.Location = new System.Drawing.Point(12, 189);
            this.groupBoxOperation.Name = "groupBoxOperation";
            this.groupBoxOperation.Size = new System.Drawing.Size(133, 121);
            this.groupBoxOperation.TabIndex = 0;
            this.groupBoxOperation.TabStop = false;
            this.groupBoxOperation.Text = "Operation";
            // 
            // listBoxFractions
            // 
            this.listBoxFractions.FormattingEnabled = true;
            this.listBoxFractions.ItemHeight = 15;
            this.listBoxFractions.Location = new System.Drawing.Point(12, 44);
            this.listBoxFractions.Name = "listBoxFractions";
            this.listBoxFractions.Size = new System.Drawing.Size(133, 139);
            this.listBoxFractions.TabIndex = 1;
            // 
            // radioAdd
            // 
            this.radioAdd.AutoSize = true;
            this.radioAdd.Location = new System.Drawing.Point(7, 23);
            this.radioAdd.Name = "radioAdd";
            this.radioAdd.Size = new System.Drawing.Size(47, 19);
            this.radioAdd.TabIndex = 0;
            this.radioAdd.TabStop = true;
            this.radioAdd.Text = "Add";
            this.radioAdd.UseVisualStyleBackColor = true;
            // 
            // radioSubtract
            // 
            this.radioSubtract.AutoSize = true;
            this.radioSubtract.Location = new System.Drawing.Point(6, 48);
            this.radioSubtract.Name = "radioSubtract";
            this.radioSubtract.Size = new System.Drawing.Size(69, 19);
            this.radioSubtract.TabIndex = 0;
            this.radioSubtract.TabStop = true;
            this.radioSubtract.Text = "Subtract";
            this.radioSubtract.UseVisualStyleBackColor = true;
            // 
            // radioMultiple
            // 
            this.radioMultiple.AutoSize = true;
            this.radioMultiple.Location = new System.Drawing.Point(6, 73);
            this.radioMultiple.Name = "radioMultiple";
            this.radioMultiple.Size = new System.Drawing.Size(69, 19);
            this.radioMultiple.TabIndex = 0;
            this.radioMultiple.TabStop = true;
            this.radioMultiple.Text = "Multiply";
            this.radioMultiple.UseVisualStyleBackColor = true;
            // 
            // radioDivide
            // 
            this.radioDivide.AutoSize = true;
            this.radioDivide.Location = new System.Drawing.Point(6, 98);
            this.radioDivide.Name = "radioDivide";
            this.radioDivide.Size = new System.Drawing.Size(58, 19);
            this.radioDivide.TabIndex = 0;
            this.radioDivide.TabStop = true;
            this.radioDivide.Text = "Divide";
            this.radioDivide.UseVisualStyleBackColor = true;
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblHeader.Location = new System.Drawing.Point(12, 9);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(219, 32);
            this.lblHeader.TabIndex = 2;
            this.lblHeader.Text = "Fraction Calculator";
            // 
            // CalculatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 371);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.listBoxFractions);
            this.Controls.Add(this.groupBoxOperation);
            this.Name = "CalculatorForm";
            this.Text = "Fraction Calculator";
            this.groupBoxOperation.ResumeLayout(false);
            this.groupBoxOperation.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxOperation;
        private System.Windows.Forms.RadioButton radioDivide;
        private System.Windows.Forms.RadioButton radioMultiple;
        private System.Windows.Forms.RadioButton radioSubtract;
        private System.Windows.Forms.RadioButton radioAdd;
        private System.Windows.Forms.ListBox listBoxFractions;
        private System.Windows.Forms.Label lblHeader;
    }
}

