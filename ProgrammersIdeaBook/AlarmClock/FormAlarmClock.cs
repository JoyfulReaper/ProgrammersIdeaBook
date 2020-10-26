using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace AlarmClock
{
    public partial class FormAlarmClock : Form
    {
        private List<DateTime> alarms = new List<DateTime>();

        public FormAlarmClock()
        {
            InitializeComponent();

            timerSecond_Tick(this, EventArgs.Empty);

            dateTimePickerDate.MinDate = DateTime.Now;

            PopulateTextBoxesWithCurrentTime();
        }

        private void UpdateAlarmBox()
        {
            listBoxAlarms.DataSource = null;
            listBoxAlarms.DataSource = alarms;
            listBoxAlarms.DisplayMember = nameof(DateTime);
        }

        private void PopulateTextBoxesWithCurrentTime()
        {
            dateTimePickerTime.Value = DateTime.Now;
        }

        private void timerSecond_Tick(object sender, EventArgs e)
        {
            lblCurrentTime.Text = $"Current date and time: {DateTime.Now}";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            DateTime date = new DateTime();
            date = dateTimePickerDate.Value.Date;
            date = date.Add(dateTimePickerTime.Value.TimeOfDay);
            alarms.Add(date);
            UpdateAlarmBox();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            PopulateTextBoxesWithCurrentTime();
        }
    }
}
