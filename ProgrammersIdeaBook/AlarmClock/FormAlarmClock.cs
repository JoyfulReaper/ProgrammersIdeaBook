using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace AlarmClock
{
    public partial class FormAlarmClock : Form
    {
        private List<AlarmModel> alarms = GlobalConfig.Connection.GetAllAlarms();

        public FormAlarmClock()
        {
            InitializeComponent();

            timerSecond_Tick(this, EventArgs.Empty);
            ResetTimeDatePickerToCurrent();
            UpdateAlarmBox();
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

            var expired = alarms.Where(x => x.AlarmDateTime < DateTime.Now).ToList();
            foreach (AlarmModel alarm in expired)
            {
                GlobalConfig.Connection.DeleteAlarm(alarm);
                alarms.Remove(alarm);
                UpdateAlarmBox();
                MessageBox.Show($"An Alarm has occured!\nMessage: {alarm.Message}", "Alarm", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            ResetTimeDatePickerToCurrent();

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
    }
}
