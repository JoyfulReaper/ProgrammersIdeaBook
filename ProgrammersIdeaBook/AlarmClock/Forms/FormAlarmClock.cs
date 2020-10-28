using AlarmClock.Forms;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;

namespace AlarmClock
{
    public partial class FormAlarmClock : Form, IAlarmModelRequester
    {
        private List<AlarmModel> alarms = GlobalConfig.Connection.GetAllAlarms();

        public FormAlarmClock()
        {
            InitializeComponent();
            
            DisplayExpiredAlarms(alarms);

            lblCredits.Text = $"Alarm Clock {GlobalConfig.version} by Kyle Givler";

            timerSecond_Tick(this, EventArgs.Empty);

            UpdateForm();
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

        private void UpdateForm()
        {
            alarms.Sort((x, y) => DateTime.Compare(x.AlarmDateTime, y.AlarmDateTime));

            listBoxAlarms.DataSource = null;
            listBoxAlarms.DataSource = alarms;
            listBoxAlarms.DisplayMember = nameof(AlarmModel.Name);
        }

        private void timerSecond_Tick(object sender, EventArgs e)
        {
            lblCurrentTime.Text = $"Current date and time: {DateTime.Now}";

            var expired = AlarmHelpers.GetExipredAlarmsAndDeleteFromDatabase(alarms);
            if (expired.Count > 0)
            {
                UpdateForm();
            }

            foreach (var alarm in expired)
            {
                MessageBox.Show($"An Alarm has occured!" +
                    $"\n\nName: {alarm.Name}\n" +
                    $"Timestamp:{alarm.AlarmDateTime}\n\n" +
                    $"Message: {alarm.Message}","Alarm",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnDeleteAlarm_Click(object sender, EventArgs e)
        {
            AlarmModel selectedAlarm = (AlarmModel)listBoxAlarms.SelectedItem;
            if (selectedAlarm != null)
            {
                alarms.Remove(selectedAlarm);
                GlobalConfig.Connection.DeleteAlarm(selectedAlarm);
                UpdateForm();
            }
        }

        private void linkLabelGitHub_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(new ProcessStartInfo("https://github.com/JoyfulReaper") { UseShellExecute = true });
        }

        public void AlarmAdded(AlarmModel alarm)
        {
            alarms.Add(alarm);
            UpdateForm();
        }

        private void btnAddAlarm_Click(object sender, EventArgs e)
        {
            AddAlarmForm frm = new AddAlarmForm(this);
            frm.Show(this);
        }

        private void listBoxAlarms_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxAlarms.SelectedItem != null)
            {
                AlarmModel selected = (AlarmModel)listBoxAlarms.SelectedItem;
                lblName.Text = $"Name: {selected.Name}";
                lblExpires.Text = $"Set for: {selected.AlarmDateTime}";
                textBoxMessage.Text = selected.Message;
            }
        }
    }
}