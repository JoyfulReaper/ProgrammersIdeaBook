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
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblTime = new System.Windows.Forms.Label();
            this.groupBoxSetDate = new System.Windows.Forms.GroupBox();
            this.dateTimePickerDate = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerTime = new System.Windows.Forms.DateTimePicker();
            this.textBoxAlarmMessage = new System.Windows.Forms.TextBox();
            this.lblMessage = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.lblDate = new System.Windows.Forms.Label();
            this.listBoxAlarms = new System.Windows.Forms.ListBox();
            this.groupBoxModifyAlarms = new System.Windows.Forms.GroupBox();
            this.btnDeleteAlarm = new System.Windows.Forms.Button();
            this.groupBoxSetDate.SuspendLayout();
            this.groupBoxModifyAlarms.SuspendLayout();
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
            // btnAdd
            // 
            this.btnAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Location = new System.Drawing.Point(6, 249);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(130, 45);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add Alarm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTime.Location = new System.Drawing.Point(7, 102);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(63, 30);
            this.lblTime.TabIndex = 0;
            this.lblTime.Text = "Time:";
            // 
            // groupBoxSetDate
            // 
            this.groupBoxSetDate.Controls.Add(this.dateTimePickerDate);
            this.groupBoxSetDate.Controls.Add(this.dateTimePickerTime);
            this.groupBoxSetDate.Controls.Add(this.textBoxAlarmMessage);
            this.groupBoxSetDate.Controls.Add(this.lblMessage);
            this.groupBoxSetDate.Controls.Add(this.btnReset);
            this.groupBoxSetDate.Controls.Add(this.btnAdd);
            this.groupBoxSetDate.Controls.Add(this.lblDate);
            this.groupBoxSetDate.Controls.Add(this.lblTime);
            this.groupBoxSetDate.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBoxSetDate.ForeColor = System.Drawing.Color.Navy;
            this.groupBoxSetDate.Location = new System.Drawing.Point(13, 46);
            this.groupBoxSetDate.Name = "groupBoxSetDate";
            this.groupBoxSetDate.Size = new System.Drawing.Size(282, 306);
            this.groupBoxSetDate.TabIndex = 6;
            this.groupBoxSetDate.TabStop = false;
            this.groupBoxSetDate.Text = "Set Date";
            // 
            // dateTimePickerDate
            // 
            this.dateTimePickerDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateTimePickerDate.Location = new System.Drawing.Point(7, 70);
            this.dateTimePickerDate.Name = "dateTimePickerDate";
            this.dateTimePickerDate.ShowUpDown = true;
            this.dateTimePickerDate.Size = new System.Drawing.Size(255, 29);
            this.dateTimePickerDate.TabIndex = 8;
            // 
            // dateTimePickerTime
            // 
            this.dateTimePickerTime.CalendarFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateTimePickerTime.CustomFormat = "hh:mm tt";
            this.dateTimePickerTime.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateTimePickerTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerTime.Location = new System.Drawing.Point(76, 105);
            this.dateTimePickerTime.Name = "dateTimePickerTime";
            this.dateTimePickerTime.ShowUpDown = true;
            this.dateTimePickerTime.Size = new System.Drawing.Size(114, 33);
            this.dateTimePickerTime.TabIndex = 7;
            // 
            // textBoxAlarmMessage
            // 
            this.textBoxAlarmMessage.AcceptsReturn = true;
            this.textBoxAlarmMessage.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxAlarmMessage.Location = new System.Drawing.Point(6, 174);
            this.textBoxAlarmMessage.Multiline = true;
            this.textBoxAlarmMessage.Name = "textBoxAlarmMessage";
            this.textBoxAlarmMessage.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxAlarmMessage.Size = new System.Drawing.Size(269, 69);
            this.textBoxAlarmMessage.TabIndex = 6;
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMessage.Location = new System.Drawing.Point(7, 141);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(161, 30);
            this.lblMessage.TabIndex = 0;
            this.lblMessage.Text = "Alarm Message:";
            // 
            // btnReset
            // 
            this.btnReset.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnReset.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Location = new System.Drawing.Point(145, 249);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(130, 45);
            this.btnReset.TabIndex = 4;
            this.btnReset.Text = "Reset Time";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDate.Location = new System.Drawing.Point(6, 37);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(62, 30);
            this.lblDate.TabIndex = 0;
            this.lblDate.Text = "Date:";
            // 
            // listBoxAlarms
            // 
            this.listBoxAlarms.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listBoxAlarms.ForeColor = System.Drawing.Color.Navy;
            this.listBoxAlarms.FormattingEnabled = true;
            this.listBoxAlarms.ItemHeight = 21;
            this.listBoxAlarms.Location = new System.Drawing.Point(316, 58);
            this.listBoxAlarms.Name = "listBoxAlarms";
            this.listBoxAlarms.Size = new System.Drawing.Size(204, 298);
            this.listBoxAlarms.TabIndex = 7;
            // 
            // groupBoxModifyAlarms
            // 
            this.groupBoxModifyAlarms.Controls.Add(this.btnDeleteAlarm);
            this.groupBoxModifyAlarms.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBoxModifyAlarms.ForeColor = System.Drawing.Color.Navy;
            this.groupBoxModifyAlarms.Location = new System.Drawing.Point(551, 58);
            this.groupBoxModifyAlarms.Name = "groupBoxModifyAlarms";
            this.groupBoxModifyAlarms.Size = new System.Drawing.Size(241, 298);
            this.groupBoxModifyAlarms.TabIndex = 8;
            this.groupBoxModifyAlarms.TabStop = false;
            this.groupBoxModifyAlarms.Text = "Modify Alarms";
            // 
            // btnDeleteAlarm
            // 
            this.btnDeleteAlarm.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnDeleteAlarm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnDeleteAlarm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteAlarm.Location = new System.Drawing.Point(33, 34);
            this.btnDeleteAlarm.Name = "btnDeleteAlarm";
            this.btnDeleteAlarm.Size = new System.Drawing.Size(174, 45);
            this.btnDeleteAlarm.TabIndex = 0;
            this.btnDeleteAlarm.Text = "Delete Alarm";
            this.btnDeleteAlarm.UseVisualStyleBackColor = true;
            // 
            // FormAlarmClock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(802, 370);
            this.Controls.Add(this.groupBoxModifyAlarms);
            this.Controls.Add(this.listBoxAlarms);
            this.Controls.Add(this.groupBoxSetDate);
            this.Controls.Add(this.lblCurrentTime);
            this.Name = "FormAlarmClock";
            this.Text = "Alarm Clock";
            this.groupBoxSetDate.ResumeLayout(false);
            this.groupBoxSetDate.PerformLayout();
            this.groupBoxModifyAlarms.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCurrentTime;
        private System.Windows.Forms.Timer timerSecond;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.GroupBox groupBoxSetDate;
        private System.Windows.Forms.ListBox listBoxAlarms;
        private System.Windows.Forms.GroupBox groupBoxModifyAlarms;
        private System.Windows.Forms.Button btnDeleteAlarm;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.TextBox textBoxAlarmMessage;
        private System.Windows.Forms.DateTimePicker dateTimePickerTime;
        private System.Windows.Forms.DateTimePicker dateTimePickerDate;
        private System.Windows.Forms.Label lblDate;
    }
}

