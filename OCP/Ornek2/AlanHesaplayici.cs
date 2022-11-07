using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP.Ornek2
{
    internal class AlanHesaplayici
    {
        public double AlanHesapla(Dikdortgen[] dikdortgens)
        {
            double alan = 0;
            foreach (var item in dikdortgens)
            {
                if (item is Dikdortgen)
                {
                    Dikdortgen dikdortgen = (Dikdortgen)item;
                    alan = dikdortgen.KisaKenar * dikdortgen.UzunKenar;
                }
                else if (item is Daire)
                {
                    Daire d = (Daire)item;
                    alan = d.YariCap * Math.PI * d.YariCap;
                }
            }
            return alan;
        }
    }
}
