using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraSplashScreen;


namespace Optik_Takip_Sistemi
{
    public partial class FRM_STOKEKLE : DevExpress.XtraEditors.XtraForm
    {        
        Modul_UTS_islemleri UTSislem = new Modul_UTS_islemleri();
        HashSet<System.Guid> tarananUrunIdleri = new HashSet<System.Guid>();
        dbDataContext db = new dbDataContext();
        BindingList<StokUrunBilgi> UTSList = new BindingList<StokUrunBilgi>();
        public FRM_STOKEKLE()
        {
            InitializeComponent();
            gridDoldur(gc_UTSListesi);

        }

        private void gridDoldur(DevExpress.XtraGrid.GridControl grid)
        {
            using (dbDataContext guncelDb = new dbDataContext())
            {
                grid.DataSource = guncelDb.UTSGelenBildirimlers                                          
                                          .Where(x => x.IslemDurumu == 0)
                                          .OrderByDescending(x => x.OlusturulmaTarihi) 
                                          .ToList();
            }
        }
                
        private void gv_UTSListesi_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
        {
            if (e.RowHandle >= 0)
            {
                
                int durum = Convert.ToInt32(gv_UTSListesi.GetRowCellValue(e.RowHandle, "UTSDurum"));
                string deger = Convert.ToString(gv_UTSListesi.GetRowCellValue(e.RowHandle, "Maliyet"));
                if (durum == 1 && string.IsNullOrWhiteSpace(deger) != true)
                {
                    
                    e.Appearance.BackColor = Color.LightGreen;
                    e.Appearance.BackColor2 = Color.MintCream; 
                }
                else if (durum == 1 && string.IsNullOrWhiteSpace(deger) == true)
                {
                    e.Appearance.BackColor = Color.LightYellow;
                    e.Appearance.BackColor2 = Color.MintCream;
                }
            }
        }

        private void gv_UTSListesi_CustomUnboundColumnData(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs e)
        {
            if (e.Column.FieldName == "BarkodNo" && e.IsGetData)
            {
                var satirVerisi = e.Row as UTSGelenBildirimler;

                if (satirVerisi != null)
                {
                    e.Value = satirVerisi.UrunNo + "-" + satirVerisi.LotBatchNo + satirVerisi.SeriNo;
                }
            }
            if (e.Column.FieldName == "UTSDurum" && e.IsGetData)
            {
                var satirVerisi = e.Row as UTSGelenBildirimler;

                if (satirVerisi == null) return;

                if (tarananUrunIdleri.Contains(satirVerisi.BildirimId))
                {
                    e.Value = 1;
                }
                else
                {
                    e.Value = 0;
                }
            }
            if (e.Column.FieldName == "GonderenKurum" && e.IsGetData)
            {
                var satir = e.Row as UTSGelenBildirimler;

                if (satir != null)
                {
                    
                    if (long.TryParse(satir.DigerKurumNo.ToString(), out long kurumNo))
                    {
                        
                        string kurumAdi = UTSislem.KurumAdiGetir(kurumNo);

                        
                        e.Value = kurumAdi;
                    }
                    else
                    {
                        e.Value = "Geçersiz No";
                    }

                }
            }
        }

        private async void btn_UTSveriCek_Click(object sender, EventArgs e)
        {
            try
            {
                SplashScreenManager.ShowDefaultWaitForm("UTS'den veriler alınıyor");
            }
            catch { }

            try
            {
                await UTSislem.UtsAyrintiliVerileriniCekVeKaydet();
                gridDoldur(gc_UTSListesi);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu: " + ex.Message);
            }
            finally
            {
                try
                {
                    SplashScreenManager.CloseForm();
                }
                catch { }
            }
        }


        private void btn_urunSec_Click(object sender, EventArgs e)
        {
            string okunanBarkod = t_barkodNo.Text;

            if (string.IsNullOrEmpty(okunanBarkod)) return;

            var okunanUrun = db.UTSGelenBildirimlers.FirstOrDefault(o => o.BarkodNo == okunanBarkod);

            if (okunanUrun != null)
            {
                if (tarananUrunIdleri.Contains(okunanUrun.BildirimId))
                {
                    MessageBox.Show("Bu ürün zaten seçildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    tarananUrunIdleri.Add(okunanUrun.BildirimId);
                    gv_UTSListesi.RefreshData();
                    t_barkodNo.Text = "";
                    t_barkodNo.Focus();
                }
            }
            else
            {
                MessageBox.Show("Bu barkod listede bulunamadı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void btn_stokKaydet_Click(object sender, EventArgs e)
        {
            
            gv_UTSListesi.CloseEditor();
            gv_UTSListesi.UpdateCurrentRow();

            
            using (dbDataContext db = new dbDataContext())
            {
                int eklenenAdet = 0;

                
                var gridListesi = gc_UTSListesi.DataSource as List<UTSGelenBildirimler>;
                if (gridListesi == null) return;

                
                foreach (var urun in gridListesi)
                {                    
                    bool okundu = tarananUrunIdleri.Contains(urun.BildirimId);                 

                    if (okundu) 
                    {
                        
                        bool zatenVarMi = db.DukkanStoks.Any(x => x.BildirimId == urun.BildirimId);

                        if (zatenVarMi) continue;

                        try
                        {
                            DukkanStok yeniKayit = new DukkanStok();

                            yeniKayit.UrunTanimi = urun.UrunTanimi;
                            yeniKayit.UrunNo = urun.UrunNo;
                            yeniKayit.LotBatchNo = urun.LotBatchNo;
                            yeniKayit.SeriNo = urun.SeriNo;
                            yeniKayit.BildirimId = urun.BildirimId;
                            yeniKayit.BildirimDurumu = urun.BildirimDurumu;
                            yeniKayit.Adet = urun.Adet;
                            yeniKayit.BelgeNo = urun.BelgeNo;
                            yeniKayit.GonderenKurumNo = urun.DigerKurumNo;
                            yeniKayit.GonderenKurumAdi = urun.GonderenKurumAdi;
                            yeniKayit.BildirimZamani = urun.OlusturulmaTarihi;
                            yeniKayit.VermeTarihi = urun.VermeTarihi;
                            yeniKayit.StokEklenmeTarihi = DateTime.Now;
                            yeniKayit.BarkodNo = urun.BarkodNo;


                            yeniKayit.StokEklenmeTarihi = System.DateTime.Now;

                            db.DukkanStoks.InsertOnSubmit(yeniKayit);


                            var guncellenecekBildirim = db.UTSGelenBildirimlers
                                                        .FirstOrDefault(x => x.BildirimId == urun.BildirimId);

                            if (guncellenecekBildirim != null)
                            {
                                guncellenecekBildirim.IslemDurumu = 1;

                                eklenenAdet++;
                            }
                        }
                        catch (Exception ex)
                        {
                            System.Diagnostics.Debug.WriteLine("Satır hatası: " + ex.Message);
                        }
                    }
                }
               
                if (eklenenAdet > 0)
                {
                    try
                    {
                        
                        db.SubmitChanges();

                        MessageBox.Show($"{eklenenAdet} adet ürün stoğa başarıyla eklendi.", "İşlem Tamam", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                
                        tarananUrunIdleri.Clear();
                        gridDoldur(gc_UTSListesi);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Veritabanına kaydederken hata oluştu: " + ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Kaydedilecek uygun ürün bulunamadı.\n(Barkodu okutulmuş ve maliyeti girilmiş ürün yok veya hepsi zaten kayıtlı)", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
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
    
    /*public partial class UTSGelenBildirimler
    {
       public decimal Maliyet { get; set; }
    }*/
}
