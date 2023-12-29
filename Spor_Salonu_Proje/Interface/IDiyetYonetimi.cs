using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spor_Salonu_Proje.Abstract;

namespace Spor_Salonu_Proje.Interface
{
    public interface IDiyetYonetimi 
 
    {
        void DiyetProgramiOlustur(); 
        void SaglikVeSporBilgileriniGoruntule(); 
        void VucutBilgileriniGuncelle(); 
        void RaporOlustur();
    }
}
