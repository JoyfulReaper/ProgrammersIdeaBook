using System.Collections.Generic;
using System.Windows.Forms;

namespace AlarmClock
{
    public partial class MissedAlarmsForm : Form
    {
        List<AlarmModel> expiredAlarms;
        public MissedAlarmsForm(List<AlarmModel> expiredAlarms)
        {
            InitializeComponent();
            this.expiredAlarms = expiredAlarms;
            updateListBox();
        }

        private void updateListBox()
        {
            listBoxMissedAlarms.DataSource = null;
            listBoxMissedAlarms.DataSource = expiredAlarms;
            listBoxMissedAlarms.DisplayMember = nameof(AlarmModel.AlarmDateTime);
        }
    }
}
