﻿
namespace LeastAndGreatestCommonDenominator
{
    partial class LCDGCD_Form
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
            this.groupBoxAddFractions = new System.Windows.Forms.GroupBox();
            this.lblEnterFormat = new System.Windows.Forms.Label();
            this.lblOr = new System.Windows.Forms.Label();
            this.textBoxFraction = new System.Windows.Forms.TextBox();
            this.textBoxNumerator = new System.Windows.Forms.TextBox();
            this.textBoxDenominator = new System.Windows.Forms.TextBox();
            this.lblNumerator = new System.Windows.Forms.Label();
            this.lblDenominator = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonSimplify = new System.Windows.Forms.Button();
            this.listBoxFractions = new System.Windows.Forms.ListBox();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.linkLableGitHub = new System.Windows.Forms.LinkLabel();
            this.lblHeader = new System.Windows.Forms.Label();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.groupBoxAddFractions.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxAddFractions
            // 
            this.groupBoxAddFractions.Controls.Add(this.lblEnterFormat);
            this.groupBoxAddFractions.Controls.Add(this.lblOr);
            this.groupBoxAddFractions.Controls.Add(this.textBoxFraction);
            this.groupBoxAddFractions.Controls.Add(this.textBoxNumerator);
            this.groupBoxAddFractions.Controls.Add(this.textBoxDenominator);
            this.groupBoxAddFractions.Controls.Add(this.lblNumerator);
            this.groupBoxAddFractions.Controls.Add(this.lblDenominator);
            this.groupBoxAddFractions.Controls.Add(this.buttonAdd);
            this.groupBoxAddFractions.Location = new System.Drawing.Point(247, 68);
            this.groupBoxAddFractions.Name = "groupBoxAddFractions";
            this.groupBoxAddFractions.Size = new System.Drawing.Size(295, 130);
            this.groupBoxAddFractions.TabIndex = 104;
            this.groupBoxAddFractions.TabStop = false;
            this.groupBoxAddFractions.Text = "Add to List";
            // 
            // lblEnterFormat
            // 
            this.lblEnterFormat.AutoSize = true;
            this.lblEnterFormat.Location = new System.Drawing.Point(112, 97);
            this.lblEnterFormat.Name = "lblEnterFormat";
            this.lblEnterFormat.Size = new System.Drawing.Size(119, 15);
            this.lblEnterFormat.TabIndex = 8;
            this.lblEnterFormat.Text = "Enter fraction like 1/2";
            // 
            // lblOr
            // 
            this.lblOr.AutoSize = true;
            this.lblOr.Location = new System.Drawing.Point(35, 73);
            this.lblOr.Name = "lblOr";
            this.lblOr.Size = new System.Drawing.Size(39, 15);
            this.lblOr.TabIndex = 7;
            this.lblOr.Text = "- OR -";
            // 
            // textBoxFraction
            // 
            this.textBoxFraction.Location = new System.Drawing.Point(6, 91);
            this.textBoxFraction.Name = "textBoxFraction";
            this.textBoxFraction.Size = new System.Drawing.Size(100, 23);
            this.textBoxFraction.TabIndex = 2;
            // 
            // textBoxNumerator
            // 
            this.textBoxNumerator.Location = new System.Drawing.Point(6, 17);
            this.textBoxNumerator.Name = "textBoxNumerator";
            this.textBoxNumerator.Size = new System.Drawing.Size(100, 23);
            this.textBoxNumerator.TabIndex = 0;
            // 
            // textBoxDenominator
            // 
            this.textBoxDenominator.Location = new System.Drawing.Point(6, 46);
            this.textBoxDenominator.Name = "textBoxDenominator";
            this.textBoxDenominator.Size = new System.Drawing.Size(100, 23);
            this.textBoxDenominator.TabIndex = 1;
            // 
            // lblNumerator
            // 
            this.lblNumerator.AutoSize = true;
            this.lblNumerator.Location = new System.Drawing.Point(112, 20);
            this.lblNumerator.Name = "lblNumerator";
            this.lblNumerator.Size = new System.Drawing.Size(65, 15);
            this.lblNumerator.TabIndex = 5;
            this.lblNumerator.Text = "Numerator";
            // 
            // lblDenominator
            // 
            this.lblDenominator.AutoSize = true;
            this.lblDenominator.Location = new System.Drawing.Point(112, 49);
            this.lblDenominator.Name = "lblDenominator";
            this.lblDenominator.Size = new System.Drawing.Size(77, 15);
            this.lblDenominator.TabIndex = 5;
            this.lblDenominator.Text = "Denominator";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(205, 16);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 3;
            this.buttonAdd.Text = "&Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(146, 85);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(75, 23);
            this.buttonClear.TabIndex = 6;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonSimplify
            // 
            this.buttonSimplify.Location = new System.Drawing.Point(146, 114);
            this.buttonSimplify.Name = "buttonSimplify";
            this.buttonSimplify.Size = new System.Drawing.Size(75, 23);
            this.buttonSimplify.TabIndex = 7;
            this.buttonSimplify.Text = "Simplify";
            this.buttonSimplify.UseVisualStyleBackColor = true;
            this.buttonSimplify.Click += new System.EventHandler(this.buttonSimplify_Click);
            // 
            // listBoxFractions
            // 
            this.listBoxFractions.FormattingEnabled = true;
            this.listBoxFractions.ItemHeight = 15;
            this.listBoxFractions.Location = new System.Drawing.Point(7, 44);
            this.listBoxFractions.Name = "listBoxFractions";
            this.listBoxFractions.Size = new System.Drawing.Size(133, 154);
            this.listBoxFractions.TabIndex = 105;
            this.listBoxFractions.TabStop = false;
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(146, 56);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete.TabIndex = 5;
            this.buttonDelete.Text = "Remove";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // linkLableGitHub
            // 
            this.linkLableGitHub.AutoSize = true;
            this.linkLableGitHub.Location = new System.Drawing.Point(7, 255);
            this.linkLableGitHub.Name = "linkLableGitHub";
            this.linkLableGitHub.Size = new System.Drawing.Size(181, 15);
            this.linkLableGitHub.TabIndex = 109;
            this.linkLableGitHub.TabStop = true;
            this.linkLableGitHub.Text = "https://github.com/JoyfulReaper";
            this.linkLableGitHub.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLableGitHub_LinkClicked);
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblHeader.Location = new System.Drawing.Point(7, 9);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(484, 32);
            this.lblHeader.TabIndex = 110;
            this.lblHeader.Text = "Find Least/Greatest Common Denominator";
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.Location = new System.Drawing.Point(239, 219);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(96, 31);
            this.buttonCalculate.TabIndex = 4;
            this.buttonCalculate.Text = "&Calculate";
            this.buttonCalculate.UseVisualStyleBackColor = true;
            this.buttonCalculate.Click += new System.EventHandler(this.buttonCalculate_Click);
            // 
            // LCDGCD_Form
            // 
            this.AcceptButton = this.buttonAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 278);
            this.Controls.Add(this.buttonCalculate);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.linkLableGitHub);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonSimplify);
            this.Controls.Add(this.listBoxFractions);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.groupBoxAddFractions);
            this.Name = "LCDGCD_Form";
            this.Text = "Find Least/Greatest Common Denominator";
            this.groupBoxAddFractions.ResumeLayout(false);
            this.groupBoxAddFractions.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxAddFractions;
        private System.Windows.Forms.Label lblEnterFormat;
        private System.Windows.Forms.Label lblOr;
        private System.Windows.Forms.TextBox textBoxFraction;
        private System.Windows.Forms.TextBox textBoxNumerator;
        private System.Windows.Forms.TextBox textBoxDenominator;
        private System.Windows.Forms.Label lblNumerator;
        private System.Windows.Forms.Label lblDenominator;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonSimplify;
        private System.Windows.Forms.ListBox listBoxFractions;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.LinkLabel linkLableGitHub;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Button buttonCalculate;
    }
}

