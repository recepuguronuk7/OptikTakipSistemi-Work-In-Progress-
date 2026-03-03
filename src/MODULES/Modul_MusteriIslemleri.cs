using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Optik_Takip_Sistemi
{
    internal class Modul_MusteriIslemleri
    {
        public bool MusteriKaydet(string _ad, string _soyad, string _tcno, string _telno, string _adres)
        {
            using (dbDataContext db = new dbDataContext())
            {
                if(_ad != "" &&  _soyad != "" && _tcno != "" && _telno != "" && _adres != "" && _tcno.Length == 11 && _telno.Length == 10)
                {
                    bool varMi = db.Musterilers.Any(a => _tcno == a.TCNo);
                    try
                    {
                        if (varMi)
                        {
                            MessageBox.Show("Bu müşteri sisteme zaten kayıtlı.");
                            return false;
                        }
                        else
                        {
                            var kayit = new Musteriler()
                            {
                                Ad = _ad,
                                Soyad = _soyad,
                                TCNo = _tcno,
                                TelNo = _telno,
                                Adres = _adres
                            };
                            db.Musterilers.InsertOnSubmit(kayit);
                            db.SubmitChanges();
                            MessageBox.Show("Yeni müşteri kaydı yapıldı.");
                            return true;
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Hata kodu: {ex}");
                        return false;
                    }
                }
                else
                {
                    if(_telno.Length != 10)
                    {                        
                        MessageBox.Show("Tel No eksik veya hatalı.");
                    }
                    else if(_tcno.Length != 11)
                    {
                        MessageBox.Show("TC No eksik veya hatalı.");
                    }
                    else
                    {
                        MessageBox.Show("Kayıt için bilgiler eksiksiz olmalıdır.");
                    }                        
                    return false;
                }
                
            }
        }
        public Musteriler MusteriGetir(string _tcno)
        {
            using (dbDataContext db = new dbDataContext())
            {
                try
                {
                    var ara = db.Musterilers.FirstOrDefault(f => f.TCNo == _tcno);

                    if (ara == null)
                    {
                        MessageBox.Show("Müşteri kaydı sistemde bulunmamaktadır.");
                        return null;    
                    }
                    else
                    {
                        return ara;
                    }
                }
                catch (Exception ex) 
                {
                    MessageBox.Show($"Hata Kodu: {ex}");
                    return null;
                }
            }
        }
        public bool MusteriDuzenle(string _ad, string _soyad, string _tcno, string _telno, string _adres)
        {
            using (dbDataContext db = new dbDataContext())
            {
                var ara = db.Musterilers.FirstOrDefault(f => f.TCNo == _tcno);
                
                if(ara != null)
                {
                    ara.Ad = _ad;
                    ara.Soyad = _soyad;
                    ara.TelNo = _telno;
                    ara.Adres = _adres;
                    db.SubmitChanges();
                    MessageBox.Show("Düzenleme başarılı.");
                    return true;
                }
                else
                {
                    MessageBox.Show("Düzenleme yapılamadı.");
                    return false;
                }

            }
        }
    }

}
