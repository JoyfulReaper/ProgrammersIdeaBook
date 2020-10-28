using System;
using System.Collections.Generic;
using System.Text;

namespace AlarmClock
{
    public interface IAlarmModelRequester
    {
        void AlarmAdded(AlarmModel alarm);
    }
}
