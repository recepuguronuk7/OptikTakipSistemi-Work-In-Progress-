using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Optik_Takip_Sistemi
{
    internal class UTSKurumAdi
    {
        // --- MODELLER ---
        public class UtsKurumDetay
        {
            public long KurumNo { get; set; }
            public string unvan { get; set; }
        }

        public class UtsYeniResponseModel
        {
            // JSON'da "data" dizisi var
            public List<UtsKurumDetay> data { get; set; }
        }

        // --- RAM ÖNBELLEK ---
        private static Dictionary<long, string> _ramCache = new Dictionary<long, string>();


        // --- ANA METOD (Grid'den çağıracağınız metod bu) ---
        public string KurumAdiGetir(long kurumNo)
        {
            string userToken = "System609a96cc-efb2-4dfd-ae2d-03955ec4f8b5";
            // ADIM 1: RAM Kontrolü (Nanosaniye)
            if (_ramCache.ContainsKey(kurumNo))
            {
                return _ramCache[kurumNo];
            }

            // ADIM 2: Yerel Veritabanı Kontrolü (Milisaniye)
            string dbKurumAdi = YerelVeritabanindanGetir(kurumNo);
            if (!string.IsNullOrEmpty(dbKurumAdi))
            {
                // DB'de bulduk, hemen RAM'e de ekleyelim ki sonraki sorgu daha hızlı olsun
                if (!_ramCache.ContainsKey(kurumNo))
                    _ramCache.Add(kurumNo, dbKurumAdi);

                return dbKurumAdi;
            }

            // ADIM 3: API Sorgusu (Saniye)
            // DÜZELTME: Burada kendisini değil, aşağıdaki "ApiSorgula" metodunu çağırıyoruz.
            string apiKurumAdi = ApiSorgula(kurumNo, userToken);

            if (!string.IsNullOrEmpty(apiKurumAdi) && apiKurumAdi != "Kurum Bulunamadı")
            {
                // Hem DB'ye hem RAM'e kaydediyoruz
                VeritabaniKaydet(kurumNo, apiKurumAdi);

                if (!_ramCache.ContainsKey(kurumNo))
                    _ramCache[kurumNo] = apiKurumAdi;

                return apiKurumAdi;
            }

            return "Bilinmeyen Kurum";
        }

        // --- YARDIMCI METOD (Sadece API ile konuşur) ---
        private string ApiSorgula(long kurumNo, string userToken)
        {
            try
            {
                // 1. Ayarlar (Aynen kalıyor)
                System.Net.ServicePointManager.SecurityProtocol = System.Net.SecurityProtocolType.Tls12;
                var options = new RestClientOptions("https://utsuygulama.saglik.gov.tr")
                {
                    Timeout = TimeSpan.FromMinutes(1),
                    RemoteCertificateValidationCallback = (sender, certificate, chain, sslPolicyErrors) => true,
                    UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/143.0.0.0 Safari/537.36"
                };
                var client = new RestClient(options);
                var request = new RestRequest("/UTS/rest/kurum/aktifTibbiCihazKurumListele", Method.Post);

                // 2. Headerlar (Aynen kalıyor)
                request.AddHeader("utsToken", userToken);
                request.AddHeader("Origin", "https://utsuygulama.saglik.gov.tr");
                request.AddHeader("Referer", "https://utsuygulama.saglik.gov.tr/UTS/tibbiCihaz");
                request.AddHeader("Sec-Fetch-Dest", "empty");
                request.AddHeader("Sec-Fetch-Mode", "cors");
                request.AddHeader("Sec-Fetch-Site", "same-origin");

                // 3. Payload (Aynen kalıyor)
                var payloadObj = new
                {
                    queryPage = new { initialPage = 0, pageSize = 15 },
                    sortInfo = new { sortFields = new[] { new { propertyName = "kurumNo", ascending = true } } },
                    queryParameterDTOs = new object[]
                    {
                new { queryParameterType = "SIMILARITY", propertyName = "unvan", similarityStrategy = "START" },
                new { queryParameterType = "EQUALITY", propertyName = "kurumNo", value = kurumNo },
                // ... Diğer boş filtreler (Hata almamak için tutuyoruz) ...
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

                // 4. İsteği Gönder (String Olarak Alıyoruz)
                var response = client.ExecuteAsync(request).GetAwaiter().GetResult();

                if (response.IsSuccessful)
                {
                    // --- DEĞİŞİKLİK BURADA: JSON PARSE VE KAYIT ---

                    // Gelen string veriyi yeni modelimize çeviriyoruz
                    var veri = JsonConvert.DeserializeObject<UtsYeniResponseModel>(response.Content);

                    if (veri != null && veri.data != null)
                    {
                        var bulunan = veri.data.FirstOrDefault();
                        if (bulunan != null)
                        {
                            string sonucIsim = bulunan.unvan;

                            // BULDUK! HEMEN KAYDEDELİM Kİ BİR DAHA SORULMASIN

                            // A. RAM'e Ekle (Hız için)
                            // _ramCache ConcurrentDictionary ise TryAdd, değilse [] kullanın
                            if (!_ramCache.ContainsKey(kurumNo))
                            {
                                _ramCache[kurumNo] = sonucIsim;
                            }

                            // B. Veritabanına Ekle (Kalıcılık için)
                            VeritabaniKaydet(kurumNo, sonucIsim);

                            return sonucIsim;
                        }
                    }
                }

                // Veri bulunamazsa veya hata olursa
                return "Bilinmeyen Kurum";
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("KOD HATASI: " + ex.Message);
                return "Hata";
            }
        }

        // --- VERİTABANI İŞLEMLERİ (Kendi projenize göre doldurmalısınız) ---
        private string YerelVeritabanindanGetir(long no)
        {

            using (dbDataContext db = new dbDataContext())
            {
                try
                {
                    var kurumAdi = db.KurumAdlarıs.FirstOrDefault(a => a.KurumNo == no);

                    return kurumAdi?.KurumAdi;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Hata {ex}");
                    return null;
                }

            }
        }

        private void VeritabaniKaydet(long no, string ad)
        {
            if (string.IsNullOrEmpty(ad)) return;

            using (dbDataContext db = new dbDataContext())
            {
                try
                {
                    var mevcutKayit = db.KurumAdlarıs.FirstOrDefault(a => a.KurumNo == no);

                    if (mevcutKayit == null)
                    {
                        KurumAdları yeniKurum = new KurumAdları();
                        yeniKurum.KurumNo = no;
                        yeniKurum.KurumAdi = ad;
                        yeniKurum.SonGuncelleme = System.DateTime.Now;

                        db.KurumAdlarıs.InsertOnSubmit(yeniKurum);
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
}
