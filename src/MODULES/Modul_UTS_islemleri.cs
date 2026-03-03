using DevExpress.XtraBars.Docking2010.DragEngine;
using DevExpress.XtraRichEdit.Fields;
using DevExpress.XtraSplashScreen;
using ExcelDataReader;
using Newtonsoft.Json;
using Optik_Takip_Sistemi;
using RestSharp;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Optik_Takip_Sistemi.MODULES;
internal class Modul_UTS_islemleri
{    

    /// <summary>
    /// ///////////////////////////////////// UTS YENİ ALMA BİLDİRİMLERİ ÇEKME SERVİSİ /////////////////////////////////
    /// </summary>
    public class UtsGelenBildirimCevap
    {
        [JsonProperty("SNC")]
        public UtsSonucData SNC { get; set; }
    }

    public class UtsSonucData
    {
        [JsonProperty("LST")]
        public List<UtsBildirimDetay> SonucListesi { get; set; }
                
        [JsonProperty("OFF")]
        public string SonrakiSayfaKodu { get; set; }
    }

    public class UtsBildirimDetay
    {
        
        [JsonProperty("UNO")] public string UrunNo { get; set; }
        [JsonProperty("GKK")] public long GonderenKurumNo { get; set; }
        [JsonProperty("BID")] public System.Guid BildirimId { get; set; }
        [JsonProperty("LNO")] public string LotNo { get; set; }
        [JsonProperty("SNO")] public string SeriNo { get; set; }
        [JsonProperty("MME")] public string UrunAdi { get; set; }
        [JsonProperty("GKU")] public string GonderenKurumAdi { get; set; }
        [JsonProperty("ADT")] public int Adet { get; set; }
        [JsonProperty("BNO")] public string BelgeNo { get; set; }
        [JsonProperty("BDR")] public string BildirimDurumu { get; set; }
        [JsonProperty("BZA")] public DateTime BildirimZamani { get; set; }
        [JsonProperty("GIT")] public DateTime VermeTarihi { get; set; }
        [JsonProperty("UIK")] public long UniqueNo { get; set; }
    }

    public class UtsIstekModeli
    {
        [JsonProperty("TRH_BAS")]
        public string TRH_BAS { get; set; }

        [JsonProperty("TRH_BIT")]
        public string TRH_BIT { get; set; }

        [JsonProperty("LIMIT")]
        public int LIMIT { get; set; }

        [JsonProperty("OFF")]
        public string OFF { get; set; }
    }

    private class UtsAlmaService
    {
        private const string BASE_URL = "https://utsuygulama.saglik.gov.tr/UTS/uh/rest/bildirim/alma/bekleyenler/sorgula/offset";
        private string _token;

        public UtsAlmaService(string token)
        {
            _token = token;
        }

        public async Task<List<UtsBildirimDetay>> TumBekleyenleriHafizayaCek()
        {
            List<UtsBildirimDetay> hafizaListesi = new List<UtsBildirimDetay>();
            string suankiOffKodu = null;

            using (HttpClient client = new HttpClient())
            {               
                client.Timeout = TimeSpan.FromMinutes(5);
                client.DefaultRequestHeaders.TryAddWithoutValidation("utstoken", _token);
                client.DefaultRequestHeaders.TryAddWithoutValidation("Authorization", "Bearer " + _token);
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                string url = "https://utsuygulama.saglik.gov.tr/UTS/uh/rest/bildirim/alma/bekleyenler/sorgula/offset";

                while (true) 
                {                    
                    var istek = new
                    {
                        TRH_BAS = DateTime.Now.AddDays(-30).ToString("yyyy-MM-dd"), // 1 yıllık bak
                        TRH_BIT = DateTime.Now.ToString("yyyy-MM-dd"),
                        LIMIT = 100,
                        OFF = suankiOffKodu
                    };

                    string jsonBody = JsonConvert.SerializeObject(istek);
                    var content = new StringContent(jsonBody, Encoding.UTF8, "application/json");

                    try
                    {
                        var response = await client.PostAsync(url, content);
                        if (response.IsSuccessStatusCode)
                        {
                            string jsonCevap = await response.Content.ReadAsStringAsync();
                            var veri = JsonConvert.DeserializeObject<UtsGelenBildirimCevap>(jsonCevap);

                            if (veri != null && veri.SNC != null && veri.SNC.SonucListesi != null)
                            {
                                // Listeye Ekle
                                hafizaListesi.AddRange(veri.SNC.SonucListesi);

                                // Sayfa Kontrolü
                                if (!string.IsNullOrEmpty(veri.SNC.SonrakiSayfaKodu))
                                    suankiOffKodu = veri.SNC.SonrakiSayfaKodu;
                                else
                                    break; // Sayfa bitti
                            }
                            else break;
                        }
                        else break;
                    }
                    catch { break; }
                }
            }
            return hafizaListesi;
        }
 /// <summary>
/// ////////////////////////////////////////////  ALMA BİLDİRİMİ KABUL ETME SERVİSİ ////////////////////////////////////////
 /// </summary>

