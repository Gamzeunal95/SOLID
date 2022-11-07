using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP.OrnekBad
{
    internal class AlanHesaplayici
    {
        public double AlanHesapla(Dikdortgen dikdortgen)
        {
            return dikdortgen.KisaKenar * dikdortgen.UzunKenar;
        }


        public double AlanHesapla(Kare kare) 
        {
            return kare.KisaKenar * kare.UzunKenar;
        }
    }
}
