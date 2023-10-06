using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.DIP
{
    internal class TekerlekDIP: IAracParcasi
    {
        public void Calistir()
        {
            Console.WriteLine("Tekerlekler hareket ediyor.");
        }
    }
}