        public class UtsAlmaEkleIstek
        {
            [JsonProperty("ADT")]
            public int ADT { get; set; }

            [JsonProperty("VBI")]
            public string VBI { get; set; }
        }

        public class UtsAlmaEkleCevap
        {
            [JsonProperty("SNC")]
            public string YeniAlmaBildirimId { get; set; }

            [JsonProperty("MSJ")]
            public List<UtsMesajDetay> Mesajlar { get; set; }
        }

        public class UtsMesajDetay
        {
            [JsonProperty("MET")]
            public string MesajMetni { get; set; }

            [JsonProperty("KOD")]
            public string Kod { get; set; } 

            [JsonProperty("TIP")]
            public string Tip { get; set; } 
        }

        public async Task<string> AlmaKabulBildirimiGonder(string vermeBildirimId, int adet)
        {
            using (HttpClient client = new HttpClient())
            {
                client.Timeout = TimeSpan.FromSeconds(30);
                client.DefaultRequestHeaders.TryAddWithoutValidation("utstoken", _token);
                client.DefaultRequestHeaders.TryAddWithoutValidation("Authorization", "Bearer " + _token);
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                                
                string url = "https://utsuygulama.saglik.gov.tr/UTS/uh/rest/bildirim/alma/ekle";
                                
                var istek = new UtsAlmaEkleIstek
                {
                    VBI = vermeBildirimId, 
                    ADT = adet             
                };

                string jsonBody = JsonConvert.SerializeObject(istek);
                var content = new StringContent(jsonBody, Encoding.UTF8, "application/json");

                try
                {
                    var response = await client.PostAsync(url, content);
                    string jsonCevap = await response.Content.ReadAsStringAsync();

                    if (response.IsSuccessStatusCode)
                    {
                        var sonuc = JsonConvert.DeserializeObject<UtsAlmaEkleCevap>(jsonCevap);
                        
                        if (sonuc != null && sonuc.Mesajlar != null)
                        {
                            var mesaj = sonuc.Mesajlar.FirstOrDefault()?.MesajMetni;
                            return "OK|" + mesaj; 
                        }
                        return "OK|İşlem Başarılı";
                    }
                    else
                    {                        
                        return "HATA: " + response.StatusCode + " - " + jsonCevap;
                    }
                }
                catch (Exception ex)
                {
                    return "BAĞLANTI HATASI: " + ex.Message;
                }
            }
        }

        /// <summary>
        /// ////////////////////////////////////////////  ALMA BİLDİRİMİ REDDETME SERVİSİ ////////////////////////////////////////
        /// </summary>
        public class UtsAlmaRedIstek
        {
            [JsonProperty("ADT")]
            public int ADT { get; set; }

            [JsonProperty("VBI")]
            public string VBI { get; set; }

            [JsonProperty("ACIKLAMA")]
            public string Aciklama { get; set; }
        }

