namespace AlarmClock.Forms
{
    partial class AddAlarmForm
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
            this.groupBoxSetAlarm = new System.Windows.Forms.GroupBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.dateTimePickerDate = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerTime = new System.Windows.Forms.DateTimePicker();
            this.textBoxAlarmMessage = new System.Windows.Forms.TextBox();
            this.lblMessage = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.checkBoxStayOpen = new System.Windows.Forms.CheckBox();
            this.groupBoxSetAlarm.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxSetAlarm
            // 
            this.groupBoxSetAlarm.Controls.Add(this.checkBoxStayOpen);
            this.groupBoxSetAlarm.Controls.Add(this.textBoxName);
            this.groupBoxSetAlarm.Controls.Add(this.dateTimePickerDate);
            this.groupBoxSetAlarm.Controls.Add(this.dateTimePickerTime);
            this.groupBoxSetAlarm.Controls.Add(this.textBoxAlarmMessage);
            this.groupBoxSetAlarm.Controls.Add(this.lblMessage);
            this.groupBoxSetAlarm.Controls.Add(this.btnReset);
            this.groupBoxSetAlarm.Controls.Add(this.btnAdd);
            this.groupBoxSetAlarm.Controls.Add(this.lblName);
            this.groupBoxSetAlarm.Controls.Add(this.lblDate);
            this.groupBoxSetAlarm.Controls.Add(this.lblTime);
            this.groupBoxSetAlarm.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBoxSetAlarm.ForeColor = System.Drawing.Color.Navy;
            this.groupBoxSetAlarm.Location = new System.Drawing.Point(9, 6);
            this.groupBoxSetAlarm.Name = "groupBoxSetAlarm";
            this.groupBoxSetAlarm.Size = new System.Drawing.Size(292, 415);
            this.groupBoxSetAlarm.TabIndex = 6;
            this.groupBoxSetAlarm.TabStop = false;
            this.groupBoxSetAlarm.Text = "Set Alarm";
            // 
            // textBoxName
            // 
            this.textBoxName.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxName.Location = new System.Drawing.Point(6, 64);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(256, 33);
            this.textBoxName.TabIndex = 6;
            // 
            // dateTimePickerDate
            // 
            this.dateTimePickerDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateTimePickerDate.Location = new System.Drawing.Point(7, 134);
            this.dateTimePickerDate.Name = "dateTimePickerDate";
            this.dateTimePickerDate.ShowUpDown = true;
            this.dateTimePickerDate.Size = new System.Drawing.Size(255, 29);
            this.dateTimePickerDate.TabIndex = 1;
            // 
            // dateTimePickerTime
            // 
            this.dateTimePickerTime.CalendarFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateTimePickerTime.CustomFormat = "hh:mm:ss tt";
            this.dateTimePickerTime.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateTimePickerTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerTime.Location = new System.Drawing.Point(76, 169);
            this.dateTimePickerTime.Name = "dateTimePickerTime";
            this.dateTimePickerTime.ShowUpDown = true;
            this.dateTimePickerTime.Size = new System.Drawing.Size(124, 33);
            this.dateTimePickerTime.TabIndex = 2;
            // 
            // textBoxAlarmMessage
            // 
            this.textBoxAlarmMessage.AcceptsReturn = true;
            this.textBoxAlarmMessage.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxAlarmMessage.Location = new System.Drawing.Point(6, 238);
            this.textBoxAlarmMessage.Multiline = true;
            this.textBoxAlarmMessage.Name = "textBoxAlarmMessage";
            this.textBoxAlarmMessage.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxAlarmMessage.Size = new System.Drawing.Size(269, 69);
            this.textBoxAlarmMessage.TabIndex = 3;
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMessage.Location = new System.Drawing.Point(7, 205);
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
            this.btnReset.Location = new System.Drawing.Point(145, 313);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(130, 45);
            this.btnReset.TabIndex = 5;
            this.btnReset.Text = "Reset Time";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Location = new System.Drawing.Point(6, 313);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(130, 45);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add Alarm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblName.Location = new System.Drawing.Point(6, 31);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(135, 30);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Alarm Name:";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDate.Location = new System.Drawing.Point(6, 101);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(62, 30);
            this.lblDate.TabIndex = 0;
            this.lblDate.Text = "Date:";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTime.Location = new System.Drawing.Point(7, 166);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(63, 30);
            this.lblTime.TabIndex = 0;
            this.lblTime.Text = "Time:";
            // 
            // checkBoxStayOpen
            // 
            this.checkBoxStayOpen.AutoSize = true;
            this.checkBoxStayOpen.Checked = true;
            this.checkBoxStayOpen.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxStayOpen.Location = new System.Drawing.Point(25, 364);
            this.checkBoxStayOpen.Name = "checkBoxStayOpen";
            this.checkBoxStayOpen.Size = new System.Drawing.Size(242, 34);
            this.checkBoxStayOpen.TabIndex = 7;
            this.checkBoxStayOpen.Text = "Stay open after adding";
            this.checkBoxStayOpen.UseVisualStyleBackColor = true;
            // 
            // AddAlarmForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(309, 433);
            this.Controls.Add(this.groupBoxSetAlarm);
            this.Name = "AddAlarmForm";
            this.Text = "Add Alarm";
            this.groupBoxSetAlarm.ResumeLayout(false);
            this.groupBoxSetAlarm.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxSetAlarm;
        private System.Windows.Forms.DateTimePicker dateTimePickerDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerTime;
        private System.Windows.Forms.TextBox textBoxAlarmMessage;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.CheckBox checkBoxStayOpen;
    }
}