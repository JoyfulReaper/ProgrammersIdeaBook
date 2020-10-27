using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AlarmClock
{
    public static class AlarmHelpers
    {
        public static List<AlarmModel> GetExipredAlarmsAndDeleteFromDatabase(List<AlarmModel> alarms)
        {
            var expired = alarms.Where(x => x.AlarmDateTime < DateTime.Now).ToList();
            foreach (AlarmModel alarm in expired)
            {
                GlobalConfig.Connection.DeleteAlarm(alarm);
                alarms.Remove(alarm);
            }

            return expired;
        }
    }
}