        public async Task<string> AlmaBildirimiRedEt(string vermeBildirimId, int adet, string redAciklamasi)
        {
            using (HttpClient client = new HttpClient())
            {
                client.Timeout = TimeSpan.FromSeconds(30);
                client.DefaultRequestHeaders.TryAddWithoutValidation("utstoken", _token);
                client.DefaultRequestHeaders.TryAddWithoutValidation("Authorization", "Bearer " + _token);
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                                
                string url = "https://utsuygulama.saglik.gov.tr/UTS/uh/rest/bildirim/alma/red";

                var istek = new UtsAlmaRedIstek
                {
                    VBI = vermeBildirimId,
                    ADT = adet,
                    Aciklama = redAciklamasi
                };

                string jsonBody = JsonConvert.SerializeObject(istek);
                var content = new StringContent(jsonBody, Encoding.UTF8, "application/json");

                try
                {
                    var response = await client.PostAsync(url, content);
                    string jsonCevap = await response.Content.ReadAsStringAsync();

                    if (response.IsSuccessStatusCode)
                    {                       
                        return "OK|Reddedildi";
                    }
                    else
                    {
                        return "HATA: " + response.StatusCode + " - " + jsonCevap;
                    }
                }
                catch (Exception ex)
                {
                    return "BAĞLANTI HATASI: " + ex.Message;
                }
            }
        }

    }

/// <summary>
/// ///////////////////////////////////// TOPLU ALMA İŞLEMİ ANA FONKSİYONU ///////////////////////////////////////////////
/// </summary>
    public class IslemSonucu
    {
        public int Basarili { get; set; }
        public int Hatali { get; set; }
        public List<string> HataMesajlari { get; set; } = new List<string>();
        public bool SistemHatasiVarMi { get; set; }
        public string SistemHatasiMesaji { get; set; }
    }
    public async Task<IslemSonucu> TopluKabulIsleminiBaslat(HashSet<Guid> secilenIdler)
    {
        IslemSonucu sonuc = new IslemSonucu();

        // Token
        string token = UTSToken.Token;
        UtsAlmaService servis = new UtsAlmaService(token);

        using (dbDataContext db = new dbDataContext())
        {
            try
            {
                foreach (Guid currentGuidId in secilenIdler)
                {                    
                    int gonderilecekAdet = 1;
                    var kayit = db.UTSYeniAlmaBildirimleris.FirstOrDefault(x => x.BildirimId == currentGuidId);
                    if (kayit != null) gonderilecekAdet = Convert.ToInt32(kayit.Adet);
                    if (gonderilecekAdet <= 0) gonderilecekAdet = 1;

                    // --- SERVİS ÇAĞRISI ---
                    string apiCevap = await servis.AlmaKabulBildirimiGonder(currentGuidId.ToString(), gonderilecekAdet);

                    if (apiCevap.StartsWith("OK"))
                    {
                        sonuc.Basarili++;
                        if (kayit != null) kayit.IslemDurumu = 1;
                    }
                    else
                    {
                        sonuc.Hatali++;
                        sonuc.HataMesajlari.Add($"ID: {currentGuidId} -> {apiCevap}");
                    }
                }

                // Döngü bitince kaydet
                db.SubmitChanges();
            }
            catch (Exception ex)
            {
                sonuc.SistemHatasiVarMi = true;
                sonuc.SistemHatasiMesaji = ex.Message;
            }
        }

        return sonuc;
    }

    /// <summary>
    /// ///////////////////////////// UTS ALMA VERİLERİNİ SENKRONİZE ETME VE ÇALIŞTIRMA FONKSİYONU ////////////////////////
    /// </summary>
    public class UtsSenkronizasyonSonuc
    {
        public int EklenenSayisi { get; set; }
        public int DusenSayisi { get; set; } // 99 yapılanlar
        public string Mesaj { get; set; }
        public bool BasariliMi { get; set; }
    }

