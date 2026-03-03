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
    public partial class FRM_ANAMENU : DevExpress.XtraEditors.XtraForm
    {
        public FRM_ANAMENU()
        {
            InitializeComponent();
        }

        private void btn_satisYap_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FRM_SATISYAP frm = new FRM_SATISYAP();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btn_stokEkle_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FRM_STOKEKLE frm = new FRM_STOKEKLE();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btn_UTS_urunAl_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FRM_UTSYENIALMABILDIRIMLERI frm = new FRM_UTSYENIALMABILDIRIMLERI();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btn_Stok_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FRM_STOK frm = new FRM_STOK();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btn_gunlukSatis_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FRM_GUNLUKSATIS frm = new FRM_GUNLUKSATIS();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btn_tumSatislar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FRM_TUMSATISLARIM frm = new FRM_TUMSATISLARIM();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}