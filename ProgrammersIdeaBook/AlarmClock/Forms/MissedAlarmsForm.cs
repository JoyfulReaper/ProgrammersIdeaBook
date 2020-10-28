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
