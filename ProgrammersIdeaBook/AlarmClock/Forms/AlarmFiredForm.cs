using System;
using System.Drawing;
using System.Windows.Forms;

// TODO Use this form instead of a MessageBox for when the alarm is fired

namespace AlarmClock
{
    public partial class AlarmFiredForm : Form
    {
        private bool switchColor = true;
        private AlarmModel alarm;

        public AlarmFiredForm(AlarmModel alarm)
        {
            InitializeComponent();

            this.alarm = alarm;

            lblName.Text = $"Alarm: {alarm.Name}";
            textBoxMessage.Text = $"{alarm.Message}";
            lblAlarmTime.Text = $"Set for: {alarm.AlarmDateTime}";

            UpdateLabels();
        }


        private void UpdateLabels()
        {
            TimeSpan overdue = DateTime.Now - alarm.AlarmDateTime;
            lblElapsed.Text = $"Elapsed: {overdue.Days} Days {overdue.Hours} Hours {overdue.Minutes} Minutes {overdue.Seconds} Seconds";
        }

        private void ColorTimer_Tick(object sender, System.EventArgs e)
        {
            if (switchColor)
            {
                switchColor = false;
                lblAlarmHeader.ForeColor = Color.Red;
            }
            else
            {
                switchColor = true;
                lblAlarmHeader.ForeColor = Color.Navy;
            }

            UpdateLabels();
        }

        private void btnAcknowledge_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
