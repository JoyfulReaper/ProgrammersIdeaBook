using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CDKeyGenerator
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //var x = CipherHelper.CaesarEncipher("ABCabc", 1);
            var x = CipherHelper.CaesarEncipher("ABCabc", 27);
            var y = CipherHelper.CeasarDecipher("BCDbcd", 27);
            MessageBox.Show($"{x}");
            MessageBox.Show($"{y}");


            return;
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new CDKeyForm());
        }
    }
}
