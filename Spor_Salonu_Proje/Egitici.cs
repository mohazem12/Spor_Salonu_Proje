using Spor_Salonu_Proje.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spor_Salonu_Proje
{
    public class Egitici : IEgitimYonetimi
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string VerilenEgitimKursu { get; set; }

        public void AntrenmanProgramiOlustur()
        {
            Console.WriteLine($"{Ad} {Soyad}, üye için özel antrenman programı oluşturdu.");
        }

        public void EgitimVer(string egitim)
        {
            VerilenEgitimKursu = egitim;
            Console.WriteLine($"{Ad} {Soyad}, \"{egitim}\" konusunda eğitim veriyor.");
        }

        public void SaglikBilgisiTakibi()
        {
            Console.WriteLine($"{Ad} {Soyad}, üyenin sağlık ve spor bilgilerini takip ediyor.");
        }
    }
}
