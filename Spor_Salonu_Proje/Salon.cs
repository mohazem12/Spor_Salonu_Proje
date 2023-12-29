using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spor_Salonu_Proje.Interface;

namespace Spor_Salonu_Proje
{
    public class Salon : ISalonYonetimi
    {
        public string SalonAdi { get; set; }
        public string Seans { get; set; }

        public void SalonOlustur(string ad, string tip)
        {
            SalonAdi = ad;
            Seans = tip;
            Console.WriteLine("Yeni salon oluşturuldu.");
        }

        public void SalonGuncelle(string ad, string tip)
        {
            SalonAdi = ad;
            Seans = tip;
            Console.WriteLine("Salon bilgileri güncellendi.");
        }
    }
}
