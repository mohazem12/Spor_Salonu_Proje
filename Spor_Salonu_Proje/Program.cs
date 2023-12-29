using System.Collections.Generic;
using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spor_Salonu_Proje
{
    public class Program
    {

        static void Main(string[] args)
        {
         //   List<Uye> uye = new List<Uye>();

            Uye uye = new Uye(32758, "Mehmet", "Ismail");

            bool devam = true;
            while (devam) 
            {
                Console.WriteLine("Hangi işlemi yapmak istersiniz?");
                Console.WriteLine("1. Üye İşlemleri" +
                              "\n2. Üyelik Paketi İşlemleri" +
                              "\n3. Salon İşlemleri" +
                              "\n4. Vitamin Bar Ürünleri İşlemleri" +
                              "\n5. Eğitici İşlemleri" +
                              "\n6. Diyetisyen İşlemleri" +
                              "\n7. gucelleme islemleri"+
                              "\n8. verilimis programlar goruntule "+
                              "\n9. Çıkış");
             int secim = Convert.ToInt32(Console.ReadLine());

                switch (secim)
              {
                case 1:
                    Console.WriteLine("\n1- Üye İşlemleri:");
                    Console.WriteLine("...");

                    uye.UyelikKaydiOlustur(32758, "Mehmet", "Ismail");

                    uye.PaketSatinAlma("Fitness salonu, sauna, grup dersleri");

                    uye.KullanimDurumuGuncelle(true, true, true, true, true);

                    uye.BeslenmeProgramiGoruntule();

                    uye.AntrenmanProgramiGoruntule();

                    uye.SMSGonderme(DateTime.Now);

                    uye.EmanetGiysiDolabiKullanim();

                    uye.VitaminBarKullanim();

                    Console.WriteLine("..................................");
                    break;
                case 2:
                    Console.WriteLine("\n2- Üyelik Paketi İşlemleri:");
                    Console.WriteLine("...");
                    UyelikPaketi paket = new UyelikPaketi();

                    paket.PaketOlustur("Gold Paket", 150);
                    paket.PaketGuncelle("Platinum Paket", 200);

                    Console.WriteLine("Güncellenmiş Üyelik Paketi Özellikleri:");
                    Console.WriteLine("Paket Adı: " + paket.PaketAdi);
                    Console.WriteLine("Ücret: " + paket.Ucret);
                    Console.WriteLine("..................................");

                    break;
                case 3:
                    Console.WriteLine("\n3- Salon İşlemleri:");
                    Console.WriteLine("...");
                    Salon salon = new Salon();
                    salon.SalonOlustur("Fitness Center", "Spor Salonu");
                    salon.SalonGuncelle("Health Club", "Sağlık Kulübü");

                    Console.WriteLine("Güncellenmiş Salon Bilgileri:");
                    Console.WriteLine("Salon Adı: " + salon.SalonAdi);
                    Console.WriteLine("Salon Tipi: " + salon.Seans);
                    Console.WriteLine("..................................");

                    break;
                case 4:
                    Console.WriteLine("\n4- Vitamin Bar Ürünleri İşlemleri:");
                    Console.WriteLine("...");
                    VitaminBarUrunu vitaminBarUrunu = new VitaminBarUrunu();
                    vitaminBarUrunu.UrunAdi = "Protein Shake";
                    vitaminBarUrunu.Fiyat = 15.99;

                    vitaminBarUrunu.UrunEkle();
                    vitaminBarUrunu.UrunGuncelle("Energy Drink", 12.99);
                    Console.WriteLine("..................................");

                    break;
                case 5:
                    Console.WriteLine("\n5- Eğitici İşlemleri:");
                    Console.WriteLine("...");
                    Egitici egitici = new Egitici();
                    egitici.Ad = "Emma";
                    egitici.Soyad = "Smith";
                    egitici.EgitimVer("Fitness ve Kardiyo");
                    egitici.AntrenmanProgramiOlustur();
                    egitici.SaglikBilgisiTakibi();

                    Console.WriteLine($"Şu anda \"{egitici.VerilenEgitimKursu}\" konusunda eğitim vermektedir.");
                    Console.WriteLine("..................................");

                    break;
                case 6:
                    Console.WriteLine("\n6- Diyetisyen İşlemleri:");
                    Console.WriteLine("...");
                    Diyetisyen diyetisyen = new Diyetisyen();
                    diyetisyen.Ad = "Emily";
                    diyetisyen.Soyad = "Johnson";

                    diyetisyen.DiyetProgramiOlustur();
                    diyetisyen.SaglikVeSporBilgileriniGoruntule();
                    diyetisyen.VucutBilgileriniGuncelle();
                    diyetisyen.RaporOlustur();
                    Console.WriteLine("..................................");

                    break;

                case 7:
                    DateTime tarih = new DateTime(2023, 12, 28); // tarih
                    uye.SMSGonderme(tarih);
                    uye.KiloGuncelle(75);
                    uye.BoyGuncelle(180);

                    uye.UyelikSuresiGuncelle(DateTime.Now.AddMonths(6)); // 6 ay eklenmiş
                    Console.WriteLine("..................................");

                        break;
                case 8:
                    uye.BeslenmeProgramiGoruntule();

                    uye.AntrenmanProgramiGoruntule();

                    Console.WriteLine("..................................");

                        break;
                case 9:
                    devam = false;
                    Console.WriteLine("\nProgramdan çıkılıyor...");
                    break;

                    default:
                    Console.WriteLine("\nGeçersiz seçim!");
                    break;

                }
            }
            Console.ReadLine();

        }

    }
}
