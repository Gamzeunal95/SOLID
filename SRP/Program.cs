using SRP.DuzeltilmisOrnek;
using SRP.Entity;

namespace SRP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region SRP 
            Personel ali = new Personel { Ad = "Ali", Soyad = "Yilmaz", TcNo = "48593475638", Email = "aliyilmaz@gmail.com" };
            PersonelCreate personelCreate = new PersonelCreate();
            Logger logger = new Logger(@"personel2.txt", "Test");
            personelCreate.PersonelEkle(ali);

            #endregion



        }
    }
}