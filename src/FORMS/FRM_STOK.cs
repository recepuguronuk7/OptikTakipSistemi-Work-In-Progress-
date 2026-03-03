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
    public partial class FRM_STOK : DevExpress.XtraEditors.XtraForm
    {
        public FRM_STOK()
        {
            InitializeComponent();
            gridDoldur(gc_stok);
        }

        public void gridDoldur(DevExpress.XtraGrid.GridControl grid)
        {
            using (dbDataContext db = new dbDataContext()) {
                gc_stok.DataSource = db.DukkanStoks.Where(s=> s.Durum == 0).OrderByDescending(s=>s.StokEklenmeTarihi).ToList();                 
                    
            }
        }

        private void gv_stok_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            if (e.RowHandle >= 0)
            {                
                e.Info.DisplayText = (e.RowHandle + 1).ToString();
            }
        }
    }
}