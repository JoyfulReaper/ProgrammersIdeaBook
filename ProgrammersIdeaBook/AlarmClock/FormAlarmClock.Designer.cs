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
            this.lblDay = new System.Windows.Forms.Label();
            this.lblMonth = new System.Windows.Forms.Label();
            this.lblYear = new System.Windows.Forms.Label();
            this.textBoxMonth = new System.Windows.Forms.TextBox();
            this.textBoxDay = new System.Windows.Forms.TextBox();
            this.textBoxYear = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblTime = new System.Windows.Forms.Label();
            this.textBoxHour = new System.Windows.Forms.TextBox();
            this.textBoxMinute = new System.Windows.Forms.TextBox();
            this.textBoxSecond = new System.Windows.Forms.TextBox();
            this.comboBoxAmPm = new System.Windows.Forms.ComboBox();
            this.groupBoxSetDate = new System.Windows.Forms.GroupBox();
            this.btnReset = new System.Windows.Forms.Button();
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
            // lblDay
            // 
            this.lblDay.AutoSize = true;
            this.lblDay.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDay.Location = new System.Drawing.Point(6, 62);
            this.lblDay.Name = "lblDay";
            this.lblDay.Size = new System.Drawing.Size(54, 30);
            this.lblDay.TabIndex = 0;
            this.lblDay.Text = "Day:";
            // 
            // lblMonth
            // 
            this.lblMonth.AutoSize = true;
            this.lblMonth.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMonth.Location = new System.Drawing.Point(6, 32);
            this.lblMonth.Name = "lblMonth";
            this.lblMonth.Size = new System.Drawing.Size(80, 30);
            this.lblMonth.TabIndex = 0;
            this.lblMonth.Text = "Month:";
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblYear.Location = new System.Drawing.Point(6, 92);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(57, 30);
            this.lblYear.TabIndex = 0;
            this.lblYear.Text = "Year:";
            // 
            // textBoxMonth
            // 
            this.textBoxMonth.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxMonth.Location = new System.Drawing.Point(93, 41);
            this.textBoxMonth.Name = "textBoxMonth";
            this.textBoxMonth.Size = new System.Drawing.Size(43, 25);
            this.textBoxMonth.TabIndex = 2;
            // 
            // textBoxDay
            // 
            this.textBoxDay.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxDay.Location = new System.Drawing.Point(93, 71);
            this.textBoxDay.Name = "textBoxDay";
            this.textBoxDay.Size = new System.Drawing.Size(43, 25);
            this.textBoxDay.TabIndex = 3;
            // 
            // textBoxYear
            // 
            this.textBoxYear.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxYear.Location = new System.Drawing.Point(93, 101);
            this.textBoxYear.Name = "textBoxYear";
            this.textBoxYear.Size = new System.Drawing.Size(43, 25);
            this.textBoxYear.TabIndex = 3;
            // 
            // btnAdd
            // 
            this.btnAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Location = new System.Drawing.Point(6, 181);
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
            this.lblTime.Location = new System.Drawing.Point(6, 143);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(63, 30);
            this.lblTime.TabIndex = 0;
            this.lblTime.Text = "Time:";
            // 
            // textBoxHour
            // 
            this.textBoxHour.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxHour.Location = new System.Drawing.Point(75, 150);
            this.textBoxHour.Name = "textBoxHour";
            this.textBoxHour.Size = new System.Drawing.Size(29, 25);
            this.textBoxHour.TabIndex = 3;
            // 
            // textBoxMinute
            // 
            this.textBoxMinute.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxMinute.Location = new System.Drawing.Point(110, 150);
            this.textBoxMinute.Name = "textBoxMinute";
            this.textBoxMinute.Size = new System.Drawing.Size(29, 25);
            this.textBoxMinute.TabIndex = 3;
            // 
            // textBoxSecond
            // 
            this.textBoxSecond.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxSecond.Location = new System.Drawing.Point(145, 150);
            this.textBoxSecond.Name = "textBoxSecond";
            this.textBoxSecond.Size = new System.Drawing.Size(29, 25);
            this.textBoxSecond.TabIndex = 3;
            // 
            // comboBoxAmPm
            // 
            this.comboBoxAmPm.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxAmPm.FormattingEnabled = true;
            this.comboBoxAmPm.Location = new System.Drawing.Point(180, 150);
            this.comboBoxAmPm.Name = "comboBoxAmPm";
            this.comboBoxAmPm.Size = new System.Drawing.Size(55, 25);
            this.comboBoxAmPm.TabIndex = 5;
            // 
            // groupBoxSetDate
            // 
            this.groupBoxSetDate.Controls.Add(this.lblMonth);
            this.groupBoxSetDate.Controls.Add(this.btnReset);
            this.groupBoxSetDate.Controls.Add(this.btnAdd);
            this.groupBoxSetDate.Controls.Add(this.comboBoxAmPm);
            this.groupBoxSetDate.Controls.Add(this.lblDay);
            this.groupBoxSetDate.Controls.Add(this.lblYear);
            this.groupBoxSetDate.Controls.Add(this.textBoxSecond);
            this.groupBoxSetDate.Controls.Add(this.textBoxMonth);
            this.groupBoxSetDate.Controls.Add(this.textBoxMinute);
            this.groupBoxSetDate.Controls.Add(this.textBoxDay);
            this.groupBoxSetDate.Controls.Add(this.textBoxHour);
            this.groupBoxSetDate.Controls.Add(this.textBoxYear);
            this.groupBoxSetDate.Controls.Add(this.lblTime);
            this.groupBoxSetDate.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBoxSetDate.ForeColor = System.Drawing.Color.Navy;
            this.groupBoxSetDate.Location = new System.Drawing.Point(13, 82);
            this.groupBoxSetDate.Name = "groupBoxSetDate";
            this.groupBoxSetDate.Size = new System.Drawing.Size(282, 245);
            this.groupBoxSetDate.TabIndex = 6;
            this.groupBoxSetDate.TabStop = false;
            this.groupBoxSetDate.Text = "Set Date";
            // 
            // btnReset
            // 
            this.btnReset.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnReset.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Location = new System.Drawing.Point(142, 181);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(130, 45);
            this.btnReset.TabIndex = 4;
            this.btnReset.Text = "Reset Time";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // listBoxAlarms
            // 
            this.listBoxAlarms.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listBoxAlarms.ForeColor = System.Drawing.Color.Navy;
            this.listBoxAlarms.FormattingEnabled = true;
            this.listBoxAlarms.ItemHeight = 21;
            this.listBoxAlarms.Location = new System.Drawing.Point(324, 98);
            this.listBoxAlarms.Name = "listBoxAlarms";
            this.listBoxAlarms.Size = new System.Drawing.Size(204, 214);
            this.listBoxAlarms.TabIndex = 7;
            // 
            // groupBoxModifyAlarms
            // 
            this.groupBoxModifyAlarms.Controls.Add(this.btnDeleteAlarm);
            this.groupBoxModifyAlarms.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBoxModifyAlarms.ForeColor = System.Drawing.Color.Navy;
            this.groupBoxModifyAlarms.Location = new System.Drawing.Point(551, 82);
            this.groupBoxModifyAlarms.Name = "groupBoxModifyAlarms";
            this.groupBoxModifyAlarms.Size = new System.Drawing.Size(241, 245);
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
            this.ClientSize = new System.Drawing.Size(820, 369);
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
        private System.Windows.Forms.Label lblDay;
        private System.Windows.Forms.Label lblMonth;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.TextBox textBoxMonth;
        private System.Windows.Forms.TextBox textBoxDay;
        private System.Windows.Forms.TextBox textBoxYear;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.TextBox textBoxHour;
        private System.Windows.Forms.TextBox textBoxMinute;
        private System.Windows.Forms.TextBox textBoxSecond;
        private System.Windows.Forms.ComboBox comboBoxAmPm;
        private System.Windows.Forms.GroupBox groupBoxSetDate;
        private System.Windows.Forms.ListBox listBoxAlarms;
        private System.Windows.Forms.GroupBox groupBoxModifyAlarms;
        private System.Windows.Forms.Button btnDeleteAlarm;
        private System.Windows.Forms.Button btnReset;
    }
}

