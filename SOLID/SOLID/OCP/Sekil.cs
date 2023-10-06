using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.OCP
{
    public abstract class Sekil
    {
        public abstract double AlanHesapla();
    }

    public class Dikdortgen : Sekil
    {
        public double Uzunluk { get; set; }
        public double Genislik { get; set; }

        public override double AlanHesapla()
        {
            return Uzunluk * Genislik;
        }
    }

    public class Daire : Sekil
    {
        public double YariCap { get; set; }

        public override double AlanHesapla()
        {
            return Math.PI * YariCap * YariCap;
        }
    }

}
