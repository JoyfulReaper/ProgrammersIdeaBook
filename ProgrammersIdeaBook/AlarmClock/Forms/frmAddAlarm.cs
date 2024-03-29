﻿/*
MIT License

Copyright(c) 2020 Kyle Givler
https://github.com/JoyfulReaper

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.
*/

using AlarmClock.Models;
using System;
using System.Windows.Forms;

namespace AlarmClock.Forms
{
    public partial class frmAddAlarm : Form
    {
        IAlarmModelRequester _caller;
        private readonly IConfig _config;

        public frmAddAlarm(IAlarmModelRequester caller,
            IConfig config)
        {
            this._caller = caller;
            _config = config;
            InitializeComponent();

            textBoxName.Text = $"Alarm: {DateTime.Now.ToString("MM/dd/yy hh:mm")}";

            ResetTimeDatePickerToCurrent();
        }

        private void ResetTimeDatePickerToCurrent()
        {
            dateTimePickerDate.MinDate = DateTime.Now;
            dateTimePickerDate.Value = DateTime.Now;
            dateTimePickerTime.Value = DateTime.Now;

            textBoxName.Text = $"Alarm: {DateTime.Now.ToString("MM/dd/yy hh:mm")}";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            DateTime date;

            date = dateTimePickerDate.Value.Date;
            date = date.Add(dateTimePickerTime.Value.TimeOfDay);

            if (date < DateTime.Now)
            {
                MessageBox.Show("Alarm must be in the future.", "Invalid Alarm");
                return;
            }

            AlarmModel alarm = new AlarmModel { AlarmDateTime = date, Name = textBoxName.Text, Message = textBoxAlarmMessage.Text };

            _config.Connection.SaveAlarm(alarm);
            _caller.AlarmAdded(alarm);

            textBoxAlarmMessage.Text = "";
            textBoxName.Text = $"Alarm: {DateTime.Now.ToString("MM/dd/yy hh:mm")}";

            if(!checkBoxStayOpen.Checked)
            {
                this.Close();
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetTimeDatePickerToCurrent();
        }
    }
}
