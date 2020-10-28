namespace AlarmClock
{
    partial class FormAlarmClock
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
            this.components = new System.ComponentModel.Container();
            this.lblCurrentTime = new System.Windows.Forms.Label();
            this.timerSecond = new System.Windows.Forms.Timer(this.components);
            this.listBoxAlarms = new System.Windows.Forms.ListBox();
            this.btnDeleteAlarm = new System.Windows.Forms.Button();
            this.lblCredits = new System.Windows.Forms.Label();
            this.linkLabelGitHub = new System.Windows.Forms.LinkLabel();
            this.btnAddAlarm = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.lblExpires = new System.Windows.Forms.Label();
            this.lblMessage = new System.Windows.Forms.Label();
            this.textBoxMessage = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblCurrentTime
            // 
            this.lblCurrentTime.AutoSize = true;
            this.lblCurrentTime.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCurrentTime.ForeColor = System.Drawing.Color.Navy;
            this.lblCurrentTime.Location = new System.Drawing.Point(13, 13);
            this.lblCurrentTime.Name = "lblCurrentTime";
            this.lblCurrentTime.Size = new System.Drawing.Size(139, 30);
            this.lblCurrentTime.TabIndex = 0;
            this.lblCurrentTime.Text = "{CurrentTime}";
            // 
            // timerSecond
            // 
            this.timerSecond.Enabled = true;
            this.timerSecond.Interval = 1000;
            this.timerSecond.Tick += new System.EventHandler(this.timerSecond_Tick);
            // 
            // listBoxAlarms
            // 
            this.listBoxAlarms.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listBoxAlarms.ForeColor = System.Drawing.Color.Navy;
            this.listBoxAlarms.FormattingEnabled = true;
            this.listBoxAlarms.ItemHeight = 21;
            this.listBoxAlarms.Location = new System.Drawing.Point(13, 102);
            this.listBoxAlarms.Name = "listBoxAlarms";
            this.listBoxAlarms.Size = new System.Drawing.Size(204, 193);
            this.listBoxAlarms.TabIndex = 6;
            this.listBoxAlarms.SelectedIndexChanged += new System.EventHandler(this.listBoxAlarms_SelectedIndexChanged);
            // 
            // btnDeleteAlarm
            // 
            this.btnDeleteAlarm.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnDeleteAlarm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnDeleteAlarm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteAlarm.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDeleteAlarm.ForeColor = System.Drawing.Color.Navy;
            this.btnDeleteAlarm.Location = new System.Drawing.Point(13, 301);
            this.btnDeleteAlarm.Name = "btnDeleteAlarm";
            this.btnDeleteAlarm.Size = new System.Drawing.Size(204, 45);
            this.btnDeleteAlarm.TabIndex = 7;
            this.btnDeleteAlarm.Text = "Delete Selected";
            this.btnDeleteAlarm.UseVisualStyleBackColor = true;
            this.btnDeleteAlarm.Click += new System.EventHandler(this.btnDeleteAlarm_Click);
            // 
            // lblCredits
            // 
            this.lblCredits.AutoSize = true;
            this.lblCredits.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCredits.Location = new System.Drawing.Point(13, 349);
            this.lblCredits.Name = "lblCredits";
            this.lblCredits.Size = new System.Drawing.Size(192, 21);
            this.lblCredits.TabIndex = 0;
            this.lblCredits.Text = "Alarm Clock by Kyle Givler";
            // 
            // linkLabelGitHub
            // 
            this.linkLabelGitHub.AutoSize = true;
            this.linkLabelGitHub.Location = new System.Drawing.Point(294, 354);
            this.linkLabelGitHub.Name = "linkLabelGitHub";
            this.linkLabelGitHub.Size = new System.Drawing.Size(176, 15);
            this.linkLabelGitHub.TabIndex = 8;
            this.linkLabelGitHub.TabStop = true;
            this.linkLabelGitHub.Text = "http://github.com/JoyfulReaper";
            this.linkLabelGitHub.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelGitHub_LinkClicked);
            // 
            // btnAddAlarm
            // 
            this.btnAddAlarm.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnAddAlarm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnAddAlarm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddAlarm.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAddAlarm.ForeColor = System.Drawing.Color.Navy;
            this.btnAddAlarm.Location = new System.Drawing.Point(13, 51);
            this.btnAddAlarm.Name = "btnAddAlarm";
            this.btnAddAlarm.Size = new System.Drawing.Size(204, 45);
            this.btnAddAlarm.TabIndex = 7;
            this.btnAddAlarm.Text = "Create New Alarm";
            this.btnAddAlarm.UseVisualStyleBackColor = true;
            this.btnAddAlarm.Click += new System.EventHandler(this.btnAddAlarm_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblName.ForeColor = System.Drawing.Color.Navy;
            this.lblName.Location = new System.Drawing.Point(239, 102);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(59, 21);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "{name}";
            // 
            // lblExpires
            // 
            this.lblExpires.AutoSize = true;
            this.lblExpires.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblExpires.ForeColor = System.Drawing.Color.Navy;
            this.lblExpires.Location = new System.Drawing.Point(239, 123);
            this.lblExpires.Name = "lblExpires";
            this.lblExpires.Size = new System.Drawing.Size(69, 21);
            this.lblExpires.TabIndex = 0;
            this.lblExpires.Text = "{expires}";
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMessage.ForeColor = System.Drawing.Color.Navy;
            this.lblMessage.Location = new System.Drawing.Point(239, 144);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(74, 21);
            this.lblMessage.TabIndex = 0;
            this.lblMessage.Text = "Message:";
            // 
            // textBoxMessage
            // 
            this.textBoxMessage.AcceptsReturn = true;
            this.textBoxMessage.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxMessage.Location = new System.Drawing.Point(239, 168);
            this.textBoxMessage.Multiline = true;
            this.textBoxMessage.Name = "textBoxMessage";
            this.textBoxMessage.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxMessage.Size = new System.Drawing.Size(231, 105);
            this.textBoxMessage.TabIndex = 3;
            // 
            // FormAlarmClock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(499, 378);
            this.Controls.Add(this.textBoxMessage);
            this.Controls.Add(this.linkLabelGitHub);
            this.Controls.Add(this.btnAddAlarm);
            this.Controls.Add(this.btnDeleteAlarm);
            this.Controls.Add(this.listBoxAlarms);
            this.Controls.Add(this.lblCredits);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.lblExpires);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblCurrentTime);
            this.Name = "FormAlarmClock";
            this.Text = "Alarm Clock";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCurrentTime;
        private System.Windows.Forms.Timer timerSecond;
        private System.Windows.Forms.ListBox listBoxAlarms;
        private System.Windows.Forms.Button btnDeleteAlarm;
        private System.Windows.Forms.Label lblCredits;
        private System.Windows.Forms.LinkLabel linkLabelGitHub;
        private System.Windows.Forms.Button btnAddAlarm;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblExpires;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.TextBox textBoxMessage;
    }
}