    public async Task<UtsSenkronizasyonSonuc> VerileriSenkronizeEt()
    {
        UtsSenkronizasyonSonuc sonuc = new UtsSenkronizasyonSonuc();
        string token = UTSToken.Token; 
        UtsAlmaService servis = new UtsAlmaService(token);
        try
        {
            
            var utsListesi = await servis.TumBekleyenleriHafizayaCek();

            
            HashSet<Guid> utsIdSet = new HashSet<Guid>();
            foreach (var item in utsListesi)
            {
                utsIdSet.Add(item.BildirimId);
            }

            
            using (dbDataContext db = new dbDataContext())
            {                
                var yerelBekleyenler = db.UTSYeniAlmaBildirimleris.Where(x => x.IslemDurumu == 0).ToList();

                foreach (var yerelKayit in yerelBekleyenler)
                {                    
                    if (!utsIdSet.Contains(yerelKayit.BildirimId))
                    {
                        yerelKayit.IslemDurumu = 99;
                        sonuc.DusenSayisi++;
                    }
                }

                // --- SENARYO 2: Yeni Gelenleri Ekle  ---
                foreach (var utsItem in utsListesi)
                {                    
                        bool varMi = db.UTSYeniAlmaBildirimleris.Any(x => x.BildirimId == utsItem.BildirimId);

                        if (!varMi)
                        {                       
                        
                            UTSYeniAlmaBildirimleri yeni = new UTSYeniAlmaBildirimleri();
                            yeni.UrunNo = utsItem.UrunNo;
                            yeni.GonderenKurumNo = utsItem.GonderenKurumNo;
                            yeni.BildirimId = utsItem.BildirimId;
                            yeni.LotBatchNo = utsItem.LotNo.ToString();
                            yeni.SeriNo = utsItem.SeriNo;
                            yeni.UrunTanimi = utsItem.UrunAdi;
                            yeni.GonderenKurumAdi = utsItem.GonderenKurumAdi;
                            yeni.Adet = utsItem.Adet;
                            yeni.BelgeNo = utsItem.BelgeNo;
                            yeni.BildirimDurumu = utsItem.BildirimDurumu;
                            yeni.BildirimZamani = utsItem.BildirimZamani;
                            yeni.VermeTarihi = utsItem.VermeTarihi;
                            yeni.UniqueNo = utsItem.UniqueNo;

                            yeni.IslemDurumu = 0;

                            db.UTSYeniAlmaBildirimleris.InsertOnSubmit(yeni);
                        

                        db.UTSYeniAlmaBildirimleris.InsertOnSubmit(yeni);
                            sonuc.EklenenSayisi++;
                        }
                    
                }
                
                db.SubmitChanges();
            }

            sonuc.BasariliMi = true;
            sonuc.Mesaj = "Senkronizasyon Başarılı";
        }
        catch (Exception ex)
        {
            sonuc.BasariliMi = false;
            sonuc.Mesaj = "Hata: " + ex.Message;
        }

        return sonuc;
    }

    ////////////////////////////////////////// TOPLU ALMA REDDETME ANA FONKSİYONU //////////////////////////////
    public async Task<IslemSonucu> TopluRedIsleminiBaslat(HashSet<Guid> secilenIdler, string redGerekcesi)
    {
        IslemSonucu sonuc = new IslemSonucu();
        string token = UTSToken.Token; 
        UtsAlmaService servis = new UtsAlmaService(token);

        using (dbDataContext db = new dbDataContext())
        {
            try
            {
                foreach (Guid currentGuidId in secilenIdler)
                {                    
                    int gonderilecekAdet = 1;
                    var kayit = db.UTSYeniAlmaBildirimleris.FirstOrDefault(x => x.BildirimId == currentGuidId);
                    if (kayit != null) gonderilecekAdet = Convert.ToInt32(kayit.Adet);
                    if (gonderilecekAdet <= 0) gonderilecekAdet = 1;

                    // --- RED SERVİSİ ÇAĞRISI ---
                    string apiCevap = await servis.AlmaBildirimiRedEt(currentGuidId.ToString(), gonderilecekAdet, redGerekcesi);

                    if (apiCevap.StartsWith("OK"))
                    {
                        sonuc.Basarili++;
                                            
                        if (kayit != null) kayit.IslemDurumu = 2;
                    }
                    else
                    {
                        sonuc.Hatali++;
                        sonuc.HataMesajlari.Add($"ID: {currentGuidId} -> {apiCevap}");
                    }
                }
                db.SubmitChanges();
            }
            catch (Exception ex)
            {
                sonuc.SistemHatasiVarMi = true;
                sonuc.SistemHatasiMesaji = ex.Message;
            }
        }
        return sonuc;
    }






    /// <summary>
    /// ///////////////////////////////////// AYRINTILI ALMA BİLDİRİMLERİ ÇEKME SERVİSİ ////////////////////////////////////////////
    /// </summary>
    public class UtsAyrintiliResponse
    {
        [JsonProperty("SNC")]
        public List<UtsAyrintiliKayit> SNC { get; set; }
    }

