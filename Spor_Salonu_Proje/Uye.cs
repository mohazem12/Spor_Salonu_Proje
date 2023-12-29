using Spor_Salonu_Proje;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spor_Salonu_Proje.Interface;

namespace Spor_Salonu_Proje
{
    public class Uye : IUyelikYonetimi 

    {
    private int Id { get; set; }
    private string Ad { get; set; }
    private string Soyad { get; set; }
    private bool bileklik { get; set; }
    public bool UyelikDurumu { get; set; }
    public string Ozellikler { get; set; }
    public bool BeslenmeProgrami { get; set; }
    public bool AntrenmanProgrami { get; set; }
    public bool SMSAlma { get; set; }
    public bool EmanetGiysiDolabiKullanimi { get; set; }
    public bool VitaminBarKullanimi { get; set; }
    private double Kilo { get; set; }
    private double Boy { get; set; }
    private DateTime UyelikSuresi { get; set; }



    public Uye(int id, string ad, string soyad)
    {

        Id = id;
        Ad = ad;
        Soyad = soyad;
        UyelikDurumu = true;
        Kilo = 0;
        Boy = 0;
        UyelikSuresi = DateTime.Now;
    }

    public void UyelikKaydiOlustur(int id, string ad, string soyad)
    {
        Id = id;
        Ad = ad;
        Soyad = soyad;
        UyelikDurumu = true;
        Console.WriteLine("Üyelik kaydı oluşturuldu.");
    }

    public void PaketSatinAlma(string ozellikler)
    {
        Ozellikler = ozellikler;
        Console.WriteLine("Paket satın alma işlemi tamamlandı.");
    }

    public void KullanimDurumuGuncelle(bool beslenme, bool antrenman, bool smsAlma, bool emanetGiysi, bool vitaminBar)
    {
        BeslenmeProgrami = beslenme;
        AntrenmanProgrami = antrenman;
        SMSAlma = smsAlma;
        EmanetGiysiDolabiKullanimi = emanetGiysi;
        VitaminBarKullanimi = vitaminBar;
        Console.WriteLine("Kullanım durumu güncellendi.");
    }

    public void BeslenmeProgramiGoruntule()
    {
        if (BeslenmeProgrami)
        {

            Console.WriteLine("Beslenme programı: ..."); // Burada üyenin beslenme programı bilgisi gösterilir
            string besleme = Console.ReadLine();
        }
        else
        {
            Console.WriteLine("Beslenme programı henüz tanımlanmamış.");
        }

    }

    public void AntrenmanProgramiGoruntule()
    {
        if (AntrenmanProgrami)
        {
            Console.WriteLine("Antrenman programı: ..."); // Burada üyenin antrenman programı bilgisi gösterilir
        }
        else
        {
            Console.WriteLine("Antrenman programı henüz tanımlanmamış.");
        }
    }

    public void EmanetGiysiDolabiKullanim()
    {
        if (EmanetGiysiDolabiKullanimi)
        {
            Console.WriteLine(
                "Emanet giysi dolabı kullanıldı."); // Burada üyenin emanet giysi dolabı kullanımı işlemi yapılır
        }
        else
        {
            Console.WriteLine("Emanet giysi dolabı kullanımına izin verilmemiş.");
        }
    }

    public void VitaminBarKullanim()
    {
        if (VitaminBarKullanimi)
        {
            Console.WriteLine("Vitamin bar ürünleri kullanıldı."); // Burada üyenin vitamin bar kullanımı işlemi yapılır
        }
        else
        {
            Console.WriteLine("Vitamin bar kullanımına izin verilmemiş.");
        }
    }

    public void SMSGonderme(DateTime tarih)
    {
        DateTime bugun = DateTime.Now;
        if (tarih.Date == bugun.Date)
        {
            Console.WriteLine("Bugün SMS gönderildi."); // Belirli bir tarihte SMS gönderimi işlemi yapılır
        }
        else
        {
            Console.WriteLine("Belirtilen tarihte SMS gönderimi yapılamaz.");
        }
    }

    public void KiloGuncelle(double kilo)
    {
        Console.WriteLine("Yeni kilo durumu giriniz: ");
        string kiloInput = Console.ReadLine();

        if (double.TryParse(kiloInput, out double yeniKilo))
        {
            Kilo = yeniKilo;
            Console.WriteLine("Kilo güncellendi.");
        }
        else
        {
            Console.WriteLine("Geçersiz bir sayı girişi yapıldı.");
        }
    }

    public void BoyGuncelle(double boy)
    {
        Console.WriteLine("Yeni boy durumu giriniz: ");
        string boyInput = Console.ReadLine();

        if (double.TryParse(boyInput, out double yeniBoy))
        {
            Boy = yeniBoy;
            Console.WriteLine("Boy güncellendi.");
        }
        else
        {
            Console.WriteLine("Geçersiz bir sayı girişi yapıldı.");
        }
    }

    public void UyelikSuresiGuncelle(DateTime uyelikSuresi)
    {
        UyelikSuresi = uyelikSuresi;
        Console.WriteLine("Üyelik süresi güncellendi.");
    }

    public void BilgileriGoruntule()
    {
        Console.WriteLine($"Ad: {Ad}, Soyad: {Soyad}, Kilo: {Kilo} kg, Boy: {Boy} cm");
        Console.WriteLine($"Üyelik Durumu: {(UyelikDurumu ? "Aktif" : "Pasif")}");
        Console.WriteLine($"Üyelik Süresi: {UyelikSuresi}");
    }

    public void BileklikKullan(bool kullanildiMi)
    {
        bileklik = kullanildiMi;
        Console.WriteLine("Bileklik durumu güncellendi.");
    }

    public void PaketDoluluklariniTespitEt(List<string> paketler)
    {
        if (bileklik)
        {
            Console.WriteLine("Paket dolulukları tespit edildi:");
            foreach (var paket in paketler)
            {
                Console.WriteLine($"Paket: {paket} - Dolu");
            }
        }
        else
        {
            Console.WriteLine("Bileklik kullanılmadığı için paket bilgilerine erişilemiyor.");
        }
    }
    }

}


