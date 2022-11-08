using DIP.Loglama.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP.Loglama.Concrete
{
    public class DbLogger : ILogger
    {
        public void Logla(string message)
        {
            Console.WriteLine("database Yazildi:"+message);
        }
    }
}
