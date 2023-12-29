using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spor_Salonu_Proje.Interface
{
    public interface ISalonYonetimi 
    {
        void SalonOlustur(string ad, string tip);
        void SalonGuncelle(string ad, string tip);
    }
}
