using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace AlarmClock
{
    public class AlarmModel
    {
        /// <summary>
        /// Unique identifier for this alarm
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// The name of this alarm
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The DateTime to trigger the alarm
        /// </summary>
        public DateTime AlarmDateTime { get; set; }

        /// <summary>
        /// The message to display when the alarm time is reached
        /// </summary>
        public string Message { get; set; }
    }
}