    public class UtsAyrintiliIstekModeli
    {
        [JsonProperty("BTI")] public string BildirimTipi { get; set; }
        [JsonProperty("BDR")] public string BildirimDurumu { get; set; }
        [JsonProperty("BZB")] public string BaslangicTarihi { get; set; }
        [JsonProperty("BZS")] public string BitisTarihi { get; set; }
        [JsonProperty("SAY")] public int SayfaNo { get; set; }
        [JsonProperty("ADT")] public int Adet { get; set; }
        //[JsonProperty("UNO")] public string UrunNo { get; set; }
    }
    public class UtsAyrintiliKayit
    {
        [JsonProperty("bildirimId")] public System.Guid bildirimId { get; set; }
        [JsonProperty("adet")] public int adet { get; set; }
        [JsonProperty("belgeNo")] public string belgeNo { get; set; }
        [JsonProperty("bildirenKurumNo")] public long? bildirenKurumNo { get; set; }
        [JsonProperty("bildirimDurumu")] public string bildirimDurumu { get; set; }
        [JsonProperty("bildirimTipi")] public string bildirimTipi { get; set; }
        [JsonProperty("digerKurumNo")] public long? digerKurumNo { get; set; }
        [JsonProperty("essizKimlik")] public string barkodNo { get; set; }
        [JsonProperty("lotBatchNumarasi")] public string lotBatchNumarasi { get; set; }
        [JsonProperty("olusturulmaTarihi")] public long olusturulmaTarihi { get; set; }
        [JsonProperty("seriNumarasi")] public string seriNumarasi { get; set; }
        [JsonProperty("urunNumarasi")] public string urunNumarasi { get; set; }
        [JsonProperty("urunTanimi")] public string urunTanimi { get; set; }
        [JsonProperty("karsiBildirimId")] public string karsiBildirimId { get; set; }
        [JsonProperty("olusturulmaTarihiString")] public string olusturulmaTarihiString { get; set; }
        
    }
    private class UtsAyrintiliService
    {
        // YENİ KEŞFETTİĞİN ADRES
        private const string BASE_URL = "https://utsuygulama.saglik.gov.tr/UTS/uh/rest/ayrintiliBildirim/sorgula";
        private string _token;

        public UtsAyrintiliService(string token)
        {
            _token = token;
        }        
        public async Task<List<UtsAyrintiliKayit>> DokumanaGoreGecmisCek()
        {
            List<UtsAyrintiliKayit> tumKayitlar = new List<UtsAyrintiliKayit>();
            HashSet<string> eklenenIdler = new HashSet<string>();
                        
            int sayfaBoyutu = 250;
            int suankiSayfa = 0;

            using (HttpClient client = new HttpClient())
            {
                client.Timeout = TimeSpan.FromMinutes(10);
                client.DefaultRequestHeaders.TryAddWithoutValidation("utstoken", _token);
                client.DefaultRequestHeaders.TryAddWithoutValidation("Authorization", "Bearer " + _token);
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                string url = "https://utsuygulama.saglik.gov.tr/UTS/uh/rest/ayrintiliBildirim/sorgula";

                
                while (true)
                {
                   
                    var istekModeli = new UtsAyrintiliIstekModeli
                    {
                        BildirimTipi = "ALMA",
                        BildirimDurumu = "AKTIF",
                        BaslangicTarihi = DateTime.Now.AddDays(-7).ToString("yyyy-MM-dd"),
                        BitisTarihi = DateTime.Now.ToString("yyyy-MM-dd"),

                        Adet = sayfaBoyutu,
                        SayfaNo = suankiSayfa
                    };

                    string jsonBody = JsonConvert.SerializeObject(istekModeli);
                    var content = new StringContent(jsonBody, Encoding.UTF8, "application/json");

                    try
                    {
                        var response = await client.PostAsync(url, content);
                        string jsonCevap = await response.Content.ReadAsStringAsync();

                        if (response.IsSuccessStatusCode)
                        {
                            var veri = JsonConvert.DeserializeObject<UtsAyrintiliResponse>(jsonCevap);

                            if (veri != null && veri.SNC != null && veri.SNC.Count > 0)
                            {
                                
                                int yeniEklenen = 0;
                                foreach (var kayit in veri.SNC)
                                {
                                    if (!eklenenIdler.Contains(kayit.bildirimId.ToString()))
                                    {
                                        eklenenIdler.Add(kayit.bildirimId.ToString());
                                        tumKayitlar.Add(kayit);
                                        yeniEklenen++;
                                    }
                                }

                                System.Diagnostics.Debug.WriteLine($"Sayfa {suankiSayfa} Çekildi. Gelen: {veri.SNC.Count} | Toplam: {tumKayitlar.Count}");

                                
                                if (veri.SNC.Count < sayfaBoyutu)
                                {
                                    break;
                                }

                                
                                suankiSayfa++;
                            }
                            else
                            {
                                System.Diagnostics.Debug.WriteLine("Veri boş geldi. Bitti.");
                                break;
                            }
                        }
                        else
                        {
                            System.Diagnostics.Debug.WriteLine("HATA: " + response.StatusCode + " " + jsonCevap);
                            break;
                        }
                    }
                    catch (Exception ex)
                    {
                        System.Diagnostics.Debug.WriteLine("BAĞLANTI HATASI: " + ex.Message);
                        break;
                    }

                    await Task.Delay(100);
                }
            }

            System.Diagnostics.Debug.WriteLine($"TOPLAM BULUNAN KAYIT: {tumKayitlar.Count}");
            return tumKayitlar;
        }
    }

