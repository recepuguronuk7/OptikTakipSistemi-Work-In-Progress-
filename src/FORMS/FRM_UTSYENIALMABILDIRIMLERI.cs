using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using DevExpress.Emf.GraphicsPlayer;
using DevExpress.XtraRichEdit.Import.OpenXml;
using DevExpress.XtraSplashScreen;

namespace Optik_Takip_Sistemi
{
    public partial class FRM_UTSYENIALMABILDIRIMLERI : DevExpress.XtraEditors.XtraForm
    {   
        dbDataContext db = new dbDataContext();
        Modul_UTS_islemleri UTSislem= new Modul_UTS_islemleri();
        HashSet<System.Guid> secilenUrunler = new HashSet<System.Guid>();
        public FRM_UTSYENIALMABILDIRIMLERI()
        {
            InitializeComponent();
            gridDoldur(gc_UTSListesi);
        }

        public void gridDoldur(DevExpress.XtraGrid.GridControl grid)
        {
            using (dbDataContext db = new dbDataContext())
            {
                grid.DataSource = db.UTSYeniAlmaBildirimleris
                                  .Where(s=> s.IslemDurumu == 0)
                                  .OrderByDescending(s=> s.BildirimZamani)
                                  .ToList();
            }
        }
        private async void btn_UTSAlmaVeriGuncelle_Click(object sender, EventArgs e)
        {
            SplashScreenManager.ShowDefaultWaitForm("Lütfen Bekleyiniz", "ÜTS ile senkronizasyon yapılıyor...");

            
            var sonuc = await UTSislem.VerileriSenkronizeEt();

            
            SplashScreenManager.CloseForm();

            
            if (sonuc.BasariliMi)
            {
                
                if (sonuc.EklenenSayisi > 0 || sonuc.DusenSayisi > 0)
                {
                    MessageBox.Show($"İşlem Tamamlandı.\n\n" +
                                    $"📥 Yeni Eklenen Ürün: {sonuc.EklenenSayisi}\n" +
                                    $"🗑️ Sistemden Düşen (Harici İşlenen): {sonuc.DusenSayisi}",
                                    "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }               
                

                
                gridDoldur(gc_UTSListesi);
            }
            else
            {
                MessageBox.Show("Senkronizasyon Hatası:\n" + sonuc.Mesaj, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gv_UTSListesi_CustomUnboundColumnData(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs e)
        {
            if (e.IsGetData && e.Column.FieldName == "secim")
            {
                
                object val = gv_UTSListesi.GetListSourceRowCellValue(e.ListSourceRowIndex, "BildirimId");

                if (val != null && val != DBNull.Value)
                {
                    if (Guid.TryParse(val.ToString(), out Guid id))
                    {
                        e.Value = secilenUrunler.Contains(id);
                    }
                    else
                    {
                        e.Value = false; 
                    }
                }
                else
                {
                    e.Value = false; 
                }
            }
        }

        
        private void repositoryItemCheckEdit1_EditValueChanged(object sender, EventArgs e)
        {
            
            gv_UTSListesi.PostEditor();

            
            var editor = sender as DevExpress.XtraEditors.CheckEdit;

            if (editor == null) return;

            
            object idVal = gv_UTSListesi.GetRowCellValue(gv_UTSListesi.FocusedRowHandle, "BildirimId");

            if (idVal != null && Guid.TryParse(idVal.ToString(), out Guid bildirimId))
            {
                
                if (editor.Checked)
                {
                    if (secilenUrunler.Add(bildirimId)) 
                        Console.WriteLine("Eklendi: " + bildirimId);
                }
                else
                {
                    if (secilenUrunler.Remove(bildirimId)) 
                        Console.WriteLine("Silindi: " + bildirimId);
                }

                
                gv_UTSListesi.RefreshData();
            }
        }

        private async void btn_urunleriAl_Click(object sender, EventArgs e)
        {
            if (secilenUrunler.Count == 0)
            {
                MessageBox.Show("Lütfen listeden ürün seçiniz.");
                return;
            }

            
            string onayMesaji = $"{secilenUrunler.Count} adet ürünü almak istediğinize emin misiniz?\n\nBu işlem geri alınamaz!";

            
            if (DevExpress.XtraEditors.XtraMessageBox.Show(onayMesaji, "Kabul Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.Yes)
            {
                return;
            }
            try
            {
                SplashScreenManager.ShowDefaultWaitForm("İşlem Yapılıyor", "Lütfen bekleyiniz...");
            }
            catch
            {
               
            }

            try
            {
                var sonuc = await UTSislem.TopluKabulIsleminiBaslat(secilenUrunler);

                gridDoldur(gc_UTSListesi);

                if (sonuc.Hatali == 0 && !sonuc.SistemHatasiVarMi)
                {
                    secilenUrunler.Clear();
                    che_hepsiniSec.Checked = false;
                }
                               
                SplashScreenManager.CloseForm(false);

                if (sonuc.SistemHatasiVarMi)
                {
                    MessageBox.Show("Sistem Hatası: " + sonuc.SistemHatasiMesaji);
                }
                else
                {
                    string mesaj = $"İşlem Tamamlandı.\n\n✅ Başarılı: {sonuc.Basarili}\n❌ Hatalı: {sonuc.Hatali}";
                    if (sonuc.Hatali > 0) mesaj += "\n\nHatalar:\n" + string.Join("\n", sonuc.HataMesajlari.Take(5));
                    MessageBox.Show(mesaj);
                }
            }
            catch (Exception ex)
            {
                
                SplashScreenManager.CloseForm(false);
                MessageBox.Show("Form Hatası: " + ex.Message);
            }
        }


        

        private void che_hepsiniSec_CheckedChanged(object sender, EventArgs e)
        {
            
            bool tumuSecilsinMi = che_hepsiniSec.Checked;

            
            secilenUrunler.Clear(); 

            if (tumuSecilsinMi)
            {
                
                for (int i = 0; i < gv_UTSListesi.DataRowCount; i++)
                {
                    
                    var idDegeri = gv_UTSListesi.GetRowCellValue(i, "BildirimId");

                    if (idDegeri != null)
                    {
                        if (Guid.TryParse(idDegeri.ToString(), out Guid id))
                        {
                            
                            secilenUrunler.Add(id);
                        }
                    }
                }
            }

            
            gv_UTSListesi.RefreshData();
        }

        private async void btn_iptal_Click(object sender, EventArgs e)
        {
            
            if (secilenUrunler.Count == 0)
            {
                MessageBox.Show("Lütfen listeden ürün seçiniz.");
                return;
            }

            
            string onayMesaji = $"{secilenUrunler.Count} adet ürünü REDDETMEK istediğinize emin misiniz?\n\nBu işlem geri alınamaz!";

            
            if (DevExpress.XtraEditors.XtraMessageBox.Show(onayMesaji, "Red Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.Yes)
            {
                return;
            }

            
            string redSebebi = DevExpress.XtraEditors.XtraInputBox.Show(
                "Lütfen red gerekçesini giriniz:",
                "Red İşlemi",
                "Ürün hasarlı / Yanlış ürün"
            );

            if (string.IsNullOrEmpty(redSebebi))
            {
                MessageBox.Show("Red işlemi için açıklama girmek zorunludur.");
                return;
            }

            // 3. SPLASH VE İŞLEM BAŞLAT
            try
            {
                SplashScreenManager.ShowDefaultWaitForm("İşlem Yapılıyor", "Ürünler reddediliyor...");
            }
            catch { }

            try
            {
                
                var sonuc = await UTSislem.TopluRedIsleminiBaslat(secilenUrunler, redSebebi);

                
                gridDoldur(gc_UTSListesi);

                
                if (sonuc.Hatali == 0 && !sonuc.SistemHatasiVarMi)
                {
                    secilenUrunler.Clear();
                    che_hepsiniSec.Checked = false;
                }

                SplashScreenManager.CloseForm(false);

                
                if (sonuc.SistemHatasiVarMi)
                {
                    MessageBox.Show("Sistem Hatası: " + sonuc.SistemHatasiMesaji);
                }
                else
                {
                    
                    string sonucMesaji = $"RED İşlemi Tamamlandı.\n\n✅ Başarılı: {sonuc.Basarili}\n❌ Hatalı: {sonuc.Hatali}";

                    if (sonuc.Hatali > 0)
                        sonucMesaji += "\n\nHatalar:\n" + string.Join("\n", sonuc.HataMesajlari.Take(5));

                    MessageBox.Show(sonucMesaji, "İşlem Sonucu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                SplashScreenManager.CloseForm(false);
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        private void gv_UTSListesi_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            if (e.RowHandle >= 0)
            {                
                e.Info.DisplayText = (e.RowHandle + 1).ToString();
            }
        }
    }
}