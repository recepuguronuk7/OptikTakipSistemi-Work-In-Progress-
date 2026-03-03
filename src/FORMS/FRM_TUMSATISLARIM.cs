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
    
    public partial class FRM_TUMSATISLARIM : DevExpress.XtraEditors.XtraForm
    {
        DevExpress.Data.Linq.EntityInstantFeedbackSource instantSource;
        Modul_SatisBilgileri satisIslem = new Modul_SatisBilgileri();
        public FRM_TUMSATISLARIM()
        {
            InitializeComponent();
        }

        private void FRM_TUMSATISLARIM_Load(object sender, EventArgs e)
        {
            instantSource = new DevExpress.Data.Linq.EntityInstantFeedbackSource();

            instantSource.KeyExpression = "SatisBenzersizId";

            instantSource.GetQueryable += instantSource_GetQueryable;

            instantSource.DismissQueryable += instantSource_DismissQueryable;
            
            gc_tumSatislar.DataSource = instantSource;
        }

        void instantSource_GetQueryable(object sender,DevExpress.Data.Linq.GetQueryableEventArgs e)
        {
            dbDataContext db = new dbDataContext();

            e.Tag = db;

            e.QueryableSource = db.tumSatislarQueries;
        }

        void instantSource_DismissQueryable(object sender, DevExpress.Data.Linq.GetQueryableEventArgs e)
        {
            if(e.Tag is dbDataContext db)
            {
                db.Dispose();
            }
        }

        private void repositoryItemButtonEdit1_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            int musteriId = Convert.ToInt32(gv_tumSatislar.GetFocusedRowCellValue("MusteriId"));

            if (musteriId != null) 
            {
                FRM_MUSTERIBILGI frm = new FRM_MUSTERIBILGI(musteriId);
                frm.ShowDialog();
            }
        }

        private void gv_tumSatislar_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            if (e.RowHandle >= 0)
            {
                // Satır numarası = RowHandle (0'dan başlar) + 1
                e.Info.DisplayText = (e.RowHandle + 1).ToString();
            }
        }
    }
}