    // --- ANA ÇALIŞTIRMA FONKSİYONU ---
    public async Task UtsAyrintiliVerileriniCekVeKaydet()
    {        
        UtsAyrintiliService servis = new UtsAyrintiliService(UTSToken.Token);

        SplashScreenManager.ShowDefaultWaitForm("UTS Veri Aktarımı", "Veriler analiz ediliyor...");

        
        var liste = await servis.DokumanaGoreGecmisCek();

        using (dbDataContext db = new dbDataContext())
        {           
            var gelenIdListesi = liste.Select(x => x.bildirimId).ToList();
                       
            var arsivdekiIdler = db.UTSGelenBildirimlers
                                   .Where(x => gelenIdListesi.Contains(x.BildirimId))
                                   .Select(x => x.BildirimId)
                                   .ToHashSet();

            
            var islemdekiIdler = db.UTSYeniAlmaBildirimleris
                                   .Where(x => gelenIdListesi.Contains(x.BildirimId))
                                   .Select(x => x.BildirimId)
                                   .ToHashSet();

            int arsivSayac = 0;
            int islemSayac = 0;

            foreach (var item in liste)
            {               
                if (!arsivdekiIdler.Contains(item.bildirimId))
                {
                    UTSGelenBildirimler yeni = new UTSGelenBildirimler();
                    yeni.BildirimId = item.bildirimId;
                    yeni.Adet = (item.adet > 0 ? item.adet : 1).ToString();
                    yeni.BelgeNo = item.belgeNo;
                    yeni.BildirenKurumNo = item.bildirenKurumNo;
                    yeni.BildirimDurumu = item.bildirimDurumu;
                    yeni.BildirimTipi = item.bildirimTipi;
                    yeni.DigerKurumNo = item.digerKurumNo;
                    yeni.BarkodNo = item.barkodNo;
                    yeni.LotBatchNo = item.lotBatchNumarasi;
                    yeni.OlusturulmaTarihi = DateTimeOffset.FromUnixTimeMilliseconds(item.olusturulmaTarihi).LocalDateTime;
                    yeni.SeriNo = item.seriNumarasi;
                    yeni.UrunNo = item.urunNumarasi;
                    yeni.UrunTanimi = item.urunTanimi;
                    yeni.KarsiBildirimId = item.karsiBildirimId;
                    yeni.VermeTarihi = item.olusturulmaTarihiString;
                    yeni.GonderenKurumAdi = KurumAdiGetir(Convert.ToInt64(item.digerKurumNo));

                    
                    yeni.IslemDurumu = 0;

                    db.UTSGelenBildirimlers.InsertOnSubmit(yeni);
                    arsivSayac++;
                }

                
                if (!islemdekiIdler.Contains(item.bildirimId))
                {
                    UTSYeniAlmaBildirimleri yeniAlmaKaydi = new UTSYeniAlmaBildirimleri();

                    yeniAlmaKaydi.BildirimId = item.bildirimId;
                    yeniAlmaKaydi.UrunNo = item.urunNumarasi;
                    yeniAlmaKaydi.GonderenKurumNo = item.digerKurumNo;
                    yeniAlmaKaydi.LotBatchNo = item.lotBatchNumarasi;
                    yeniAlmaKaydi.SeriNo = item.seriNumarasi;
                    yeniAlmaKaydi.UrunTanimi = item.urunTanimi;
                    yeniAlmaKaydi.GonderenKurumAdi = KurumAdiGetir(Convert.ToInt64(item.digerKurumNo));
                    yeniAlmaKaydi.Adet = item.adet > 0 ? item.adet : 1; // Adet kontrolü
                    yeniAlmaKaydi.BelgeNo = item.belgeNo;
                    yeniAlmaKaydi.BildirimDurumu = item.bildirimDurumu;

                    // Tarih dönüşümleri
                    yeniAlmaKaydi.BildirimZamani = DateTimeOffset.FromUnixTimeMilliseconds(item.olusturulmaTarihi).LocalDateTime;
                    try
                    {
                        yeniAlmaKaydi.VermeTarihi = Convert.ToDateTime(item.olusturulmaTarihiString);
                    }
                    catch
                    {
                        //yeniAlmaKaydi.VermeTarihi = DateTime.Now;
                    }

                    yeniAlmaKaydi.IslemDurumu = 99;

                    db.UTSYeniAlmaBildirimleris.InsertOnSubmit(yeniAlmaKaydi);
                    islemSayac++;
                }
            }

            // Değişiklikleri tek seferde kaydet
            db.SubmitChanges();

            SplashScreenManager.CloseForm();

            MessageBox.Show($"İşlem Tamamlandı!\n\n" +
                            $"📥 Toplam Çekilen: {liste.Count}\n" +
                            $"📂 Arşive Eklenen: {arsivSayac}\n" +
                            $"🔄 Senkronize Edilen (99): {islemSayac}");
        }
    }



