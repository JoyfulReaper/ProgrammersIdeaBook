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
            listBoxMissedAlarms.DisplayMember = nameof(AlarmModel.Name);
        }

        private void listBoxMissedAlarms_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (listBoxMissedAlarms.SelectedItem != null)
            {
                AlarmModel selected = (AlarmModel)listBoxMissedAlarms.SelectedItem;
                lblName.Text = $"Name: {selected.Name}";
                lblExpires.Text = $"Set for: {selected.AlarmDateTime}";
                textBoxMessage.Text = selected.Message;
            }
        }
    }
}
