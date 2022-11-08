using DIP.OrnekDuzenlenmis.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP.OrnekDuzenlenmis.Concrete
{
    public class YeniTavuk : IPisir
    {
        public void Pisir()
        {
            Console.WriteLine("Tavuk Pisti");
        }
    }
}
