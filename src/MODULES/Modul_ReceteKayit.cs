using DevExpress.Pdf.Native.BouncyCastle.Asn1.BC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;

namespace Optik_Takip_Sistemi
{
   
    public static class ReceteForm
    {
        // GENEL BİLGİLER
        public static int FormMusteriId { get; set; }
        public static DateTime FormTarih {  get; set; }
        public static string FormHastane {  get; set; }
        public static string FormDoktor {  get; set; }
        public static string FormKurum { get; set; }
        public static int FormReceteTuru { get; set; }

        // GÖZLÜK REÇETESİ

        //Sağ Göz Uzak
        public static decimal sagGozlukUzak_SPH {  get; set; }
        public static decimal sagGozlukUzak_CYL { get; set; }
        public static decimal sagGozlukUzak_AKS { get; set; }
        public static decimal sagGozlukUzak_PUP { get; set; }
        public static decimal sagGozlukUzak_YUK { get; set; }
        public static decimal sagGozlukUzak_PRIZM { get; set; }
        public static decimal sagGozlukUzak_TAB { get; set; }

        //Sol Göz Uzak
        public static decimal solGozlukUzak_SPH { get; set; }
        public static decimal solGozlukUzak_CYL { get; set; }
        public static decimal solGozlukUzak_AKS { get; set; }
        public static decimal solGozlukUzak_PUP { get; set; }
        public static decimal solGozlukUzak_YUK { get; set; }
        public static decimal solGozlukUzak_PRIZM { get; set; }
        public static decimal solGozlukUzak_TAB { get; set; }

        //Sağ Göz Yakın
        public static decimal sagGozlukYakin_SPH { get; set; }
        public static decimal sagGozlukYakin_CYL { get; set; }
        public static decimal sagGozlukYakin_AKS { get; set; }
        public static decimal sagGozlukYakin_PUP { get; set; }
        public static decimal sagGozlukYakin_YUK { get; set; }
        public static decimal sagGozlukYakin_PRIZM { get; set; }
        public static decimal sagGozlukYakin_TAB { get; set; }

        //Sol Göz Yakın
        public static decimal solGozlukYakin_SPH { get; set; }
        public static decimal solGozlukYakin_CYL { get; set; }
        public static decimal solGozlukYakin_AKS { get; set; }
        public static decimal solGozlukYakin_PUP { get; set; }
        public static decimal solGozlukYakin_YUK { get; set; }
        public static decimal solGozlukYakin_PRIZM { get; set; }
        public static decimal solGozlukYakin_TAB { get; set; }

        // LENS REÇETESİ

        //Sağ Lens Uzak

        public static decimal sagUzakLens_BC {  get; set; }
        public static decimal sagUzakLens_DIA { get; set; }
        public static decimal sagUzakLens_SPH { get; set; }
        public static decimal sagUzakLens_CYL { get; set; }
        public static decimal sagUzakLens_AKS { get; set; }
        public static decimal sagUzakLens_ADD { get; set; }

        //Sol Lens Uzak
        public static decimal solUzakLens_BC { get; set; }
        public static decimal solUzakLens_DIA { get; set; }
        public static decimal solUzakLens_SPH { get; set; }
        public static decimal solUzakLens_CYL { get; set; }
        public static decimal solUzakLens_AKS { get; set; }
        public static decimal solUzakLens_ADD { get; set; }

        //Sağ Lens Yakın

        public static decimal sagYakinLens_BC { get; set; }
        public static decimal sagYakinLens_DIA { get; set; }
        public static decimal sagYakinLens_SPH { get; set; }
        public static decimal sagYakinLens_CYL { get; set; }
        public static decimal sagYakinLens_AKS { get; set; }
        public static decimal sagYakinLens_ADD { get; set; }

        //Sol Lens Yakın
        public static decimal solYakinLens_BC { get; set; }
        public static decimal solYakinLens_DIA { get; set; }
        public static decimal solYakinLens_SPH { get; set; }
        public static decimal solYakinLens_CYL { get; set; }
        public static decimal solYakinLens_AKS { get; set; }
        public static decimal solYakinLens_ADD { get; set; }

