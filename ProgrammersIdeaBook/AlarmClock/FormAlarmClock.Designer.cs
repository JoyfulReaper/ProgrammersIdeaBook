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
            this.listBoxAlarms = new System.Windows.Forms.ListBox();
            this.groupBoxSetDate.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCurrentTime
            // 
            this.lblCurrentTime.AutoSize = true;
            this.lblCurrentTime.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
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
            this.textBoxMonth.Location = new System.Drawing.Point(93, 41);
            this.textBoxMonth.Name = "textBoxMonth";
            this.textBoxMonth.Size = new System.Drawing.Size(43, 23);
            this.textBoxMonth.TabIndex = 2;
            // 
            // textBoxDay
            // 
            this.textBoxDay.Location = new System.Drawing.Point(93, 71);
            this.textBoxDay.Name = "textBoxDay";
            this.textBoxDay.Size = new System.Drawing.Size(43, 23);
            this.textBoxDay.TabIndex = 3;
            // 
            // textBoxYear
            // 
            this.textBoxYear.Location = new System.Drawing.Point(93, 101);
            this.textBoxYear.Name = "textBoxYear";
            this.textBoxYear.Size = new System.Drawing.Size(43, 23);
            this.textBoxYear.TabIndex = 3;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(91, 201);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add Alarm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnValidiate_Click);
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
            this.textBoxHour.Location = new System.Drawing.Point(75, 150);
            this.textBoxHour.Name = "textBoxHour";
            this.textBoxHour.Size = new System.Drawing.Size(29, 23);
            this.textBoxHour.TabIndex = 3;
            // 
            // textBoxMinute
            // 
            this.textBoxMinute.Location = new System.Drawing.Point(110, 150);
            this.textBoxMinute.Name = "textBoxMinute";
            this.textBoxMinute.Size = new System.Drawing.Size(29, 23);
            this.textBoxMinute.TabIndex = 3;
            // 
            // textBoxSecond
            // 
            this.textBoxSecond.Location = new System.Drawing.Point(145, 150);
            this.textBoxSecond.Name = "textBoxSecond";
            this.textBoxSecond.Size = new System.Drawing.Size(29, 23);
            this.textBoxSecond.TabIndex = 3;
            // 
            // comboBoxAmPm
            // 
            this.comboBoxAmPm.FormattingEnabled = true;
            this.comboBoxAmPm.Location = new System.Drawing.Point(180, 150);
            this.comboBoxAmPm.Name = "comboBoxAmPm";
            this.comboBoxAmPm.Size = new System.Drawing.Size(55, 23);
            this.comboBoxAmPm.TabIndex = 5;
            // 
            // groupBoxSetDate
            // 
            this.groupBoxSetDate.Controls.Add(this.lblMonth);
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
            this.groupBoxSetDate.Location = new System.Drawing.Point(13, 82);
            this.groupBoxSetDate.Name = "groupBoxSetDate";
            this.groupBoxSetDate.Size = new System.Drawing.Size(257, 245);
            this.groupBoxSetDate.TabIndex = 6;
            this.groupBoxSetDate.TabStop = false;
            this.groupBoxSetDate.Text = "Set Date";
            // 
            // listBoxAlarms
            // 
            this.listBoxAlarms.FormattingEnabled = true;
            this.listBoxAlarms.ItemHeight = 15;
            this.listBoxAlarms.Location = new System.Drawing.Point(292, 82);
            this.listBoxAlarms.Name = "listBoxAlarms";
            this.listBoxAlarms.Size = new System.Drawing.Size(274, 244);
            this.listBoxAlarms.TabIndex = 7;
            // 
            // FormAlarmClock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 361);
            this.Controls.Add(this.listBoxAlarms);
            this.Controls.Add(this.groupBoxSetDate);
            this.Controls.Add(this.lblCurrentTime);
            this.Name = "FormAlarmClock";
            this.Text = "Alarm Clock";
            this.groupBoxSetDate.ResumeLayout(false);
            this.groupBoxSetDate.PerformLayout();
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
    }
}

