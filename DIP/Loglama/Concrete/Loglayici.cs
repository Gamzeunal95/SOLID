using DIP.Loglama.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP.Loglama.Concrete
{
    public class Loglayici
    {

        public void Logla(ILogger logger, string message) 
        { 
            logger.Logla(message);
        
        }
    }
}
