using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AlarmClock.Forms
{
    // TODO Stay Open check box
    // Close the form if not checked

    // TODO only allow one of this form open at a time
    // Maybe singleton pattern or something

    public partial class AddAlarmForm : Form
    {
        IAlarmModelRequester caller;
        public AddAlarmForm(IAlarmModelRequester caller)
        {
            this.caller = caller;

            InitializeComponent();

            textBoxName.Text = $"Alarm: {DateTime.Now.ToString("MM/dd/yy hh:mm")}";

            ResetTimeDatePickerToCurrent();
        }

        private void ResetTimeDatePickerToCurrent()
        {
            dateTimePickerDate.MinDate = DateTime.Now;
            dateTimePickerDate.Value = DateTime.Now;

            dateTimePickerTime.Value = DateTime.Now;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            DateTime date;

            date = dateTimePickerDate.Value.Date;
            date = date.Add(dateTimePickerTime.Value.TimeOfDay);
            //date = date.AddSeconds(-date.Second);
            //date = date.AddMilliseconds(-date.Millisecond);

            if (date < DateTime.Now)
            {
                MessageBox.Show("Alarm must be in the future.", "Invalid Alarm");
                return;
            }

            AlarmModel alarm = new AlarmModel { AlarmDateTime = date, Name = textBoxName.Text, Message = textBoxAlarmMessage.Text };

            GlobalConfig.Connection.SaveAlarm(alarm);
            caller.AlarmAdded(alarm);

            textBoxAlarmMessage.Text = "";
            textBoxName.Text = $"Alarm: {DateTime.Now.ToString("MM/dd/yy hh:mm")}";
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetTimeDatePickerToCurrent();
        }
    }
}
