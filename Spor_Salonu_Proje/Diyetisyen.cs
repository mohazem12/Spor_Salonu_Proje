using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spor_Salonu_Proje.Interface;

namespace Spor_Salonu_Proje
{
    public class Diyetisyen :  IDiyetYonetimi
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }

        public void DiyetProgramiOlustur()
        {
            Console.WriteLine($"{Ad} {Soyad}, üye için özel diyet programı oluşturdu.");
        }

        public  void SaglikVeSporBilgileriniGoruntule()
        {
            Console.WriteLine($"{Ad} {Soyad}, üyenin sağlık ve spor bilgilerini görüntülüyor.");
        }

        public  void VucutBilgileriniGuncelle()
        {
            Console.WriteLine($"{Ad} {Soyad}, üyenin vücut bilgilerini güncelliyor.");
        }

        public  void RaporOlustur()
        {
            Console.WriteLine($"{Ad} {Soyad}, üye için rapor oluşturuyor.");
        }
    }
}
