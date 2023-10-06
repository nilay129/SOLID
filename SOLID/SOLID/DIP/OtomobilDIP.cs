using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.DIP
{
    public class OtomobilDIP
    {
        private List<IAracParcasi> parcalar = new List<IAracParcasi>();

        public OtomobilDIP(List<IAracParcasi> parcalar)
        {
            this.parcalar = parcalar;
        }

        public void Sur()
        {
            foreach (var parca in parcalar)
            {
                parca.Calistir();
            }
            Console.WriteLine("Otomobil sürüyor.");
        }
    }
}