    /// <summary>
    /// ////////////////////////////////////////  UTS KURUM ADLARI ÇEKME SERVİSİ //////////////////////////////////////////////////////
    /// </summary>
    public class UtsKurumDetay
    {
        public long KurumNo { get; set; }
        public string unvan { get; set; }
    }

    public class UtsYeniResponseModel
    {
       
        public List<UtsKurumDetay> data { get; set; }
    }

    // --- RAM ÖNBELLEK ---
    private static Dictionary<long, string> _ramCache = new Dictionary<long, string>();


    // --- ANA METOD  ---
    public string KurumAdiGetir(long kurumNo)
    {
        string userToken = UTSToken.Token; 
        

        if (_ramCache.ContainsKey(kurumNo))
        {
            return _ramCache[kurumNo];
        }
        

        string dbKurumAdi = YerelVeritabanindanGetir_KurumAdi(kurumNo);
        if (!string.IsNullOrEmpty(dbKurumAdi))
        {            
            if (!_ramCache.ContainsKey(kurumNo))
                _ramCache.Add(kurumNo, dbKurumAdi);

            return dbKurumAdi;
        }
                
        string apiKurumAdi = ApiSorgula(kurumNo, userToken);

        if (!string.IsNullOrEmpty(apiKurumAdi) && apiKurumAdi != "Kurum Bulunamadı")
        {            
            VeritabaniKaydet_KurumAdi(kurumNo, apiKurumAdi);

            if (!_ramCache.ContainsKey(kurumNo))
                _ramCache[kurumNo] = apiKurumAdi;

            return apiKurumAdi;
        }

        return "Bilinmeyen Kurum";
    }
        
