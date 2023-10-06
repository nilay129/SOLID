using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.DIP
{
    public class Otomobil
    {
        private Motor motor;
        private Tekerlek tekerlek;

        public Otomobil()
        {
            this.motor = new Motor();
            this.tekerlek = new Tekerlek();
        }

        public void Sur()
        {
            motor.Calistir();
            tekerlek.HareketEt();
            Console.WriteLine("Otomobil sürüyor.");
        }
    }
}
