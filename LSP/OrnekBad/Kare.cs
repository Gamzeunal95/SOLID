using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP.OrnekBad
{
    internal class Kare : Dikdortgen      // Bu şekilde yaparak hem solıd prensiplerine uymamıs oluyoruz , diktorgenden kareye kalıtım alarak kareye ihtiyacı olmayan propları almış da oluyoruz. 
    {                                       // Kalıtım aldığımız yerdeki proplar bu class için fazla yani işine yaramayan proplar...
        int _KisaKenar;
        int _UzunKenar;


        public override int KisaKenar
        {
            get
            {
                return _KisaKenar;
            }
            set
            {
                _KisaKenar = value;
                _UzunKenar = value;
            }
        }
        public override int UzunKenar
        {
            get
            {
                return _UzunKenar;
            }
            set
            {
                _KisaKenar = value;
                _UzunKenar = value;
            }
        }
    }
}
