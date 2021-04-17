namespace AlarmClock
{
    partial class frmAlarmFired
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
            this.lblAlarmHeader = new System.Windows.Forms.Label();
            this.ColorTimer = new System.Windows.Forms.Timer(this.components);
            this.lblName = new System.Windows.Forms.Label();
            this.lblMessage = new System.Windows.Forms.Label();
            this.btnAcknowledge = new System.Windows.Forms.Button();
            this.lblAlarmTime = new System.Windows.Forms.Label();
            this.lblElapsed = new System.Windows.Forms.Label();
            this.textBoxMessage = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblAlarmHeader
            // 
            this.lblAlarmHeader.AutoSize = true;
            this.lblAlarmHeader.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAlarmHeader.ForeColor = System.Drawing.Color.Navy;
            this.lblAlarmHeader.Location = new System.Drawing.Point(146, 9);
            this.lblAlarmHeader.Name = "lblAlarmHeader";
            this.lblAlarmHeader.Size = new System.Drawing.Size(240, 50);
            this.lblAlarmHeader.TabIndex = 0;
            this.lblAlarmHeader.Text = "Alarm Active!";
            // 
            // ColorTimer
            // 
            this.ColorTimer.Enabled = true;
            this.ColorTimer.Interval = 300;
            this.ColorTimer.Tick += new System.EventHandler(this.ColorTimer_Tick);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblName.ForeColor = System.Drawing.Color.Navy;
            this.lblName.Location = new System.Drawing.Point(12, 64);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(77, 30);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "{name}";
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMessage.ForeColor = System.Drawing.Color.Navy;
            this.lblMessage.Location = new System.Drawing.Point(12, 155);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(100, 30);
            this.lblMessage.TabIndex = 0;
            this.lblMessage.Text = "Message:";
            // 
            // btnAcknowledge
            // 
            this.btnAcknowledge.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnAcknowledge.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnAcknowledge.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAcknowledge.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAcknowledge.ForeColor = System.Drawing.Color.Navy;
            this.btnAcknowledge.Location = new System.Drawing.Point(164, 286);
            this.btnAcknowledge.Name = "btnAcknowledge";
            this.btnAcknowledge.Size = new System.Drawing.Size(204, 45);
            this.btnAcknowledge.TabIndex = 1;
            this.btnAcknowledge.Text = "Acknowledge";
            this.btnAcknowledge.UseVisualStyleBackColor = true;
            this.btnAcknowledge.Click += new System.EventHandler(this.btnAcknowledge_Click);
            // 
            // lblAlarmTime
            // 
            this.lblAlarmTime.AutoSize = true;
            this.lblAlarmTime.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAlarmTime.ForeColor = System.Drawing.Color.Navy;
            this.lblAlarmTime.Location = new System.Drawing.Point(12, 94);
            this.lblAlarmTime.Name = "lblAlarmTime";
            this.lblAlarmTime.Size = new System.Drawing.Size(84, 30);
            this.lblAlarmTime.TabIndex = 0;
            this.lblAlarmTime.Text = "{set for}";
            // 
            // lblElapsed
            // 
            this.lblElapsed.AutoSize = true;
            this.lblElapsed.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblElapsed.ForeColor = System.Drawing.Color.Navy;
            this.lblElapsed.Location = new System.Drawing.Point(12, 125);
            this.lblElapsed.Name = "lblElapsed";
            this.lblElapsed.Size = new System.Drawing.Size(96, 30);
            this.lblElapsed.TabIndex = 0;
            this.lblElapsed.Text = "{elapsed}";
            // 
            // textBoxMessage
            // 
            this.textBoxMessage.AcceptsReturn = true;
            this.textBoxMessage.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxMessage.Location = new System.Drawing.Point(12, 188);
            this.textBoxMessage.Multiline = true;
            this.textBoxMessage.Name = "textBoxMessage";
            this.textBoxMessage.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxMessage.Size = new System.Drawing.Size(231, 79);
            this.textBoxMessage.TabIndex = 2;
            // 
            // AlarmFiredForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(533, 353);
            this.Controls.Add(this.lblAlarmHeader);
            this.Controls.Add(this.textBoxMessage);
            this.Controls.Add(this.btnAcknowledge);
            this.Controls.Add(this.lblElapsed);
            this.Controls.Add(this.lblAlarmTime);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.lblName);
            this.Name = "AlarmFiredForm";
            this.Text = "Alarm Active";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAlarmHeader;
        private System.Windows.Forms.Timer ColorTimer;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Button btnAcknowledge;
        private System.Windows.Forms.Label lblAlarmTime;
        private System.Windows.Forms.Label lblElapsed;
        private System.Windows.Forms.TextBox textBoxMessage;
    }
}