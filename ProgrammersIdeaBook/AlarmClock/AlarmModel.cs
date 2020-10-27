using System;
using System.Collections.Generic;
using System.Text;

namespace AlarmClock
{
    public class AlarmModel
    {
        public int Id { get; set; }

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
