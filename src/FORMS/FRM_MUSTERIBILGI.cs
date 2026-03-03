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
    public partial class FRM_MUSTERIBILGI : DevExpress.XtraEditors.XtraForm
    {
        int _musteriId;
        public FRM_MUSTERIBILGI(int musteriId)
        {
            _musteriId = musteriId;
            InitializeComponent();
            textDoldur();
            gridDoldur(gc_yapilanAlimlar);
            
        }

        public void gridDoldur(DevExpress.XtraGrid.GridControl grid)
        {
            using (dbDataContext db = new dbDataContext()) 
            {
                gc_yapilanAlimlar.DataSource = db.musteriyeAitTumRecetelers.Where(s=> s.MusteriId == _musteriId).ToList();

            }            
        }

        public void textDoldur()
        {
            using (dbDataContext db = new dbDataContext()) 
            {
                var musteriBilgi = db.Musterilers.FirstOrDefault(s => s.MusteriId == _musteriId);

                t_ad.Text = musteriBilgi.Ad;
                t_soyad.Text = musteriBilgi.Soyad;
                t_TCNo.Text = musteriBilgi.TCNo;
                t_telNo.Text = musteriBilgi.TelNo;
                t_adres.Text = musteriBilgi.Adres;
            }
            
        }

        private void gv_yapilanAlimlar_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            if (e.RowHandle >= 0)
            {                
                e.Info.DisplayText = (e.RowHandle + 1).ToString();
            }
        }
    }
}