    private string ApiSorgula(long kurumNo, string userToken)
    {
        try
        {
            
            System.Net.ServicePointManager.SecurityProtocol = System.Net.SecurityProtocolType.Tls12;
            var options = new RestClientOptions("https://utsuygulama.saglik.gov.tr")
            {
                Timeout = TimeSpan.FromMinutes(1),
                RemoteCertificateValidationCallback = (sender, certificate, chain, sslPolicyErrors) => true,
                UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/143.0.0.0 Safari/537.36"
            };
            var client = new RestClient(options);
            var request = new RestRequest("/UTS/rest/kurum/aktifTibbiCihazKurumListele", Method.Post);

            
            request.AddHeader("utsToken", userToken);
            request.AddHeader("Origin", "https://utsuygulama.saglik.gov.tr");
            request.AddHeader("Referer", "https://utsuygulama.saglik.gov.tr/UTS/tibbiCihaz");
            request.AddHeader("Sec-Fetch-Dest", "empty");
            request.AddHeader("Sec-Fetch-Mode", "cors");
            request.AddHeader("Sec-Fetch-Site", "same-origin");

            
            var payloadObj = new
            {
                queryPage = new { initialPage = 0, pageSize = 15 },
                sortInfo = new { sortFields = new[] { new { propertyName = "kurumNo", ascending = true } } },
                queryParameterDTOs = new object[]
                {
                new { queryParameterType = "SIMILARITY", propertyName = "unvan", similarityStrategy = "START" },
                new { queryParameterType = "EQUALITY", propertyName = "kurumNo", value = kurumNo },                
                new { queryParameterType = "EQUALITY", propertyName = "vergiNo" },
                new { queryParameterType = "EQUALITY", propertyName = "mersisNo" },
                new { queryParameterType = "EQUALITY", propertyName = "ckysKurumNo" },
                new { queryParameterType = "EQUALITY", propertyName = "veriKaynagi" },
                new { queryParameterType = "EQUALITY", propertyName = "guncellemeKaynagi" },
                new { queryParameterType = "EQUALITY", propertyName = "durum" },
                new { queryParameterType = "RANGE", propertyName = "creationDate" },
                new { queryParameterType = "CONTEXT", propertyName = "faaliyetAlani", similarityStrategy = "START" },
                new { queryParameterType = "EQUALITY", propertyName = "resmiAdres.il.bolge.id" },
                new { queryParameterType = "EQUALITY", propertyName = "resmiAdres.il.id" },
                new { queryParameterType = "EQUALITY", propertyName = "resmiAdres.ilce.id" }
                },
                queryTotal = false
            };

            string jsonString = JsonConvert.SerializeObject(payloadObj);
            byte[] fileBytes = Encoding.UTF8.GetBytes(jsonString);
            request.AddFile("queryOptionsDTO", fileBytes, "blob", "application/json");

            
            var response = client.ExecuteAsync(request).GetAwaiter().GetResult();

            if (response.IsSuccessful)
            {
                
                var veri = JsonConvert.DeserializeObject<UtsYeniResponseModel>(response.Content);

                if (veri != null && veri.data != null)
                {
                    var bulunan = veri.data.FirstOrDefault();
                    if (bulunan != null)
                    {
                        string sonucIsim = bulunan.unvan;

                        
                        if (!_ramCache.ContainsKey(kurumNo))
                        {
                            _ramCache[kurumNo] = sonucIsim;
                        }
                        
                        VeritabaniKaydet_KurumAdi(kurumNo, sonucIsim);

                        return sonucIsim;
                    }
                }
            }
            
            return "Bilinmeyen Kurum";
        }
        catch (Exception ex)
        {
            System.Diagnostics.Debug.WriteLine("KOD HATASI: " + ex.Message);
            return "Hata";
        }
    }
        
    private string YerelVeritabanindanGetir_KurumAdi(long no)
    {

        using (dbDataContext db = new dbDataContext())
        {
            try
            {
                var kurumAdi = db.KurumAdlaris.FirstOrDefault(a => a.KurumNo == no);

                return kurumAdi?.KurumAdi;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata {ex}");
                return null;
            }

        }
    }

    private void VeritabaniKaydet_KurumAdi(long no, string ad)
    {
        if (string.IsNullOrEmpty(ad)) return;

        using (dbDataContext db = new dbDataContext())
        {
            try
            {
                var mevcutKayit = db.KurumAdlaris.FirstOrDefault(a => a.KurumNo == no);

                if (mevcutKayit == null)
                {
                    KurumAdlari yeniKurum = new KurumAdlari();
                    yeniKurum.KurumNo = no;
                    yeniKurum.KurumAdi = ad;
                    yeniKurum.SonGuncelleme = System.DateTime.Now;

                    db.KurumAdlaris.InsertOnSubmit(yeniKurum);
                }
                else
                {
                    mevcutKayit.KurumAdi = ad;
                }
                db.SubmitChanges();
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Cache Kayıt Hatası: {ex.Message}");
            }
        }
    }

    public string RamdenGetir(long kurumNo)
    {
        if (_ramCache.ContainsKey(kurumNo)) return _ramCache[kurumNo];
        return null;
    }







    
}




