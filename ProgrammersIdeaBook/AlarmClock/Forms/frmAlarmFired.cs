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
using System.Drawing;
using System.Windows.Forms;

namespace AlarmClock
{
    public partial class frmAlarmFired : Form
    {
        private bool switchColor = true;
        private AlarmModel alarm;

        public frmAlarmFired(AlarmModel alarm)
        {
            InitializeComponent();

            this.alarm = alarm;

            lblName.Text = $"Alarm: {alarm.Name}";
            textBoxMessage.Text = $"{alarm.Message}";
            lblAlarmTime.Text = $"Set for: {alarm.AlarmDateTime}";

            //TODO do something better!
            var mediaPlayer = new MediaPlayer.MediaPlayer();
            mediaPlayer.FileName = @".\default.mp3";
            mediaPlayer.Play();

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
