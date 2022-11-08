using OCP.DuzenlenmisUyunHali.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP.DuzenlenmisUyunHali.Concrete
{
    public class Cappucino : CoffeeBase
    {
        public override double TutarHesapla(double Adet)
        {
            return Adet * 70;
        }
    }
}
