using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP.Ornek
{
    public class KofteciRamiz
    {
        private Kofte kofte = new Kofte();
        private Tavuk tavuk = new Tavuk();


        public void Pisir()    // Kofteci ramizi pisirmek için hem tavuk hem tavuğa bağlamış oluyoruz. Bu yanlış kofte gerekliyse tavugu soyutlamamız gerek 
        {
            kofte.KoftePisir();
            tavuk.TavukPisir();

        }
    }
}
