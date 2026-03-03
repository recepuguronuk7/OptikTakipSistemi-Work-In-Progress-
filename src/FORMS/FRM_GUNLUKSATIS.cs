using DevExpress.XtraEditors;
using DevExpress.XtraRichEdit.Import.OpenXml;
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
    public partial class FRM_GUNLUKSATIS : DevExpress.XtraEditors.XtraForm
    {
        Modul_SatisBilgileri satisBilgi = new Modul_SatisBilgileri();
        public FRM_GUNLUKSATIS()
        {
            InitializeComponent();
            gridDoldur(gc_gunlukSatis);
        }

        public void gridDoldur(DevExpress.XtraGrid.GridControl grid)
        {

            List<SatisBilgileri> satilanUrunler = satisBilgi.SatisBilgileriGetir_Bugun();
            grid.DataSource = satilanUrunler.ToList();


        }

        private void gv_gunlukSatis_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            if (e.RowHandle >= 0)
            {                
                e.Info.DisplayText = (e.RowHandle + 1).ToString();
            }
        }
    }
}