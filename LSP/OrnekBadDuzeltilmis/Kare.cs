using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP.OrnekBadDuzeltilmis
{
    internal class Kare : Sekil
    {
        public int Kenar { get; set; }

        override public double AlanHesapla()
        {
            return Kenar * Kenar;
        }

    }
}
