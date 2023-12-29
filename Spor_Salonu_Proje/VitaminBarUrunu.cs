using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spor_Salonu_Proje.Abstract;
using Spor_Salonu_Proje.Interface;

namespace Spor_Salonu_Proje
{
    public class VitaminBarUrunu : IUrunYonetimi
    {
        public string UrunAdi { get; set; }
        public double Fiyat { get; set; }

        public void UrunEkle()
        {
            Console.WriteLine($"\"{UrunAdi}\" adlı yeni vitamin bar ürünü eklendi. Fiyat: {Fiyat}");
        }

        public void UrunGuncelle(string yeniAd, double yeniFiyat)
        {
            this.UrunAdi = yeniAd;
            this.Fiyat = yeniFiyat;
            Console.WriteLine($"Vitamin bar ürünü güncellendi. Yeni ad: {UrunAdi}, Yeni fiyat: {Fiyat}");
        }
    }
}
