using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISP.KusOrnegi
{
    public class Tavuk : IKus
    {
        public void Kos()
        {
            Console.WriteLine("Tavuk Kostu.");
        }

        public void Uc()
        {
            throw new NotImplementedException();
        }

        public void Yuru()
        {
            Console.WriteLine("Tavuk Yurudu.");

        }

        public void Yuz()
        {
            throw new NotImplementedException();
        }
    }
}
