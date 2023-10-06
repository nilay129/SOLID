using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.DIP
{
    internal class MotorDIP: IAracParcasi
    {
        public void Calistir()
        {
            Console.WriteLine("Motor çalıştı.");
        }
    }
}
