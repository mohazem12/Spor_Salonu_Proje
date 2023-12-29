using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spor_Salonu_Proje.Abstract;

namespace Spor_Salonu_Proje
{
    public class UyelikPaketi : Paket
    {
        public string PaketAdi { get; set; }
        public double Ucret { get; set; }
        
        public override void PaketOlustur(string ad, double ucret)
        {
            PaketAdi = ad;
            Ucret = ucret;
            Console.WriteLine("Yeni üyelik paketi oluşturuldu.");
        }

        public override void PaketGuncelle(string ad, double ucret)
        {
            PaketAdi = ad;
            Ucret = ucret;

            Console.WriteLine("Üyelik paketi güncellendi.");
        }
    }
}
