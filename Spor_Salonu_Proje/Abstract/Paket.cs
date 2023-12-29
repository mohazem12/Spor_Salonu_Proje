using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spor_Salonu_Proje.Abstract
{
    public abstract class Paket
    {
        public string PaketAdi { get; set; }
        public double Ucret { get; set; }
        public string paketOzellikler { get; set; }

        // override UylikPakit
        public abstract void PaketOlustur(string ad, double ucret);

        public abstract void PaketGuncelle(string ad, double ucret);

    }
}
