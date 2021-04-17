namespace AlarmClock
{
    partial class frmMissedAlarms
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
            this.components = new System.ComponentModel.Container();
            this.lblMissedHeader = new System.Windows.Forms.Label();
            this.listBoxMissedAlarms = new System.Windows.Forms.ListBox();
            this.lblMissedAlarms = new System.Windows.Forms.Label();
            this.textBoxMessage = new System.Windows.Forms.TextBox();
            this.lblMessage = new System.Windows.Forms.Label();
            this.lblExpires = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblOverdue = new System.Windows.Forms.Label();
            this.timerUpdate = new System.Windows.Forms.Timer(this.components);
            this.btnDismiss = new System.Windows.Forms.Button();
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
            this.listBoxMissedAlarms.SelectedIndexChanged += new System.EventHandler(this.listBoxMissedAlarms_SelectedIndexChanged);
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
            // textBoxMessage
            // 
            this.textBoxMessage.AcceptsReturn = true;
            this.textBoxMessage.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxMessage.Location = new System.Drawing.Point(212, 164);
            this.textBoxMessage.Multiline = true;
            this.textBoxMessage.Name = "textBoxMessage";
            this.textBoxMessage.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxMessage.Size = new System.Drawing.Size(231, 79);
            this.textBoxMessage.TabIndex = 3;
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMessage.ForeColor = System.Drawing.Color.Navy;
            this.lblMessage.Location = new System.Drawing.Point(212, 140);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(74, 21);
            this.lblMessage.TabIndex = 0;
            this.lblMessage.Text = "Message:";
            // 
            // lblExpires
            // 
            this.lblExpires.AutoSize = true;
            this.lblExpires.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblExpires.ForeColor = System.Drawing.Color.Navy;
            this.lblExpires.Location = new System.Drawing.Point(212, 119);
            this.lblExpires.Name = "lblExpires";
            this.lblExpires.Size = new System.Drawing.Size(69, 21);
            this.lblExpires.TabIndex = 0;
            this.lblExpires.Text = "{expires}";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblName.ForeColor = System.Drawing.Color.Navy;
            this.lblName.Location = new System.Drawing.Point(212, 78);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(59, 21);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "{name}";
            // 
            // lblOverdue
            // 
            this.lblOverdue.AutoSize = true;
            this.lblOverdue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblOverdue.ForeColor = System.Drawing.Color.Navy;
            this.lblOverdue.Location = new System.Drawing.Point(212, 98);
            this.lblOverdue.Name = "lblOverdue";
            this.lblOverdue.Size = new System.Drawing.Size(77, 21);
            this.lblOverdue.TabIndex = 0;
            this.lblOverdue.Text = "{overdue}";
            // 
            // timerUpdate
            // 
            this.timerUpdate.Enabled = true;
            this.timerUpdate.Interval = 1000;
            this.timerUpdate.Tick += new System.EventHandler(this.timerUpdate_Tick);
            // 
            // btnDismiss
            // 
            this.btnDismiss.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnDismiss.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnDismiss.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDismiss.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDismiss.ForeColor = System.Drawing.Color.Navy;
            this.btnDismiss.Location = new System.Drawing.Point(220, 255);
            this.btnDismiss.Name = "btnDismiss";
            this.btnDismiss.Size = new System.Drawing.Size(130, 45);
            this.btnDismiss.TabIndex = 4;
            this.btnDismiss.Text = "Dismiss";
            this.btnDismiss.UseVisualStyleBackColor = true;
            this.btnDismiss.Click += new System.EventHandler(this.btnDismiss_Click);
            // 
            // MissedAlarmsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(571, 308);
            this.Controls.Add(this.btnDismiss);
            this.Controls.Add(this.lblOverdue);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblExpires);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.textBoxMessage);
            this.Controls.Add(this.listBoxMissedAlarms);
            this.Controls.Add(this.lblMissedAlarms);
            this.Controls.Add(this.lblMissedHeader);
            this.Name = "MissedAlarmsForm";
            this.Text = "Missed Alarms";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMissedHeader;
        private System.Windows.Forms.ListBox listBoxMissedAlarms;
        private System.Windows.Forms.Label lblMissedAlarms;
        private System.Windows.Forms.TextBox textBoxMessage;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Label lblExpires;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblOverdue;
        private System.Windows.Forms.Timer timerUpdate;
        private System.Windows.Forms.Button btnDismiss;
    }
}