        // FATURA BİLGİLERİ
        public static List<StokUrunBilgi> SepettekiUrunler { get; set; } = new List<StokUrunBilgi>(); // Birden fazla ürün eklenebileceği için classlist olarak tutuyoruz.
        
    }

    internal class Modul_ReceteKayit
    {
        Modul_UrunIslemleri urunIslem = new Modul_UrunIslemleri();
        public bool ReceteKaydet()
        {
            using (dbDataContext db = new dbDataContext())
            {
                using(var transaction = new System.Transactions.TransactionScope())
                {
                    try
                    {
                        //Genel bilgilerin kaydı
                        int ReceteId = ReceteVTKaydet(db);
                        if (ReceteForm.FormReceteTuru == 0)
                        {
                            GozlukReceteVTKaydet(db, ReceteId);
                        }
                        else
                        {
                            LensReceteVTKaydet(db, ReceteId);
                        }
                        ReceteSatisVTKaydet(db, ReceteId);
                        urunIslem.StokDurumDegistir(ReceteForm.SepettekiUrunler,db);
                        transaction.Complete();
                        return true;
                    }
                    catch (Exception ex) 
                    {
                        MessageBox.Show($"Hata: {ex}");
                        return false;
                    }
                    
                }
            }
        }
        private int ReceteVTKaydet(dbDataContext db)
        {
                // Genel Bilgilerin kaydı
                var yeniReceteKayit = new Receteler();

                yeniReceteKayit.MusteriId = ReceteForm.FormMusteriId;
                yeniReceteKayit.Tarih = ReceteForm.FormTarih;
                yeniReceteKayit.Hastane = ReceteForm.FormHastane;
                yeniReceteKayit.Doktor = ReceteForm.FormDoktor;
                yeniReceteKayit.Kurum = ReceteForm.FormKurum;

                db.Recetelers.InsertOnSubmit(yeniReceteKayit);
                db.SubmitChanges();

                int olusanReceteId = yeniReceteKayit.ReceteId;

                return olusanReceteId;
            }
        

        private void ReceteSatisVTKaydet(dbDataContext db,int ReceteId)
        {
                foreach (var urunler in ReceteForm.SepettekiUrunler)
                {
                    var yeniKayit = new ReceteSati();

                    yeniKayit.ReceteId = ReceteId;
                    yeniKayit.UrunBarkodNo = urunler.barkodNo;
                    yeniKayit.UrunSatisFiyati = Convert.ToDecimal(urunler.satisFiyati);
                    db.ReceteSatis.InsertOnSubmit(yeniKayit);
                }
            db.SubmitChanges();

        }

        private void GozlukReceteVTKaydet(dbDataContext db, int ReceteId)
        {
                var gozlukKayit = new GozlukRecetesi();

                gozlukKayit.ReceteId = ReceteId;

                //Sağ Göz Uzak
                gozlukKayit.U_Sag_SPH = ReceteForm.sagGozlukUzak_SPH;
                gozlukKayit.U_Sag_CYL = ReceteForm.sagGozlukUzak_CYL;
                gozlukKayit.U_Sag_AKS = ReceteForm.sagGozlukUzak_AKS;
                gozlukKayit.U_Sag_PUP = ReceteForm.sagGozlukUzak_PUP;
                gozlukKayit.U_Sag_YUK = ReceteForm.sagGozlukUzak_YUK;
                gozlukKayit.U_Sag_PRIZM = ReceteForm.sagGozlukUzak_PRIZM;
                gozlukKayit.U_Sag_TAB = ReceteForm.sagGozlukUzak_TAB;

                //Sol Göz Uzak
                gozlukKayit.U_Sol_SPH = ReceteForm.solGozlukUzak_SPH;
                gozlukKayit.U_Sol_CYL = ReceteForm.solGozlukUzak_CYL;
                gozlukKayit.U_Sol_AKS = ReceteForm.solGozlukUzak_AKS;
                gozlukKayit.U_Sol_PUP = ReceteForm.solGozlukUzak_PUP;
                gozlukKayit.U_Sol_YUK = ReceteForm.solGozlukUzak_YUK;
                gozlukKayit.U_Sol_PRIZM = ReceteForm.solGozlukUzak_PRIZM;
                gozlukKayit.U_Sol_TAB = ReceteForm.solGozlukUzak_TAB;

                //Sağ Göz Yakın
                gozlukKayit.Y_Sag_SPH = ReceteForm.sagGozlukYakin_SPH;
                gozlukKayit.Y_Sag_CYL = ReceteForm.sagGozlukYakin_CYL;
                gozlukKayit.Y_Sag_AKS = ReceteForm.sagGozlukYakin_AKS;
                gozlukKayit.Y_Sag_PUP = ReceteForm.sagGozlukYakin_PUP;
                gozlukKayit.Y_Sag_YUK = ReceteForm.sagGozlukYakin_YUK;
                gozlukKayit.Y_Sag_PRIZM = ReceteForm.sagGozlukYakin_PRIZM;
                gozlukKayit.Y_Sag_TAB = ReceteForm.sagGozlukYakin_TAB;

                //Sol Göz Yakın
                gozlukKayit.Y_Sol_SPH = ReceteForm.solGozlukYakin_SPH;
                gozlukKayit.Y_Sol_CYL = ReceteForm.solGozlukYakin_CYL;
                gozlukKayit.Y_Sol_AKS = ReceteForm.solGozlukYakin_AKS;
                gozlukKayit.Y_Sol_PUP = ReceteForm.solGozlukYakin_PUP;
                gozlukKayit.Y_Sol_YUK = ReceteForm.solGozlukYakin_YUK;
                gozlukKayit.Y_Sol_PRIZM = ReceteForm.solGozlukYakin_PRIZM;
                gozlukKayit.Y_Sol_TAB = ReceteForm.solGozlukYakin_TAB;

                db.GozlukRecetesis.InsertOnSubmit(gozlukKayit);
                db.SubmitChanges();
            
        }

