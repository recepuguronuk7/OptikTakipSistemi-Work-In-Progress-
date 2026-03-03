using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Optik_Takip_Sistemi
{
    public class StokUrunBilgi
    {        
        public string urunTanimi { get; set; }
        public DateTime? girisTarihi { get; set; }
        public string gonderenKurumAdi {  get; set; }        
        public string barkodNo { get; set; }  
        public string adet {  get; set; }
        public decimal? maliyet {  get; set; }
        public decimal? satisFiyati { get; set; }
    }
    internal class Modul_UrunIslemleri
    {        
        public StokUrunBilgi UrunGetir(string _barkod)
        {
            using (dbDataContext db = new dbDataContext())
            {
                
                var ara = db.DukkanStoks.FirstOrDefault(a=> a.BarkodNo == _barkod);

                if (ara == null) 
                {
                    MessageBox.Show("Ürün stokta yok");
                    return null;
                }
                else if(ara != null && ara.Durum == 1)
                {
                    MessageBox.Show("Bu ürün zaten satılmış");
                    return null;
                }
                else
                {
                    StokUrunBilgi stok = new StokUrunBilgi();
                    stok.urunTanimi = ara.UrunTanimi;
                    stok.girisTarihi = ara.StokEklenmeTarihi;
                    stok.gonderenKurumAdi = ara.GonderenKurumAdi;
                    stok.adet = ara.Adet;
                    stok.barkodNo = ara.BarkodNo;
                    stok.maliyet = ara.Maliyet;

                    return stok;
                }
            }
        }

        public bool StokDurumDegistir(List<StokUrunBilgi> urunler,dbDataContext db)
        {
            try
            {
                if (urunler == null || urunler.Count == 0) return false;
                else
                {
                    
                        foreach (var urun in urunler)
                        {
                            var ara = db.DukkanStoks.FirstOrDefault(a => a.BarkodNo == urun.barkodNo);
                            if (ara != null)
                            {
                                ara.Durum = 1;                                
                                ara.SatisTarihi = System.DateTime.Now;
                                
                            }
                            else
                            {

                                MessageBox.Show($"Satış yapılamadı!\n hatalı ürün kodu {urun.barkodNo}\n Hatalı ürün adı {urun.urunTanimi}");
                                return false;
                            }
                        }
                        db.SubmitChanges();

                    }
                
                    
                return true;
            }
            catch (Exception ex) 
            {
                MessageBox.Show($"Hata {ex}");
                return false;
            }
                

        }
    }
}
