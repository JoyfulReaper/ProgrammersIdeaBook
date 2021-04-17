/*
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

using AlarmClock.Factories;
using AlarmClock.Helpers;
using AlarmClock.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;

namespace AlarmClock
{
    public partial class frmAlarmClock : Form, IAlarmModelRequester
    {
        private List<AlarmModel> _alarms;
        private readonly IConfig _config;
        private readonly frmAddAlarmFactory _frmAddAlarmFactory;
        private readonly frmMissedAlarmsFactory _frmMissedAlarmsFactory;
        private readonly frmAlarmFiredFactory _frmAlarmFiredFactory;

        public frmAlarmClock(IConfig config,
            frmAddAlarmFactory frmAddAlarmFactory,
            frmMissedAlarmsFactory frmMissedAlarmsFactory,
            frmAlarmFiredFactory frmAlarmFiredFactory)
        {
            _config = config;
            _frmAddAlarmFactory = frmAddAlarmFactory;
            _frmMissedAlarmsFactory = frmMissedAlarmsFactory;
            _frmAlarmFiredFactory = frmAlarmFiredFactory;

            InitializeComponent();
            ClearLabels();

             _alarms = _config.Connection.GetAllAlarms();

            DisplayExpiredAlarms(_alarms);

            lblCredits.Text = $"Alarm Clock {Config.version} by Kyle Givler";

            timerSecond_Tick(this, EventArgs.Empty);
            UpdateForm();
        }

        private void ClearLabels()
        {
            lblName.Text = String.Empty;
            lblExpires.Text = String.Empty;
        }

        private void DisplayExpiredAlarms(List<AlarmModel> alarms)
        {
            var missedAlarms = AlarmHelpers.GetExipredAlarmsAndDeleteFromDatabase(alarms, _config);
            if (missedAlarms.Count > 0)
            {
                //frmMissedAlarms frm = new frmMissedAlarms(missedAlarms);
                _frmMissedAlarmsFactory.Initialize(missedAlarms);
                Form frm = _frmMissedAlarmsFactory.CreateForm();
                frm.ShowDialog(this);
            }
        }

        private void UpdateForm()
        {
            _alarms.Sort((x, y) => DateTime.Compare(x.AlarmDateTime, y.AlarmDateTime));

            listBoxAlarms.DataSource = null;
            listBoxAlarms.DataSource = _alarms;
            listBoxAlarms.DisplayMember = nameof(AlarmModel.Name);
        }

        private void timerSecond_Tick(object sender, EventArgs e)
        {
            lblCurrentTime.Text = $"Current date and time: {DateTime.Now}";

            var expired = AlarmHelpers.GetExipredAlarmsAndDeleteFromDatabase(_alarms, _config);
            if (expired.Count > 0)
            {
                UpdateForm();
            }

            foreach (var alarm in expired)
            {
                //MessageBox.Show($"An Alarm has occured!" +
                //    $"\n\nName: {alarm.Name}\n" +
                //    $"Timestamp:{alarm.AlarmDateTime}\n\n" +
                //    $"Message: {alarm.Message}","Alarm",
                //    MessageBoxButtons.OK, MessageBoxIcon.Information);

                //frmAlarmFired frm = new frmAlarmFired(alarm);

                _frmAlarmFiredFactory.Initialize(alarm);
                Form frm = _frmAlarmFiredFactory.CreateForm();
                frm.Show(this);
            }
        }

        private void btnDeleteAlarm_Click(object sender, EventArgs e)
        {
            AlarmModel selectedAlarm = (AlarmModel)listBoxAlarms.SelectedItem;
            if (selectedAlarm != null)
            {
                _alarms.Remove(selectedAlarm);
                _config.Connection.DeleteAlarm(selectedAlarm);
                UpdateForm();
            }
        }

        private void linkLabelGitHub_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(new ProcessStartInfo("https://github.com/JoyfulReaper") { UseShellExecute = true });
        }

        public void AlarmAdded(AlarmModel alarm)
        {
            _alarms.Add(alarm);
            UpdateForm();
        }

        private void btnAddAlarm_Click(object sender, EventArgs e)
        {
            //frmAddAlarm frm = new frmAddAlarm(this);
            _frmAddAlarmFactory.Initialize(this);
            Form frm = _frmAddAlarmFactory.CreateForm();

            frm.ShowDialog(this);
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