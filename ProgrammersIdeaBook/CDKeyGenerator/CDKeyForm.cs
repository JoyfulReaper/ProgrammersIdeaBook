using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CDKeyGenerator
{
    public partial class CDKeyForm : Form
    {
        public CDKeyForm()
        {
            InitializeComponent();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            //textBoxKey.Text = CipherHelper.VigenereChiper("THISISMYPROGRAM", "PROGRAMVERSIONONE", CipherHelper.Direction.Encipher, false);
            //CreateKey(CipherHelper.VigenereChiper("THISISMYPROGRAM", "PROGRAMVERSIONONE", CipherHelper.Direction.Encipher, false));
            textBoxKey.Text = CreateKey("THISISMYPROGRAM");
        }

        private void btnValidate_Click(object sender, EventArgs e)
        {
            textBoxKey.Text = CipherHelper.VigenereChiper("IYWYZSYTTIGOFNA", "PROGRAMVERSIONONE", CipherHelper.Direction.Decipher, false);
        }

        private string CreateKey(string text)
        {
            var sb = new StringBuilder();
            //var now = DateTime.Now.ToString("MMddyyyyHHmmss").ToArray();
            var now = DateTime.Now.ToString("MMddHHmmss").ToArray();

            foreach (char c in now)
            {
                sb.Append((char)(c + 26));
            }

            sb.Append(CipherHelper.VigenereChiper(text, "PROGRAMVERSIONONE", CipherHelper.Direction.Encipher));

            //MessageBox.Show(sb.ToString());

            //for(int i = 0; i < text.Length; i++)
            //{
            //    sb.Append(text[i]);
            //    if(i < now.Length)
            //    {
            //        sb.Append(now[i]);
            //    }
            //}

            MessageBox.Show(sb.ToString() + " Length: " + sb.ToString().Length);
            return sb.ToString();
        }
    }
}
