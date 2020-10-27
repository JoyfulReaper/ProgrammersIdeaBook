namespace AlarmClock
{
    partial class MissedAlarmsForm
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
            this.lblMissedHeader = new System.Windows.Forms.Label();
            this.listBoxMissedAlarms = new System.Windows.Forms.ListBox();
            this.lblMissedAlarms = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblMissedHeader
            // 
            this.lblMissedHeader.AutoSize = true;
            this.lblMissedHeader.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMissedHeader.ForeColor = System.Drawing.Color.Navy;
            this.lblMissedHeader.Location = new System.Drawing.Point(12, 9);
            this.lblMissedHeader.Name = "lblMissedHeader";
            this.lblMissedHeader.Size = new System.Drawing.Size(194, 37);
            this.lblMissedHeader.TabIndex = 0;
            this.lblMissedHeader.Text = "Missed Alarms:";
            // 
            // listBoxMissedAlarms
            // 
            this.listBoxMissedAlarms.FormattingEnabled = true;
            this.listBoxMissedAlarms.ItemHeight = 15;
            this.listBoxMissedAlarms.Location = new System.Drawing.Point(12, 71);
            this.listBoxMissedAlarms.Name = "listBoxMissedAlarms";
            this.listBoxMissedAlarms.Size = new System.Drawing.Size(194, 229);
            this.listBoxMissedAlarms.TabIndex = 1;
            // 
            // lblMissedAlarms
            // 
            this.lblMissedAlarms.AutoSize = true;
            this.lblMissedAlarms.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMissedAlarms.ForeColor = System.Drawing.Color.Navy;
            this.lblMissedAlarms.Location = new System.Drawing.Point(12, 46);
            this.lblMissedAlarms.Name = "lblMissedAlarms";
            this.lblMissedAlarms.Size = new System.Drawing.Size(481, 21);
            this.lblMissedAlarms.TabIndex = 0;
            this.lblMissedAlarms.Text = "The following alarms occured while the application was not running:";
            // 
            // MissedAlarmsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(597, 312);
            this.Controls.Add(this.listBoxMissedAlarms);
            this.Controls.Add(this.lblMissedAlarms);
            this.Controls.Add(this.lblMissedHeader);
            this.Name = "MissedAlarmsForm";
            this.Text = "MissedAlarmsForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMissedHeader;
        private System.Windows.Forms.ListBox listBoxMissedAlarms;
        private System.Windows.Forms.Label lblMissedAlarms;
    }
}