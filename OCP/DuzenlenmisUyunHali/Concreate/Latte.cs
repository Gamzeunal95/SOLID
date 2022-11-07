using OCP.DuzenlenmisUyunHali.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP.DuzenlenmisUyunHali.Concreate
{
    public class Latte : CoffeeBase
    {
        / public override double TutarHesapla(double Adet)
        {

            // fiyat bilgilerini db'den cektiniz diyelim
            return Adet * 60;
        }
    }
}
