using System;
using System.Windows.Forms;

// TODO Allow alarms to be repeatable
// TODO Find a better way to play sound / Play sound until dismissed
// TODO Add MS SQL implementation

namespace AlarmClock
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            GlobalConfig.InitializeConnection(DatabaseType.SQLite);

            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormAlarmClock());
        }
    }
}
