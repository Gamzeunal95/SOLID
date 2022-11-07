//using LSP.OrnekBad;
using LSP.OrnekBadDuzeltilmis;

namespace LSP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region OrnekBad
            //Dikdortgen dikdortgen = new Dikdortgen() { UzunKenar = 9, KisaKenar = 5 };
            //OrnekBad.Kare kare = new OrnekBad.Kare() { UzunKenar = 3, KisaKenar = 3 };
            //AlanHesaplayici hesaplayici = new AlanHesaplayici();
            //if (hesaplayici.AlanHesapla(dikdortgen) != 45)
            //{
            //    Console.WriteLine("Dikdortgenin alan hesabı hatalıdır.");
            //}
            //if (hesaplayici.AlanHesapla(kare) != 9)
            //{
            //    Console.WriteLine("Kare hesabı yanlıştır.");
            //}


            //OrnekBad.Kare yeniKare = new OrnekBad.Kare() { KisaKenar = 3, UzunKenar = 5 };


            //if (hesaplayici.AlanHesapla(yeniKare) != 15)
            //{
            //    Console.WriteLine("Alab hesabı yanlıştır.");
            //}
            #endregion

            #region OrnekBadDüzeltilmiş

            Sekil dikdortgen1 = new YeniDikdortgen() { KisaKenar = 3, UzunKenar = 5 };
            Sekil kare = new Kare() {Kenar = 5 };
            if (kare.AlanHesapla() != 25)
            {
                Console.WriteLine("Yanlış Hesap");
            }
            if (dikdortgen1.AlanHesapla() != 15)
            {
                Console.WriteLine("Dikdortgen hesabı yanlıs.");
            }


            #endregion
        }
    }
}