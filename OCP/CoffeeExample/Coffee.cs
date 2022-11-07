using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP.CoffeeExample    // Bu şekilde yapmak solıd prensiplerine uygun değildir.
{
    public enum CoffeeType
    {
        Latte = 1,
        Espresso = 2,
        Cappucino = 3,
        TurkKahvesi
    }

    public class Coffee
    {
        public double GetTotalPrice(double Adet, CoffeeType coffeeType)
        {
            double toplamFiyat = 0;
            switch (coffeeType)
            {
                case CoffeeType.Latte:
                    toplamFiyat += Adet * 60;
                    break;
                case CoffeeType.Espresso:
                    toplamFiyat += Adet * 50;
                    break;
                case CoffeeType.Cappucino:
                    toplamFiyat += Adet * 70;
                    break;
                case CoffeeType.TurkKahvesi:
                    toplamFiyat += Adet * 30;
                    break;
                default:
                    break;
            }
            return toplamFiyat;
        }
    }
}
