using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;

namespace AlarmClock
{
    public partial class FormAlarmClock : Form
    {
        private List<AlarmModel> alarms = GlobalConfig.Connection.GetAllAlarms();

        public FormAlarmClock()
        {
            InitializeComponent();
            
            DisplayExpiredAlarms(alarms);

            timerSecond_Tick(this, EventArgs.Empty);

            ResetTimeDatePickerToCurrent();

            UpdateAlarmBox();
        }

        private void DisplayExpiredAlarms(List<AlarmModel> alarms)
        {
            var missedAlarms = AlarmHelpers.GetExipredAlarmsAndDeleteFromDatabase(alarms);
            if (missedAlarms.Count > 0)
            {
                MissedAlarmsForm frm = new MissedAlarmsForm(missedAlarms);
                frm.Show(this);
            }
        }

        private void ResetTimeDatePickerToCurrent()
        {
            dateTimePickerDate.MinDate = DateTime.Now;
            dateTimePickerDate.Value = DateTime.Now;

            dateTimePickerTime.Value = DateTime.Now;
        }

        private void UpdateAlarmBox()
        {
            alarms.Sort((x, y) => DateTime.Compare(x.AlarmDateTime, y.AlarmDateTime));

            listBoxAlarms.DataSource = null;
            listBoxAlarms.DataSource = alarms;
            listBoxAlarms.DisplayMember = nameof(AlarmModel.AlarmDateTime);
        }

        private void timerSecond_Tick(object sender, EventArgs e)
        {
            lblCurrentTime.Text = $"Current date and time: {DateTime.Now}";

            var expired = AlarmHelpers.GetExipredAlarmsAndDeleteFromDatabase(alarms);

            UpdateAlarmBox();

            foreach (var alarm in expired)
            {
                MessageBox.Show($"An Alarm has occured!" +
                    $"\nTimestamp:{alarm.AlarmDateTime}\n" +
                    $"Message: {alarm.Message}","Alarm",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
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

            AlarmModel alarm = new AlarmModel { AlarmDateTime = date, Message = textBoxAlarmMessage.Text };

            GlobalConfig.Connection.SaveAlarm(alarm);
            alarms.Add(alarm);

            textBoxAlarmMessage.Text = "";

            UpdateAlarmBox();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetTimeDatePickerToCurrent();
        }

        private void btnDeleteAlarm_Click(object sender, EventArgs e)
        {
            AlarmModel selectedAlarm = (AlarmModel)listBoxAlarms.SelectedItem;
            if (selectedAlarm != null)
            {
                alarms.Remove(selectedAlarm);
                GlobalConfig.Connection.DeleteAlarm(selectedAlarm);
                UpdateAlarmBox();
            }
        }

        private void linkLabelGitHub_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(new ProcessStartInfo("https://github.com/JoyfulReaper") { UseShellExecute = true });
        }
    }
}