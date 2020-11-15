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

using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace AlarmClock
{
    public partial class MissedAlarmsForm : Form
    {
        List<AlarmModel> expiredAlarms;
        public MissedAlarmsForm(List<AlarmModel> expiredAlarms)
        {
            InitializeComponent();
            this.expiredAlarms = expiredAlarms;
            updateListBox();
        }

        private void updateListBox()
        {
            listBoxMissedAlarms.DataSource = null;
            listBoxMissedAlarms.DataSource = expiredAlarms;
            listBoxMissedAlarms.DisplayMember = nameof(AlarmModel.Name);
        }

        private void listBoxMissedAlarms_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            UpdateLables();
        }

        private void UpdateLables()
        {
            if (listBoxMissedAlarms.SelectedItem != null)
            {
                AlarmModel selected = (AlarmModel)listBoxMissedAlarms.SelectedItem;
                TimeSpan overdue = DateTime.Now - selected.AlarmDateTime;

                lblName.Text = $"Name: {selected.Name}";
                lblOverdue.Text = $"Overdue: {overdue.Days} Days {overdue.Hours} Hours {overdue.Minutes} Minutes {overdue.Seconds} Seconds"; // TODO make this look better
                lblExpires.Text = $"Set for: {selected.AlarmDateTime}";
                textBoxMessage.Text = selected.Message;
            }
        }

        private void timerUpdate_Tick(object sender, EventArgs e)
        {
            UpdateLables();
        }

        private void btnDismiss_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
