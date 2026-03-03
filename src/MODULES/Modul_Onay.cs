using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Optik_Takip_Sistemi
{
    internal class Modul_Onay
    {
        public DialogResult guvenlikOnlemi(string mesaj)
        {
            DialogResult onay = MessageBox.Show(mesaj,
            "Silme Onayı",
            MessageBoxButtons.YesNo, 
            MessageBoxIcon.Question);

            return onay;
        }
    }
}
