using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spor_Salonu_Proje.Interface
{
    public interface IUrunYonetimi
    {
        void UrunEkle();
        void UrunGuncelle(string yeniAd, double yeniFiyat);
    }
}