        private void LensReceteVTKaydet(dbDataContext db, int ReceteId)
        {
                //Lens Bilgilerinin Kaydı
                var LensKayit = new LensRecetesi();

                LensKayit.ReceteId = ReceteId;

                // Sağ Lens Uzak
                LensKayit.U_Sag_BC = ReceteForm.sagUzakLens_BC;
                LensKayit.U_Sag_DIA = ReceteForm.sagUzakLens_DIA;
                LensKayit.U_Sag_SPH = ReceteForm.sagUzakLens_SPH;
                LensKayit.U_Sag_CYL = ReceteForm.sagUzakLens_CYL;
                LensKayit.U_Sag_AKS = ReceteForm.sagUzakLens_AKS;
                LensKayit.U_Sag_ADD = ReceteForm.sagUzakLens_ADD;

                // Sol Lens Uzak
                LensKayit.U_Sol_BC = ReceteForm.solUzakLens_BC;
                LensKayit.U_Sol_DIA = ReceteForm.solUzakLens_DIA;
                LensKayit.U_Sol_SPH = ReceteForm.solUzakLens_SPH;
                LensKayit.U_Sol_CYL = ReceteForm.solUzakLens_CYL;
                LensKayit.U_Sol_AKS = ReceteForm.solUzakLens_AKS;
                LensKayit.U_Sol_ADD = ReceteForm.solUzakLens_ADD;

                // Sağ Lens Yakın
                LensKayit.Y_Sag_BC = ReceteForm.sagYakinLens_BC;
                LensKayit.Y_Sag_DIA = ReceteForm.sagYakinLens_DIA;
                LensKayit.Y_Sag_SPH = ReceteForm.sagYakinLens_SPH;
                LensKayit.Y_Sag_CYL = ReceteForm.sagYakinLens_CYL;
                LensKayit.Y_Sag_AKS = ReceteForm.sagYakinLens_AKS;
                LensKayit.Y_Sag_ADD = ReceteForm.sagYakinLens_ADD;

                // Sol Lens Yakın
                LensKayit.Y_Sol_BC = ReceteForm.solYakinLens_BC;
                LensKayit.Y_Sol_DIA = ReceteForm.solYakinLens_DIA;
                LensKayit.Y_Sol_SPH = ReceteForm.solYakinLens_SPH;
                LensKayit.Y_Sol_CYL = ReceteForm.solYakinLens_CYL;
                LensKayit.Y_Sol_AKS = ReceteForm.solYakinLens_AKS;
                LensKayit.Y_Sol_ADD = ReceteForm.solYakinLens_ADD;

                db.LensRecetesis.InsertOnSubmit(LensKayit);
                db.SubmitChanges();
            
        }

