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
using DevExpress.XtraGrid.Views.Base;

namespace Optik_Takip_Sistemi
{
    public partial class FRM_HASTANELER : DevExpress.XtraEditors.XtraForm
    {
        private bool kaydetButonunaBasildi = false;
        dbDataContext db = new dbDataContext();
        public FRM_HASTANELER()
        {
            InitializeComponent();
        }

        public void gridDoldur()
        {
            gc_hastaneler.DataSource = db.Hastanelers;
        }

        private void FRM_HASTANELER_Load(object sender, EventArgs e)
        {
            //GRID NUMERATOR
            gv_hastaneler.IndicatorWidth = 30;
            gv_hastaneler.CustomDrawRowIndicator += gv_hastanelerCustomDrawRowIndicator;

            gridDoldur();
        }

        private void FormuDuzenleModunaGecir(bool duzenlemeAktif)
        {
            gv_hastaneler.OptionsBehavior.Editable = duzenlemeAktif;
                        
            btn_hastaneEkle.Enabled = !duzenlemeAktif;     
            btn_hastaneKaydet.Enabled = duzenlemeAktif;    
            btn_hastaneIptal.Enabled = duzenlemeAktif;     
        }

        private void btn_hastaneEkle_Click(object sender, EventArgs e)
        {
            FormuDuzenleModunaGecir(true);
            gv_hastaneler.AddNewRow();
        }

        private void btn_hastaneIptal_Click(object sender, EventArgs e)
        {
            gv_hastaneler.CancelUpdateCurrentRow();
            FormuDuzenleModunaGecir(false);
        }

        private void btn_hastaneKaydet_Click(object sender, EventArgs e)
        {
            kaydetButonunaBasildi = true;

            try
            {                
                if (gv_hastaneler.PostEditor() && gv_hastaneler.UpdateCurrentRow())
                {
                    
                    MessageBox.Show("Kayıt işlemi başarılı.");
                    FormuDuzenleModunaGecir(false); 
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kayıt sırasında beklenmedik hata: " + ex.Message);
            }
            finally
            {
                kaydetButonunaBasildi = false; 
            }
        }


        //GRIDE NUMERATOR EKLEME
        private void gv_hastanelerCustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            if (e.Info.IsRowIndicator && e.RowHandle >= 0)
            {
                e.Info.DisplayText = (e.RowHandle + 1).ToString();

                e.Info.ImageIndex = -1;
                e.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            }
        }

        private void gv_hastaneler_RowUpdated(object sender, RowObjectEventArgs e)
        {
            try
            {
                var satir = e.Row as Hastaneler;

                if (satir != null)
                {
                    if (satir.Id == 0)
                    {
                        db.Hastanelers.InsertOnSubmit(satir);
                        db.SubmitChanges();
                    }                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata: {ex}");
            }
        }

        private void gv_hastaneler_ValidateRow(object sender, ValidateRowEventArgs e)
        {
            DevExpress.XtraGrid.Views.Grid.GridView view = sender as DevExpress.XtraGrid.Views.Grid.GridView;

            var colHastaneAd = view.Columns["HastaneAd"];
            var colSehir = view.Columns["Sehir"];
            var colIlce = view.Columns["Ilce"];
            var colHastaneKodu = view.Columns["HastaneKodu"];

            string adDegeri = view.GetRowCellValue(e.RowHandle, colHastaneAd)?.ToString();
            string sehirDegeri = view.GetRowCellValue(e.RowHandle, colSehir)?.ToString();
            string ilceDegeri = view.GetRowCellValue(e.RowHandle, colIlce)?.ToString();
            string kodDegeri = view.GetRowCellValue(e.RowHandle, colHastaneKodu)?.ToString();

            
            if (!kaydetButonunaBasildi)
            {
                e.Valid = false;
                e.ErrorText = "Lütfen işlemi tamamlamak için 'KAYDET' butonuna basınız.\nİptal etmek için 'İPTAL' butonunu kullanınız.";
                return;
            }

            
            if (string.IsNullOrWhiteSpace(adDegeri))
            {
                e.Valid = false; 
                e.ErrorText = "Hastane Adı Boş Bırakılamaz!"; 
                view.SetColumnError(colHastaneAd, "Hastane Adı Girilmemiş.");
            }
            else if (string.IsNullOrWhiteSpace(sehirDegeri))
            {
                e.Valid = false;
                e.ErrorText = "Şehir Boş Bırakılamaz!"; 
                view.SetColumnError(colSehir, "Şehir Girilmemiş.");
            }
            else if (string.IsNullOrWhiteSpace(ilceDegeri))
            {
                e.Valid = false;
                e.ErrorText = "İlçe Boş Bırakılamaz!"; 
                view.SetColumnError(colIlce, "İlçe Girilmemiş.");
            }
            else if (string.IsNullOrWhiteSpace(kodDegeri))
            {
                e.Valid = false;
                e.ErrorText = "Hastane Kodu Boş Bırakılamaz!";
                view.SetColumnError(colHastaneKodu, "Hastane Kodu Girilmemiş.");
            }

            bool ayniKayitVarMi = db.Hastanelers.Any(a => a.HastaneKodu == Convert.ToInt32(kodDegeri));
            if (ayniKayitVarMi)
            {
                e.Valid = false;
                e.ErrorText = "Bu Hastane Kodu Sisteme Zaten Kayıtlı!"; 
                //btn_hastaneIptal_Click(sender, e);
            }

        }

        private void gv_hastaneler_InvalidRowException(object sender, InvalidRowExceptionEventArgs e)
        {
            e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.NoAction;
            MessageBox.Show(e.ErrorText, "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}