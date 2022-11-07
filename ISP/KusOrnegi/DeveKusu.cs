
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISP.KusOrnegi
{
    public class DeveKusu : IKus
    {
        public void Kos()
        {
            Console.WriteLine("DeveKusu Kostu.");

        }

        public void Uc()
        {
            throw new NotImplementedException();
        }

        public void Yuru()
        {
            Console.WriteLine("DeveKusu Yurudu.");
        }

        public void Yuz()
        {
            throw new NotImplementedException();
        }
    }
}
