using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

            PopulateTextBoxesWithCurrentTime();
        }

        private void UpdateAlarmBox()
        {
            listBoxAlarms.DataSource = null;
            listBoxAlarms.DataSource = alarms;
            listBoxAlarms.DisplayMember = "DateTime";
        }

        private void PopulateTextBoxesWithCurrentTime()
        {
            var now = DateTime.Now;
            textBoxMonth.Text = now.Month.ToString();
            textBoxDay.Text = now.Day.ToString();
            textBoxYear.Text = now.Year.ToString();

            int hour = now.Hour;
            comboBoxAmPm.Items.Add("am");
            comboBoxAmPm.Items.Add("pm");

            if (hour >= 12)
            {
                comboBoxAmPm.SelectedIndex = 1;
                hour -= 12;
            }
            else
            {
                comboBoxAmPm.SelectedIndex = 0;
            }

            textBoxHour.Text = hour.ToString();

            textBoxMinute.Text = now.Minute.ToString();
            if (textBoxMinute.Text.Length != 2)
            {
                textBoxMinute.Text = $"0{textBoxMinute.Text}";
            }

            textBoxSecond.Text = now.Second.ToString();
            if (textBoxSecond.Text.Length != 2)
            {
                textBoxSecond.Text = $"0{textBoxSecond.Text}";
            }
        }

        private void timerSecond_Tick(object sender, EventArgs e)
        {
            lblCurrentTime.Text = $"Current date and time: {DateTime.Now}";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!IsValidForm(out DateTime date))
            {
                MessageBox.Show("Please enter a valid date and time.", "Date Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            alarms.Add(date);
            UpdateAlarmBox();
        }

        private bool IsValidForm(out DateTime date)
        {
            date = new DateTime();

            bool valid = true;
            int day;
            int month;
            int year;
            int hour;
            int minute;
            int second;

            if(!int.TryParse(textBoxDay.Text, out day))
            {
                valid = false;
            }

            if (!int.TryParse(textBoxMonth.Text, out month))
            {
                valid = false;
            }

            if(!int.TryParse(textBoxYear.Text, out year))
            {
                valid = false;
            }

            if (!int.TryParse(textBoxHour.Text, out hour))
            {
                valid = false;
            }

            if (!int.TryParse(textBoxMinute.Text, out minute))
            {
                valid = false;
            }

            if (!int.TryParse(textBoxSecond.Text, out second))
            {
                valid = false;
            }

            if (comboBoxAmPm.SelectedIndex == 1)
            {
                hour += 12;
            }

            try
            {
                date = new DateTime(year, month, day, hour, minute, second);
            }
            catch (ArgumentOutOfRangeException e)
            {
                valid = false;
            }

            return valid;
        }
    }
}
