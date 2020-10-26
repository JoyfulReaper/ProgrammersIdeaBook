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
            this.lbltest = new System.Windows.Forms.Label();
            this.lblDay = new System.Windows.Forms.Label();
            this.lblMonth = new System.Windows.Forms.Label();
            this.lblYear = new System.Windows.Forms.Label();
            this.textBoxMonth = new System.Windows.Forms.TextBox();
            this.textBoxDay = new System.Windows.Forms.TextBox();
            this.textBoxYear = new System.Windows.Forms.TextBox();
            this.btnValidiate = new System.Windows.Forms.Button();
            this.lblTime = new System.Windows.Forms.Label();
            this.textBoxHour = new System.Windows.Forms.TextBox();
            this.textBoxMinute = new System.Windows.Forms.TextBox();
            this.textBoxSecond = new System.Windows.Forms.TextBox();
            this.comboBoxAmPm = new System.Windows.Forms.ComboBox();
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
            // lbltest
            // 
            this.lbltest.AutoSize = true;
            this.lbltest.Location = new System.Drawing.Point(30, 409);
            this.lbltest.Name = "lbltest";
            this.lbltest.Size = new System.Drawing.Size(26, 15);
            this.lbltest.TabIndex = 1;
            this.lbltest.Text = "test";
            // 
            // lblDay
            // 
            this.lblDay.AutoSize = true;
            this.lblDay.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDay.Location = new System.Drawing.Point(12, 87);
            this.lblDay.Name = "lblDay";
            this.lblDay.Size = new System.Drawing.Size(54, 30);
            this.lblDay.TabIndex = 0;
            this.lblDay.Text = "Day:";
            // 
            // lblMonth
            // 
            this.lblMonth.AutoSize = true;
            this.lblMonth.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMonth.Location = new System.Drawing.Point(12, 57);
            this.lblMonth.Name = "lblMonth";
            this.lblMonth.Size = new System.Drawing.Size(80, 30);
            this.lblMonth.TabIndex = 0;
            this.lblMonth.Text = "Month:";
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblYear.Location = new System.Drawing.Point(12, 117);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(57, 30);
            this.lblYear.TabIndex = 0;
            this.lblYear.Text = "Year:";
            // 
            // textBoxMonth
            // 
            this.textBoxMonth.Location = new System.Drawing.Point(99, 66);
            this.textBoxMonth.Name = "textBoxMonth";
            this.textBoxMonth.Size = new System.Drawing.Size(100, 23);
            this.textBoxMonth.TabIndex = 2;
            // 
            // textBoxDay
            // 
            this.textBoxDay.Location = new System.Drawing.Point(99, 96);
            this.textBoxDay.Name = "textBoxDay";
            this.textBoxDay.Size = new System.Drawing.Size(100, 23);
            this.textBoxDay.TabIndex = 3;
            // 
            // textBoxYear
            // 
            this.textBoxYear.Location = new System.Drawing.Point(99, 126);
            this.textBoxYear.Name = "textBoxYear";
            this.textBoxYear.Size = new System.Drawing.Size(100, 23);
            this.textBoxYear.TabIndex = 3;
            // 
            // btnValidiate
            // 
            this.btnValidiate.Location = new System.Drawing.Point(62, 405);
            this.btnValidiate.Name = "btnValidiate";
            this.btnValidiate.Size = new System.Drawing.Size(75, 23);
            this.btnValidiate.TabIndex = 4;
            this.btnValidiate.Text = "Validate";
            this.btnValidiate.UseVisualStyleBackColor = true;
            this.btnValidiate.Click += new System.EventHandler(this.btnValidiate_Click);
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTime.Location = new System.Drawing.Point(9, 177);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(63, 30);
            this.lblTime.TabIndex = 0;
            this.lblTime.Text = "Time:";
            // 
            // textBoxHour
            // 
            this.textBoxHour.Location = new System.Drawing.Point(78, 184);
            this.textBoxHour.Name = "textBoxHour";
            this.textBoxHour.Size = new System.Drawing.Size(29, 23);
            this.textBoxHour.TabIndex = 3;
            // 
            // textBoxMinute
            // 
            this.textBoxMinute.Location = new System.Drawing.Point(113, 184);
            this.textBoxMinute.Name = "textBoxMinute";
            this.textBoxMinute.Size = new System.Drawing.Size(29, 23);
            this.textBoxMinute.TabIndex = 3;
            // 
            // textBoxSecond
            // 
            this.textBoxSecond.Location = new System.Drawing.Point(148, 184);
            this.textBoxSecond.Name = "textBoxSecond";
            this.textBoxSecond.Size = new System.Drawing.Size(29, 23);
            this.textBoxSecond.TabIndex = 3;
            // 
            // comboBoxAmPm
            // 
            this.comboBoxAmPm.FormattingEnabled = true;
            this.comboBoxAmPm.Location = new System.Drawing.Point(183, 184);
            this.comboBoxAmPm.Name = "comboBoxAmPm";
            this.comboBoxAmPm.Size = new System.Drawing.Size(55, 23);
            this.comboBoxAmPm.TabIndex = 5;
            // 
            // FormAlarmClock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBoxAmPm);
            this.Controls.Add(this.btnValidiate);
            this.Controls.Add(this.textBoxSecond);
            this.Controls.Add(this.textBoxMinute);
            this.Controls.Add(this.textBoxHour);
            this.Controls.Add(this.textBoxYear);
            this.Controls.Add(this.textBoxDay);
            this.Controls.Add(this.textBoxMonth);
            this.Controls.Add(this.lbltest);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblYear);
            this.Controls.Add(this.lblMonth);
            this.Controls.Add(this.lblDay);
            this.Controls.Add(this.lblCurrentTime);
            this.Name = "FormAlarmClock";
            this.Text = "Alarm Clock";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCurrentTime;
        private System.Windows.Forms.Timer timerSecond;
        private System.Windows.Forms.Label lbltest;
        private System.Windows.Forms.Label lblDay;
        private System.Windows.Forms.Label lblMonth;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.TextBox textBoxMonth;
        private System.Windows.Forms.TextBox textBoxDay;
        private System.Windows.Forms.TextBox textBoxYear;
        private System.Windows.Forms.Button btnValidiate;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.TextBox textBoxHour;
        private System.Windows.Forms.TextBox textBoxMinute;
        private System.Windows.Forms.TextBox textBoxSecond;
        private System.Windows.Forms.ComboBox comboBoxAmPm;
    }
}

