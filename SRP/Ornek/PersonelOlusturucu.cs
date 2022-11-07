using SRP.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP.Ornek    // Bu şekidle yapılması solıd prensiplerine aykırıdır. Bu şekilde çalışır ama herşeyi bir arada yapmak doğru bir yol olmayacaktır.
{
    public class PersonelOlusturucu
    {       
        public void PersonelEKle( Personel personel)
        {
			try
			{
				#region Personel Kaydetme İslemi

				string str = personel.Ad + " ; " + personel.Soyad + ";" + personel.TcNo + ";" + personel.Email;
				File.WriteAllText(@"personel.txt",str);

				#endregion

				#region Kaydedilen Personelin Loglanması
				
				string log = "Kayit Tarihi: " + DateTime.Now + "Kaydedilen Kişi: " + personel.Ad + " " + personel.Soyad;


				#endregion
			}
			catch (Exception ex)
			{
				#region Eger Hata yakalarsa Error.txt dosyasına yazsın.
				File.WriteAllText(@"Error.text", "HataTarihi:" + DateTime.Now + "Hata:" + ex.Message); 
				#endregion

				throw;
			}
        }
    }
}
