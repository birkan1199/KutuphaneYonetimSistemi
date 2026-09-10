using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneYonetimSistemi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Kitap> kitaplar = new List<Kitap>();
            List<Uye> uyeler = new List<Uye>();
            List<Odunc> oduncler = new List<Odunc>();

            while (true)
            {
                
                Console.WriteLine("");
                Console.WriteLine("Kütüphane Yönetim Sistemi\n");

                Console.WriteLine("Nasıl yardımcı olabilirim?\n");

                Console.WriteLine("1. Kitap Ekle");
                Console.WriteLine("2. Kitap Sil");
                Console.WriteLine("3. Kitap Listele");
                Console.WriteLine("4- Üye Ekle");
                Console.WriteLine("5. Üye Sil");
                Console.WriteLine("6. Üye Ara");
                Console.WriteLine("7. Kitap Ödünç Alma");
                Console.WriteLine("8- Kitap İade Et");
                Console.WriteLine("9- Kitap Ara");
                Console.WriteLine("10- Ödünç Geçmişi");
                Console.WriteLine("11- Çıkış");

                string secim = Console.ReadLine();

                switch(secim)
                {
                    case "1":
                        KitapEkle(kitaplar);
                        break;
                    case "2":
                        KitapSil(kitaplar);
                        break;
                    case "3":
                        KitapListele(kitaplar);
                        break; 
                    case "4":
                        UyeEkle(uyeler);
                        break;
                    case "5":
                        UyeSil(uyeler);
                        break;
                    case "6":
                        UyeAra(uyeler);
                        break;
                    case "7":
                        KitapOduncAlma(kitaplar, uyeler, oduncler);
                        break;
                    case "8":
                        KitapIadeEt(oduncler);
                        break;
                    case "9":
                        KitapAra(kitaplar);
                        break; 
                    case "10":
                        OduncGecmisi(oduncler);
                        break;
                    case "11":
                        Environment.Exit(0);
                        break;
                }
            }
                

           
        }

        static void KitapEkle(List<Kitap> kitaplar)
        {
            Console.WriteLine("Kitap Ekleme İşlemi");

            Console.WriteLine("ISBN:");
            string isbn = Console.ReadLine();

            if (kitaplar.Any(k => k.ISBN == isbn))
            {
                Console.WriteLine("Bu ISBN numarasına sahip bir kitap zaten kayıtlı.");
                return;
            }

            Console.WriteLine("Kitap Adı:");
            string kitapAdi = Console.ReadLine();

            Console.WriteLine("Yazar:");
            string yazar = Console.ReadLine();

            Console.WriteLine("Yayın Yılı:");
            int yayinYili = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Yayın Evi: ");
            string yayınevi = Console.ReadLine();

            Kitap yeniKitap = new Kitap();
            
            yeniKitap.ISBN = isbn;
            yeniKitap.Baslik = kitapAdi;
            yeniKitap.Yazar = yazar;
            yeniKitap.YayinYili = yayinYili;
            yeniKitap.Yayinevi = yayınevi;
            yeniKitap.OduncteMi = false;
            
            kitaplar.Add(yeniKitap);

            Console.WriteLine("kitap başarıyla eklendi");
        }

        static void KitapSil(List<Kitap> kitaplar)
        {
            Console.WriteLine("Kitap Silme İşlemi");

            Console.WriteLine("Silmek istediğiniz kitabın ISBN numarasını giriniz :");
            string isbn = Console.ReadLine();

            Kitap silinecekKitap = kitaplar.FirstOrDefault(k => k.ISBN == isbn);

            if(silinecekKitap != null)
            {
                kitaplar.Remove(silinecekKitap);
                Console.WriteLine("Kitap başarıyla silindi.");
            }
            else
            {
                Console.WriteLine("Silmek istediğiniz kitap bulunamadı.");
            }
        }

        static void KitapListele(List<Kitap> kitaplar)
        {
            Console.WriteLine("Kitap Listeleme İşlemi");

            if(kitaplar.Count== 0)
            {
                Console.WriteLine("Kütüphanede kayıtlı kitap bulunmamaktadır.");
                return;
            }

            foreach (var kitap in kitaplar)
            {
                Console.WriteLine("------------------");
                Console.WriteLine($"ISBN: {kitap.ISBN}");
                Console.WriteLine($"Kitap Adı: {kitap.Baslik}");
                Console.WriteLine($"Yazar: {kitap.Yazar}");
                Console.WriteLine($"Yayın Yılı: {kitap.YayinYili}");
                Console.WriteLine($"Yayın Evi: {kitap.Yayinevi}");
                Console.WriteLine($"Ödünçte Mi: {kitap.OduncteMi}");
                
            }
            Console.WriteLine("------------------");
        }

        static void UyeEkle(List<Uye> uyeler)
        {
            Console.WriteLine("Üye Ekleme İşlemi");

            Console.WriteLine("Üye ID:");
            int id = Convert.ToInt32(Console.ReadLine());

            if (uyeler.Any(u => u.UyeID == id))
            {
                Console.WriteLine("Bu ID numarasına sahip bir üye zaten kayıtlı.");
                return;
            }

            Console.WriteLine("Üye AdSoyad:");
            string adSoyad = Console.ReadLine();

            Console.WriteLine("Telefon:");
            string tel = Console.ReadLine();

            Uye yeniUye = new Uye();

            yeniUye.UyeID = id;
            yeniUye.AdSoyad = adSoyad;
            yeniUye.Telefon = tel;

            uyeler.Add(yeniUye);

            Console.WriteLine("Üye başarıyla eklendi");

        }

        static void UyeSil(List<Uye> uyeler)
        {
            Console.WriteLine("Üye Silme İşlemi");

            Console.WriteLine("silmek istediğiniz  üyenin ID'sini giriniz :");
            int uyeid = Convert.ToInt32(Console.ReadLine());

            Uye silinecekUye = uyeler.FirstOrDefault(u=>u.UyeID == uyeid);
            if(silinecekUye != null)
            {
                uyeler.Remove(silinecekUye);
                Console.WriteLine("Üye başarıyla silindi.");
            }
            else
                Console.WriteLine("Silmek istediğiniz üye bulunamadı.");
        }

        static void UyeAra(List<Uye> uyeler)
        {
            Console.WriteLine("Üye Arama İşlemi");

            Console.WriteLine("Aramak istediğiniz üyenin ID'sini giriz");
            int uyeid = Convert.ToInt32(Console.ReadLine());

            Uye arananUye = uyeler.FirstOrDefault(u => u.UyeID == uyeid);

            if(arananUye != null)
            {
                Console.WriteLine("------------");
                Console.WriteLine($"Üye ID: {arananUye.UyeID}");
                Console.WriteLine($"Üye Adı Soyadı: {arananUye.AdSoyad}");
                Console.WriteLine($"Telefon: {arananUye.Telefon}");
                Console.WriteLine("------------");
            }
            else
            {
                Console.WriteLine("Aramak istediğiniz üye bulunamadı.");
            }
        }

        static void KitapOduncAlma(List<Kitap> kitaplar, List<Uye> uyeler, List<Odunc> oduncler)
        {
            Console.WriteLine("Kitap Ödünç Alma İşlemi");

            Console.WriteLine("Ödünç almak istediğiniz kitabın ISBN'sini giriniz:");
            string isbn = Console.ReadLine();

            Kitap kitap = kitaplar.FirstOrDefault(k => k.ISBN == isbn);

            if(kitap == null)
            {
                Console.WriteLine("Aramak istediğiniz kitap bulunamadı.");
                return;
            }

            if(kitap.OduncteMi == true)
            {
                Console.WriteLine("Bu kitap zaten ödünç alınmış.");
                return;
            }

            Console.WriteLine("Üye ID'sini giriniz:");
            int uyeid = Convert.ToInt32(Console.ReadLine());

            Uye uye = uyeler.FirstOrDefault(u => u.UyeID == uyeid);

            if (uye == null)
            {
                Console.WriteLine("Aramak istediğiniz üye bulunamadı.");
                return;
            }

            Odunc yeniOdunc = new Odunc();

            yeniOdunc.Kitap = kitap;
            yeniOdunc.Uye = uye;
            yeniOdunc.AlisTarihi = DateTime.Now;
            yeniOdunc.SonTeslimTarihi = DateTime.Now.AddDays(14);

            oduncler.Add(yeniOdunc);

            kitap.OduncteMi = true;

            Console.WriteLine("Kitap başarıyla ödünç verildi.");
            Console.WriteLine("Son teslim tarihi: {0}", yeniOdunc.SonTeslimTarihi);
        }

        static void KitapIadeEt(List<Odunc> oduncler)
        {
            Console.WriteLine("Kitap İade Et İşlemi");

            Console.WriteLine("iade etmek istediğiniz kitabın ISBN'sini giriniz:");
            string isbn = Console.ReadLine();

            Odunc odunc = oduncler.FirstOrDefault(o => o.Kitap.ISBN == isbn && o.TeslimTarihi == null);

            if(odunc == null)
            {
                Console.WriteLine("Aramak istediğiniz kitap iade edilebilir durumda değil.");
                return;
            }
            else
            {
                odunc.TeslimTarihi = DateTime.Now;
                odunc.Kitap.OduncteMi = false;
                Console.WriteLine("Kitap başarıyla iade edildi.");

                if(odunc.TeslimTarihi > odunc.SonTeslimTarihi)
                {
                    TimeSpan gecikme = odunc.TeslimTarihi.Value - odunc.SonTeslimTarihi;  
                    int gecikmeGun = gecikme.Days;
                    double ceza = gecikmeGun * 5;

                    Console.WriteLine($"kitap {gecikmeGun} gün geç kaldı. Ceza: {ceza} TL");
                }
                else
                {
                    Console.WriteLine("Kitap zamanında iade edildi. Ceza yok.");
                }
            }
        }

        static void KitapAra(List<Kitap> kitaplar)
        {
            Console.WriteLine("Kitap Arama İşlemi");

            Console.WriteLine("Aramak istediğiniz kitabın ISBN'sini giriniz:");
            string isbn = Console.ReadLine();

            Kitap arananKitap = kitaplar.FirstOrDefault(k => k.ISBN == isbn);

            if(arananKitap != null)
            {
                Console.WriteLine("------------");
                Console.WriteLine($"Kitap Adı: {arananKitap.Baslik}");
                Console.WriteLine($"Yazar: {arananKitap.Yazar}");
                Console.WriteLine($"ISBN: {arananKitap.ISBN}");
                Console.WriteLine("------------");
            }
            else
            {
                Console.WriteLine("Aramak istediğiniz kitap bulunamadı.");
            }
        }

        static void OduncGecmisi(List<Odunc> oduncler)
        {
            Console.WriteLine("Ödünç Geçmişi İşlemi");

            if(oduncler.Count == 0)
            {
                Console.WriteLine("Henüz ödünç alınmış kitap bulunmamaktadır.");
                return;
            }
            
            foreach(Odunc odunc in oduncler)
            {
                Console.WriteLine("------------------");

                Console.WriteLine($"Kitap: {odunc.Kitap.Baslik}");
                Console.WriteLine($"ISBN: {odunc.Kitap.ISBN}");

                Console.WriteLine($"Üye: {odunc.Uye.AdSoyad}");
                Console.WriteLine($"Üye ID: {odunc.Uye.UyeID}");

                Console.WriteLine($"Alış Tarihi: {odunc.AlisTarihi}");
                Console.WriteLine($"Son Teslim Tarihi: {odunc.SonTeslimTarihi}");

                if(odunc.TeslimTarihi == null)
                {
                    Console.WriteLine("Kitap henüz iade edilmemiş.");
                }
                else
                {
                    Console.WriteLine($"Teslim Tarihi: {odunc.TeslimTarihi}");
                }
                Console.WriteLine("------------------");
            }
        }
    }
}
