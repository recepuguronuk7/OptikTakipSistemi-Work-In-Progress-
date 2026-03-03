using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Optik_Takip_Sistemi
{
    public partial class FRM_MUSTERIKAYDET : DevExpress.XtraEditors.XtraForm
    {
        Modul_MusteriIslemleri islem = new Modul_MusteriIslemleri();
        public FRM_MUSTERIKAYDET()
        {
            InitializeComponent();
        }

        private void btn_musteriKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                
                if (islem.MusteriKaydet(t_ad.Text, t_soyad.Text, t_tcno.Text.Replace("-", ""), t_telno.Text.Replace(" ", ""), t_adres.Text)) 
                { 
                    this.Close();
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata: {ex}");
            } 
            
        }
    }
}