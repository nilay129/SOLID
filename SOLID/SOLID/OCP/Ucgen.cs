using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.OCP
{
    public class Ucgen : Sekil
    {
        public double Taban { get; set; }
        public double Yukseklik { get; set; }

        public override double AlanHesapla()
        {
            return (Taban * Yukseklik) / 2;
        }
    }

}
