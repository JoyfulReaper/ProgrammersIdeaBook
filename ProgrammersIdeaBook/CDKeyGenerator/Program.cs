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
            string s0 = "Beware the Jabberwock, my son! The jaws that bite, the claws that catch!",
            pw = "VIGENERECIPHER";

            var out1 = CipherHelper.VigenereChiper(s0, pw, CipherHelper.Direction.Encipher, false);
            var out2 = CipherHelper.VigenereChiper(out1, pw, CipherHelper.Direction.Decipher, false);

            MessageBox.Show(out1);
            MessageBox.Show(out2);

            var x = CipherHelper.CaesarEncipher("I eat!", 27, false);
            var y = CipherHelper.CeasarDecipher("jfbu", 27);
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
