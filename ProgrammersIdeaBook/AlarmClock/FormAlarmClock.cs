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
        public FormAlarmClock()
        {
            InitializeComponent();
            timerSecond_Tick(this, EventArgs.Empty);

            var now = DateTime.Now;
            textBoxMonth.Text = now.Month.ToString();
            textBoxDay.Text = now.Day.ToString();
            textBoxYear.Text = now.Year.ToString();

            int hour = now.Hour;
            comboBoxAmPm.Items.Add("am");
            comboBoxAmPm.Items.Add("pm");

            if(hour >= 12)
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
            if(textBoxMinute.Text.Length != 2)
            {
                textBoxMinute.Text = $"0{textBoxMinute.Text}";
            }
            textBoxSecond.Text = now.Second.ToString();
        }

        private void timerSecond_Tick(object sender, EventArgs e)
        {
            lblCurrentTime.Text = $"Current date and time: {DateTime.Now}";
            lbltest.Text = DateTime.Now.Date.Day.ToString();
        }

        private void btnValidiate_Click(object sender, EventArgs e)
        {
            IsValidForm();
        }

        private bool IsValidForm()
        {
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

            try
            {
                DateTime date = new DateTime(year, month, day, hour, minute, second);
            }
            catch (ArgumentOutOfRangeException e)
            {
                valid = false;
            }

            if (!valid)
            {
                MessageBox.Show("Nope!");
            }

            return valid;
        }
    }
}