        public void ReceteSinifTemizle()
        {
            //Genel bilgileri temizleme 

            ReceteForm.FormMusteriId = 0;
            ReceteForm.FormTarih = DateTime.Now;

            ReceteForm.FormHastane = "";
            ReceteForm.FormDoktor = "";
            ReceteForm.FormKurum = "";

            ReceteForm.FormReceteTuru = 0;

            //Gözlük bilgileri temizleme
            ReceteForm.sagGozlukUzak_SPH = 0;
            ReceteForm.sagGozlukUzak_CYL = 0;
            ReceteForm.sagGozlukUzak_AKS = 0;
            ReceteForm.sagGozlukUzak_PUP = 0;   
            ReceteForm.sagGozlukUzak_YUK = 0;
            ReceteForm.sagGozlukUzak_PRIZM = 0;
            ReceteForm.sagGozlukUzak_TAB = 0;

            //Sol Göz Uzak
            ReceteForm.solGozlukUzak_SPH = 0;
            ReceteForm.solGozlukUzak_CYL = 0;
            ReceteForm.solGozlukUzak_AKS = 0;
            ReceteForm.solGozlukUzak_PUP = 0;
            ReceteForm.solGozlukUzak_YUK = 0;
            ReceteForm.solGozlukUzak_PRIZM = 0;
            ReceteForm.solGozlukUzak_TAB = 0;

            //Sağ Göz Yakın
            ReceteForm.sagGozlukYakin_SPH = 0;
            ReceteForm.sagGozlukYakin_CYL = 0;
            ReceteForm.sagGozlukYakin_AKS = 0;
            ReceteForm.sagGozlukYakin_PUP = 0;
            ReceteForm.sagGozlukYakin_YUK = 0;
            ReceteForm.sagGozlukYakin_PRIZM = 0;
            ReceteForm.sagGozlukYakin_TAB = 0;

            //Sol Göz Yakın
            ReceteForm.solGozlukYakin_SPH = 0;
            ReceteForm.solGozlukYakin_CYL = 0;
            ReceteForm.solGozlukYakin_AKS = 0;
            ReceteForm.solGozlukYakin_PUP = 0;
            ReceteForm.solGozlukYakin_YUK = 0;
            ReceteForm.solGozlukYakin_PRIZM = 0;
            ReceteForm.solGozlukYakin_TAB = 0;

            //Lens bilgileri temizleme

            // Sağ Lens Uzak
            ReceteForm.sagUzakLens_BC = 0;
            ReceteForm.sagUzakLens_DIA = 0;
            ReceteForm.sagUzakLens_SPH = 0;
            ReceteForm.sagUzakLens_CYL = 0;
            ReceteForm.sagUzakLens_AKS = 0;
            ReceteForm.sagUzakLens_ADD = 0;

            // Sol Lens Uzak
            ReceteForm.solUzakLens_BC = 0;
            ReceteForm.solUzakLens_DIA = 0;
            ReceteForm.solUzakLens_SPH = 0;
            ReceteForm.solUzakLens_CYL = 0;
            ReceteForm.solUzakLens_AKS = 0;
            ReceteForm.solUzakLens_ADD = 0;

            // Sağ Lens Yakın
            ReceteForm.sagYakinLens_BC = 0;
            ReceteForm.sagYakinLens_DIA = 0;
            ReceteForm.sagYakinLens_SPH = 0;
            ReceteForm.sagYakinLens_CYL = 0;
            ReceteForm.sagYakinLens_AKS = 0;
            ReceteForm.sagYakinLens_ADD = 0;

            // Sol Lens Yakın
            ReceteForm.solYakinLens_BC = 0;
            ReceteForm.solYakinLens_DIA = 0;
            ReceteForm.solYakinLens_SPH = 0;
            ReceteForm.solYakinLens_CYL = 0;
            ReceteForm.solYakinLens_AKS = 0;
            ReceteForm.solYakinLens_ADD = 0;

            //Ürün listesi temizliği
            if(ReceteForm.SepettekiUrunler != null) ReceteForm.SepettekiUrunler.Clear();
                
        }
    }
}
