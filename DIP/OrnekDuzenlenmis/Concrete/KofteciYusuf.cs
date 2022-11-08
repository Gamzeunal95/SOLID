using DIP.OrnekDuzenlenmis.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP.OrnekDuzenlenmis.Concrete
{
    public class KofteciYusuf
    {
        private List<IPisir> _urunler;

        public KofteciYusuf(List<IPisir> urunler)
        {
            _urunler = urunler;
        }

        public void Pisir()
        {
            foreach (var item in _urunler)
            {
                item.Pisir();
            }
        }
    }
}
