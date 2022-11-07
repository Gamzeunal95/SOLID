using DIP.OrnekDuzenlenmis.Abstract;
using DIP.OrnekDuzenlenmis.Concreate;
using System.Net.NetworkInformation;

namespace DIP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Ornek Solıd prensibine uymayan



            #endregion


            #region OrnekDuzeltilmis SOLID prensibine uygun

            IPisir Kofte = new YeniKofte();
            IPisir Tavuk = new YeniTavuk();
            IPisir patates = new Patates();

            List<IPisir> urunlerim = new List<IPisir>();
            urunlerim.Add(Patates);
            urunlerim.Add(Tavuk);
            urunlerim.Add(Kofte);

            KofteciYusuf 


            #endregion
        }
    }
}