//using OCP.Ornek2;
using OCP.Ornek2;
using OCP.Ornek2Duzeltilmis;

namespace OCP
{
    internal class Program
    {
        /*
        Open Close Principle :

        Sınıflar gelişmeye açık lakin değişmeye kapalı olmalıdır.

         */
        static void Main(string[] args)
        {
            //AlanHesaplayici hesaplayici = new();
            //Dikdortgen dikdortgen = new ();
            //dikdortgen.KisaKenar = 4;
            //dikdortgen.UzunKenar = 5;
            //Daire daire = new Daire();
            //daire.YariCap = 6;                 

            hesapla(dikdortgen);
            hesapla(daire);

            #region Düzeltilmisini çalıştırdığımız kısım 

            DikUcgen dikUcgen = new DikUcgen { KisaKenar = 4, UzunKenar = 5 };
            YeniDaire daire = new YeniDaire { YarıCap = 5 };
            YeniDikdortgen dikdortgen = new YeniDikdortgen { UzunKenar = 6, KisaKenar = 9 };

            // Yerine 
            ISekil dikUcgen2 = new DikUcgen { KisaKenar = 4, UzunKenar = 5 };
            ISekil daire2 = new YeniDaire { YarıCap = 5 };
            ISekil dikdortgen2 = new YeniDikdortgen { UzunKenar = 6, KisaKenar = 9 };

            hesapla(dikUcgen);
            hesapla(daire);
            hesapla(dikdortgen);


            #endregion
        }
        private static void hesapla(ISekil sekil)    // Ornek2
        {
            sekil.AlanHesapla();
        }
    }
}