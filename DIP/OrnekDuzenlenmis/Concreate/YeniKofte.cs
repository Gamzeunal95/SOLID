using DIP.OrnekDuzenlenmis.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP.OrnekDuzenlenmis.Concreate
{
    public class YeniKofte : IPisir
    {
        public void Pisir()
        {
            Console.WriteLine("Kofte Pisti");
        }
    }
}
