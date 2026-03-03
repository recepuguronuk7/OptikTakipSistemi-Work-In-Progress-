using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Optik_Takip_Sistemi
{
    public class SatisBilgileri
    {
        //Müşteri Bilgileri
        public int musteriId { get; set; }
        public string musteriAd { get; set; }
        public string musteriSoyad { get; set; }
        public string musteriTCNo { get; set; }

        // Ürün Bilgileri

        public string urunTanimi { get; set; }
        public string gonderenKurumAdi { get; set; }
        public string adet { get; set; }
        public string barkodNo { get; set; }
        public DateTime? satisTarihi { get; set; }
        public decimal satisFiyati { get; set; }

    }
    public class Modul_SatisBilgileri
    {        
        public List<SatisBilgileri> SatisBilgileriGetir_Bugun()
        {
            using (dbDataContext db = new dbDataContext())
            {
                DateTime baslangicZamani = DateTime.Today;
                var satisBilgi = from d in db.DukkanStoks
                                 join s in db.ReceteSatis on d.BarkodNo equals s.UrunBarkodNo
                                 join r in db.Recetelers on s.ReceteId equals r.ReceteId
                                 join m in db.Musterilers on r.MusteriId equals m.MusteriId
                                 where d.Durum == 1 && d.SatisTarihi != null && d.SatisTarihi >= baslangicZamani
                                 select new SatisBilgileri
                                 {
                                     musteriId = m.MusteriId,
                                     musteriAd = m.Ad,
                                     musteriSoyad = m.Soyad,
                                     musteriTCNo = m.TCNo,

                                     urunTanimi = d.UrunTanimi,
                                     gonderenKurumAdi = d.GonderenKurumAdi,
                                     adet = d.Adet,
                                     barkodNo = d.BarkodNo,
                                     satisTarihi = d.SatisTarihi,
                                     satisFiyati = s.UrunSatisFiyati
                                 };
                return satisBilgi.ToList();

            }
        }
        
    }
}
