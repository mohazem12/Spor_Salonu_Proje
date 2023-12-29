using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spor_Salonu_Proje.Interface
{
    public interface IUyelikYonetimi
    {
        void UyelikKaydiOlustur(int id,string ad, string soyad);
        void PaketSatinAlma(string ozellikler);
        void KullanimDurumuGuncelle(bool beslenme, bool antrenman, bool smsAlma, bool emanetGiysi, bool vitaminBar);
        void BeslenmeProgramiGoruntule();
        void AntrenmanProgramiGoruntule();
        void EmanetGiysiDolabiKullanim();
        void VitaminBarKullanim();
        void SMSGonderme(DateTime tarih);
        void KiloGuncelle(double kilo);
        void BoyGuncelle(double boy);
        void UyelikSuresiGuncelle(DateTime uyelikSuresi);
        void BilgileriGoruntule();
        void PaketDoluluklariniTespitEt(List<string> paketler);
        void BileklikKullan(bool kullanildiMi);



    }
}
