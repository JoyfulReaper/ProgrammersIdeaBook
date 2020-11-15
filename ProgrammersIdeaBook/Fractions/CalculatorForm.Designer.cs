
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
            this.radioDivide = new System.Windows.Forms.RadioButton();
            this.radioMultiple = new System.Windows.Forms.RadioButton();
            this.radioSubtract = new System.Windows.Forms.RadioButton();
            this.radioAdd = new System.Windows.Forms.RadioButton();
            this.listBoxFractions = new System.Windows.Forms.ListBox();
            this.lblHeader = new System.Windows.Forms.Label();
            this.textBoxNumerator = new System.Windows.Forms.TextBox();
            this.textBoxDenominator = new System.Windows.Forms.TextBox();
            this.lblNumerator = new System.Windows.Forms.Label();
            this.lblDenominator = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.lblResults = new System.Windows.Forms.Label();
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
            this.groupBoxOperation.TabIndex = 99;
            this.groupBoxOperation.TabStop = false;
            this.groupBoxOperation.Text = "Operation";
            // 
            // radioDivide
            // 
            this.radioDivide.AutoSize = true;
            this.radioDivide.Location = new System.Drawing.Point(6, 98);
            this.radioDivide.Name = "radioDivide";
            this.radioDivide.Size = new System.Drawing.Size(58, 19);
            this.radioDivide.TabIndex = 6;
            this.radioDivide.Text = "Divide";
            this.radioDivide.UseVisualStyleBackColor = true;
            // 
            // radioMultiple
            // 
            this.radioMultiple.AutoSize = true;
            this.radioMultiple.Location = new System.Drawing.Point(6, 73);
            this.radioMultiple.Name = "radioMultiple";
            this.radioMultiple.Size = new System.Drawing.Size(69, 19);
            this.radioMultiple.TabIndex = 5;
            this.radioMultiple.Text = "Multiply";
            this.radioMultiple.UseVisualStyleBackColor = true;
            // 
            // radioSubtract
            // 
            this.radioSubtract.AutoSize = true;
            this.radioSubtract.Location = new System.Drawing.Point(6, 48);
            this.radioSubtract.Name = "radioSubtract";
            this.radioSubtract.Size = new System.Drawing.Size(69, 19);
            this.radioSubtract.TabIndex = 4;
            this.radioSubtract.Text = "Subtract";
            this.radioSubtract.UseVisualStyleBackColor = true;
            // 
            // radioAdd
            // 
            this.radioAdd.AutoSize = true;
            this.radioAdd.Checked = true;
            this.radioAdd.Location = new System.Drawing.Point(7, 23);
            this.radioAdd.Name = "radioAdd";
            this.radioAdd.Size = new System.Drawing.Size(47, 19);
            this.radioAdd.TabIndex = 3;
            this.radioAdd.TabStop = true;
            this.radioAdd.Text = "Add";
            this.radioAdd.UseVisualStyleBackColor = true;
            // 
            // listBoxFractions
            // 
            this.listBoxFractions.FormattingEnabled = true;
            this.listBoxFractions.ItemHeight = 15;
            this.listBoxFractions.Location = new System.Drawing.Point(12, 44);
            this.listBoxFractions.Name = "listBoxFractions";
            this.listBoxFractions.Size = new System.Drawing.Size(133, 139);
            this.listBoxFractions.TabIndex = 1;
            this.listBoxFractions.TabStop = false;
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
            // textBoxNumerator
            // 
            this.textBoxNumerator.Location = new System.Drawing.Point(151, 44);
            this.textBoxNumerator.Name = "textBoxNumerator";
            this.textBoxNumerator.Size = new System.Drawing.Size(100, 23);
            this.textBoxNumerator.TabIndex = 0;
            // 
            // textBoxDenominator
            // 
            this.textBoxDenominator.Location = new System.Drawing.Point(151, 73);
            this.textBoxDenominator.Name = "textBoxDenominator";
            this.textBoxDenominator.Size = new System.Drawing.Size(100, 23);
            this.textBoxDenominator.TabIndex = 1;
            // 
            // lblNumerator
            // 
            this.lblNumerator.AutoSize = true;
            this.lblNumerator.Location = new System.Drawing.Point(257, 47);
            this.lblNumerator.Name = "lblNumerator";
            this.lblNumerator.Size = new System.Drawing.Size(65, 15);
            this.lblNumerator.TabIndex = 5;
            this.lblNumerator.Text = "Numerator";
            // 
            // lblDenominator
            // 
            this.lblDenominator.AutoSize = true;
            this.lblDenominator.Location = new System.Drawing.Point(257, 76);
            this.lblDenominator.Name = "lblDenominator";
            this.lblDenominator.Size = new System.Drawing.Size(77, 15);
            this.lblDenominator.TabIndex = 5;
            this.lblDenominator.Text = "Denominator";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(340, 72);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 2;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.Location = new System.Drawing.Point(229, 285);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(75, 23);
            this.buttonCalculate.TabIndex = 7;
            this.buttonCalculate.Text = "Calculate";
            this.buttonCalculate.UseVisualStyleBackColor = true;
            this.buttonCalculate.Click += new System.EventHandler(this.buttonCalculate_Click);
            // 
            // lblResults
            // 
            this.lblResults.AutoSize = true;
            this.lblResults.Location = new System.Drawing.Point(212, 167);
            this.lblResults.Name = "lblResults";
            this.lblResults.Size = new System.Drawing.Size(53, 15);
            this.lblResults.TabIndex = 100;
            this.lblResults.Text = "{RESULT}";
            this.lblResults.Visible = false;
            // 
            // CalculatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 325);
            this.Controls.Add(this.lblResults);
            this.Controls.Add(this.buttonCalculate);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.lblDenominator);
            this.Controls.Add(this.lblNumerator);
            this.Controls.Add(this.textBoxDenominator);
            this.Controls.Add(this.textBoxNumerator);
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
        private System.Windows.Forms.TextBox textBoxNumerator;
        private System.Windows.Forms.TextBox textBoxDenominator;
        private System.Windows.Forms.Label lblNumerator;
        private System.Windows.Forms.Label lblDenominator;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonCalculate;
        private System.Windows.Forms.Label lblResults;
    }
}

