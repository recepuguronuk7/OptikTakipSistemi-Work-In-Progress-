using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace Optik_Takip_Sistemi
    
{
    public partial class FRM_SATISYAP : DevExpress.XtraEditors.XtraForm
    {
        Modul_Ek ekModuller = new Modul_Ek();
        Modul_MusteriIslemleri islem = new Modul_MusteriIslemleri();
        Modul_UrunIslemleri urunIslem = new Modul_UrunIslemleri();
        Modul_ReceteKayit receteIslem = new Modul_ReceteKayit();
        Modul_Onay onayMesajı = new Modul_Onay();

        dbDataContext db = new dbDataContext();
        BindingList<StokUrunBilgi> urunListesi = new BindingList<StokUrunBilgi>();
        public FRM_SATISYAP()
        {
            InitializeComponent();
            rdg_ReceteTuru.SelectedIndex = 0;
        }

        public void lueHastaneDoldur()
        {
            dbDataContext db = new dbDataContext();
            var hastaneler = db.Hastanelers.Select(s => new { s.Id, s.HastaneAd });
            lue_Hastaneler.Properties.DataSource = hastaneler;
        }
        
        public void urunListesiDoldur(DevExpress.XtraGrid.GridControl gridControl)
        {
            gridControl.DataSource = urunListesi;

        }
        private void FRM_SATISYAP_Load(object sender, EventArgs e)
        {
            lueHastaneDoldur();
            urunListesiDoldur(gc_urunListele);
            urunListesiDoldur(gc_odeme);
        }

        //Uzak ve Yakın labellerini dikey yapma.
        private void lbl_uzak_Paint(object sender, PaintEventArgs e)
        {
            ekModuller.Angle(sender, e);
        }

        private void lbl_yakin_Paint(object sender, PaintEventArgs e)
        {
            ekModuller.Angle(sender, e);
        }
        private void lbl_uzakLens_Paint(object sender, PaintEventArgs e)
        {
            ekModuller.Angle(sender, e);
        }

        private void lbl_yakinLens_Paint(object sender, PaintEventArgs e)
        {
            ekModuller.Angle(sender, e);
        }

        //Radiogroup seçimine göre navigator sayfasını değiştirme.
        private void rdg_ReceteTuru_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (rdg_ReceteTuru.SelectedIndex == 1) { nvg_Dioptri.SelectedPage = nvgPage_ReceteLens; }
            else { nvg_Dioptri.SelectedPage = nvgPage_ReceteGozluk; }
        }

        private void btn_yeniMusteriKaydi_Click(object sender, EventArgs e)
        {
            FRM_MUSTERIKAYDET kayit = new FRM_MUSTERIKAYDET();
            kayit.ShowDialog();
        }

        private void btn_sorgula_Click(object sender, EventArgs e)
        {
            t_ad.Text = null;
            t_soyad.Text = null;
            t_tcno.Text = null;
            t_telno.Text = null;
            t_adres.Text = null;

            if(t_TCsorgula.Text.Replace("_", "").Length == 11)
            {
                var musteri = islem.MusteriGetir(t_TCsorgula.Text);

                if (musteri != null)
                {
                    t_ad.Text = musteri.Ad;
                    t_soyad.Text = musteri.Soyad;
                    t_tcno.Text = musteri.TCNo;
                    t_telno.Text = musteri.TelNo;
                    t_adres.Text = musteri.Adres;
                    ReceteForm.FormMusteriId = musteri.MusteriId;
                }
            }
            else { MessageBox.Show("TC no eksik veya hatalı"); }            

            

        }

        private void btn_duzenle_Click(object sender, EventArgs e)
        {
                if (t_tcno.Text != "")
                {
                    nvg_MusteriBilgileri.SelectedPage = nvgPage_MusteriDuzenle;
                    t_adDuzenle.Text = t_ad.Text;
                    t_soyadDuzenle.Text = t_soyad.Text;
                    t_tcnoDuzenle.Text = t_tcno.Text;
                    t_telnoDuzenle.Text = t_telno.Text;
                    t_adresDuzenle.Text = t_adres.Text;
                }
                else
                {
                    MessageBox.Show("Düzenlenecek müşteri bulunamadı.");
                }
        }

        private void btn_iptal_Click(object sender, EventArgs e)
        {
            t_adDuzenle.Text = t_ad.Text;
            t_soyadDuzenle.Text = t_soyad.Text;
            t_tcnoDuzenle.Text = t_tcno.Text;
            t_telnoDuzenle.Text = t_telno.Text;
            t_adresDuzenle.Text = t_adres.Text;

            nvg_MusteriBilgileri.SelectedPage = nvgPage_MusteriBilgileri;
        }

        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            string t_telnoDogrulama = t_telnoDuzenle.Text.Replace(" ", "");
            
            if (dxValidationProvider2.Validate() && t_telnoDogrulama.Length == 10)
            {
                if (islem.MusteriDuzenle(t_adDuzenle.Text, t_soyadDuzenle.Text, t_tcno.Text, t_telnoDogrulama, t_adresDuzenle.Text))
                {
                    nvg_MusteriBilgileri.SelectedPage = nvgPage_MusteriBilgileri;
                }
            }
            else
            {
                MessageBox.Show("Düzenleme Başarısız!\n\nMüşteri Bilgileri Eksik Girilmiş!");
            }
            
        }

        private void btn_hastane_Click(object sender, EventArgs e)
        {
            FRM_HASTANELER form = new FRM_HASTANELER();
            form.ShowDialog();

            lueHastaneDoldur();
        }

        private void urunGetir_Click(object sender, EventArgs e)
        {
            var arananUrun = urunIslem.UrunGetir(t_barkodNo.Text);

            if (arananUrun != null)
            {
                bool listedeVarMi = urunListesi.Any(a => a.barkodNo == arananUrun.barkodNo);

                if (listedeVarMi)
                {
                    MessageBox.Show("Aynı ürün birden fazla eklenemez!");
                }
                else
                {
                    urunListesi.Add(arananUrun);
                    t_barkodNo.Text = "";
                }
            }
        }

        private void btn_listedenSil_Click(object sender, EventArgs e)
        {
            var secilenUrun = gv_urunListele.GetFocusedRow() as StokUrunBilgi;

            if(secilenUrun == null) 
            {
                MessageBox.Show("Silmek istediğiniz ürünü tablodan seçiniz.");
            }

            DialogResult onay = onayMesajı.guvenlikOnlemi($"{secilenUrun.urunTanimi} listeden çıkarılsın mı?");

            if (onay == DialogResult.Yes) 
            {
                urunListesi.Remove(secilenUrun);
                gv_urunListele.RefreshData();
            }
            
        }

        private void FormuTemizle()
        {
            ekModuller.KontrolleriTemizle(layoutControl1);
            
            urunListesi.Clear();

            receteIslem.ReceteSinifTemizle();

            t_TCsorgula.Focus();
        }
        // Recete ve ürün satışını sonlandırma ve gerekli kayıtları yapma aşaması.
        private void btn_faturalandir_Click(object sender, EventArgs e)
        {
            gv_odeme.CloseEditor();
            gv_odeme.UpdateCurrentRow();

            bool fiyatgirildiMi = false;
            
            for (int i = 0; i < gv_odeme.DataRowCount; i++)
            {
                
                object deger = gv_odeme.GetRowCellValue(i, "satisFiyati");

                
                if (deger == null || string.IsNullOrWhiteSpace(deger.ToString()))
                {
                    
                    MessageBox.Show((i + 1) + ". satırda satış fiyatı boş olamaz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    
                    gv_odeme.FocusedRowHandle = i;
                    gv_odeme.FocusedColumn = gv_odeme.Columns["urunTanimi"];
                    gv_odeme.ShowEditor();

                    return;
                }
                else
                {
                    fiyatgirildiMi = true;
                }
            }
            if (dxValidationProvider1.Validate() && fiyatgirildiMi)
            {
                //Genel Bilgiler
                ReceteForm.FormTarih = Convert.ToDateTime(t_receteTarih.Text);
                ReceteForm.FormHastane = lue_Hastaneler.Text;

                //ReceteForm.FormDoktor
                //ReceteForm.FormKurum
                ReceteForm.FormReceteTuru = rdg_ReceteTuru.SelectedIndex;

                //Gözlük Reçetesi

                //Sağ Göz Uzak
                ReceteForm.sagGozlukUzak_SPH = ekModuller.DecimalCevir(t_uzakGozlukSagSPH.Text);
                ReceteForm.sagGozlukUzak_CYL = ekModuller.DecimalCevir(t_uzakGozlukSagCYL.Text);
                ReceteForm.sagGozlukUzak_AKS = ekModuller.DecimalCevir(t_uzakGozlukSagAKS.Text);
                ReceteForm.sagGozlukUzak_PUP = ekModuller.DecimalCevir(t_uzakGozlukSagPUP.Text);
                ReceteForm.sagGozlukUzak_YUK = ekModuller.DecimalCevir(t_uzakGozlukSagYUK.Text);
                ReceteForm.sagGozlukUzak_PRIZM = ekModuller.DecimalCevir(t_uzakGozlukSagPRIZM.Text);
                ReceteForm.sagGozlukUzak_TAB = ekModuller.DecimalCevir(t_uzakGozlukSagTAB.Text);

                //Sol Göz Uzak
                ReceteForm.solGozlukUzak_SPH = ekModuller.DecimalCevir(t_uzakGozlukSolSPH.Text);
                ReceteForm.solGozlukUzak_CYL = ekModuller.DecimalCevir(t_uzakGozlukSolCYL.Text);
                ReceteForm.solGozlukUzak_AKS = ekModuller.DecimalCevir(t_uzakGozlukSolAKS.Text);
                ReceteForm.solGozlukUzak_PUP = ekModuller.DecimalCevir(t_uzakGozlukSolPUP.Text);
                ReceteForm.solGozlukUzak_YUK = ekModuller.DecimalCevir(t_uzakGozlukSolYUK.Text);
                ReceteForm.solGozlukUzak_PRIZM = ekModuller.DecimalCevir(t_uzakGozlukSolPRIZM.Text);
                ReceteForm.solGozlukUzak_TAB = ekModuller.DecimalCevir(t_uzakGozlukSolTAB.Text);

                //Sağ Göz Yakın
                ReceteForm.sagGozlukYakin_SPH = ekModuller.DecimalCevir(t_yakinGozlukSagSPH.Text);
                ReceteForm.sagGozlukYakin_CYL = ekModuller.DecimalCevir(t_yakinGozlukSagCYL.Text);
                ReceteForm.sagGozlukYakin_AKS = ekModuller.DecimalCevir(t_yakinGozlukSagAKS.Text);
                ReceteForm.sagGozlukYakin_PUP = ekModuller.DecimalCevir(t_yakinGozlukSagPUP.Text);
                ReceteForm.sagGozlukYakin_YUK = ekModuller.DecimalCevir(t_yakinGozlukSagYUK.Text);
                ReceteForm.sagGozlukYakin_PRIZM = ekModuller.DecimalCevir(t_yakinGozlukSagPRIZM.Text);
                ReceteForm.sagGozlukYakin_TAB = ekModuller.DecimalCevir(t_yakinGozlukSagTAB.Text);

                //Sol Göz Yakın
                ReceteForm.solGozlukYakin_SPH = ekModuller.DecimalCevir(t_yakinGozlukSolSPH.Text);
                ReceteForm.solGozlukYakin_CYL = ekModuller.DecimalCevir(t_yakinGozlukSolCYL.Text);
                ReceteForm.solGozlukYakin_AKS = ekModuller.DecimalCevir(t_yakinGozlukSolAKS.Text);
                ReceteForm.solGozlukYakin_PUP = ekModuller.DecimalCevir(t_yakinGozlukSolPUP.Text);
                ReceteForm.solGozlukYakin_YUK = ekModuller.DecimalCevir(t_yakinGozlukSolYUK.Text);
                ReceteForm.solGozlukYakin_PRIZM = ekModuller.DecimalCevir(t_yakinGozlukSolPRIZM.Text);
                ReceteForm.solGozlukYakin_TAB = ekModuller.DecimalCevir(t_yakinGozlukSolTAB.Text);

                //Lens Reçetesi

                //Sag Uzak Lens
                ReceteForm.sagUzakLens_BC = ekModuller.DecimalCevir(t_uzakLensSagBC.Text);
                ReceteForm.sagUzakLens_DIA = ekModuller.DecimalCevir(t_uzakLensSagDIA.Text);
                ReceteForm.sagUzakLens_SPH = ekModuller.DecimalCevir(t_uzakLensSagSPH.Text);
                ReceteForm.sagUzakLens_CYL = ekModuller.DecimalCevir(t_uzakLensSagCYL.Text);
                ReceteForm.sagUzakLens_AKS = ekModuller.DecimalCevir(t_uzakLensSagAKS.Text);
                ReceteForm.sagUzakLens_ADD = ekModuller.DecimalCevir(t_uzakLensSagADD.Text);

                //Sol Uzak Lens
                ReceteForm.solUzakLens_BC = ekModuller.DecimalCevir(t_uzakLensSolBC.Text);
                ReceteForm.solUzakLens_DIA = ekModuller.DecimalCevir(t_uzakLensSolDIA.Text);
                ReceteForm.solUzakLens_SPH = ekModuller.DecimalCevir(t_uzakLensSolSPH.Text);
                ReceteForm.solUzakLens_CYL = ekModuller.DecimalCevir(t_uzakLensSolCYL.Text);
                ReceteForm.solUzakLens_AKS = ekModuller.DecimalCevir(t_uzakLensSolAKS.Text);
                ReceteForm.solUzakLens_ADD = ekModuller.DecimalCevir(t_uzakLensSolADD.Text);

                //Sag Yakın Lens
                ReceteForm.sagUzakLens_BC = ekModuller.DecimalCevir(t_uzakLensSagBC.Text);
                ReceteForm.sagUzakLens_DIA = ekModuller.DecimalCevir(t_uzakLensSagDIA.Text);
                ReceteForm.sagUzakLens_SPH = ekModuller.DecimalCevir(t_uzakLensSagSPH.Text);
                ReceteForm.sagUzakLens_CYL = ekModuller.DecimalCevir(t_uzakLensSagCYL.Text);
                ReceteForm.sagUzakLens_AKS = ekModuller.DecimalCevir(t_uzakLensSagAKS.Text);
                ReceteForm.sagUzakLens_ADD = ekModuller.DecimalCevir(t_uzakLensSagADD.Text);

                //Sol Yakın Lens
                ReceteForm.solYakinLens_BC = ekModuller.DecimalCevir(t_yakinLensSolBC.Text);
                ReceteForm.solYakinLens_DIA = ekModuller.DecimalCevir(t_yakinLensSolDIA.Text);
                ReceteForm.solYakinLens_SPH = ekModuller.DecimalCevir(t_yakinLensSolSPH.Text);
                ReceteForm.solYakinLens_CYL = ekModuller.DecimalCevir(t_yakinLensSolCYL.Text);
                ReceteForm.solYakinLens_AKS = ekModuller.DecimalCevir(t_yakinLensSolAKS.Text);
                ReceteForm.solYakinLens_ADD = ekModuller.DecimalCevir(t_yakinLensSolADD.Text);

                //Urunler
                ReceteForm.SepettekiUrunler = urunListesi.ToList();

                bool basariliMi_recete = receteIslem.ReceteKaydet();                
                if (basariliMi_recete)
                {
                    FormuTemizle();
                    receteIslem.ReceteSinifTemizle();
                    urunListesi.Clear();
                    MessageBox.Show("Reçete ve satış kaydı başarıyla yapıldı.");
                }
                else
                {
                    MessageBox.Show("Hata kayıt başarısız.");
                }
            }
            
        }



        private void btn_satisiptal_Click(object sender, EventArgs e)
        {
            FormuTemizle();
            receteIslem.ReceteSinifTemizle();
            urunListesi.Clear();
        }



        
    }

}