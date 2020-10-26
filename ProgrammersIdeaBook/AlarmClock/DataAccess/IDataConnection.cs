using System;
using System.Collections.Generic;
using System.Text;

namespace AlarmClock.DataAccess
{
    public interface IDataConnection
    {
        /// <summary>
        /// Receive a list of all alarms that have been set
        /// </summary>
        /// <returns>All alarms</returns>
        List<AlarmModel> GetAllAlarms();

        /// <summary>
        /// Delete an alarm
        /// </summary>
        /// <param name="alarm">The alarm to delete</param>
        void DeleteAlarm(AlarmModel alarm);

        /// <summary>
        /// Save an alarm
        /// </summary>
        /// <param name="alarm">The alarm to save</param>
        void SaveAlarm(AlarmModel alarm);
    }
}
