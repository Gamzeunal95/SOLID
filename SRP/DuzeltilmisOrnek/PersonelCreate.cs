using SRP.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP.DuzeltilmisOrnek
{
    public class PersonelCreate
    {

        public Logger Logger { get; set; }

        public PersonelCreate()
        {
            Logger = new Logger(@"personel2.txt", "Personel kaydi Başlatildi :" + DateTime.Now);
        }

        public void PersonelEkle(Personel personel)
        {
            string str = personel.Ad + ";" + personel.Soyad + ";" + personel.TcNo + ";" + personel.Email;

            Logger.Yaz(str);
        }

    }
}
