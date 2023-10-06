using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.LSP
{
    public class Hayvan
    {
        public virtual void Beslen()
        {
            Console.WriteLine("Hayvan besleniyor.");
        }
    }

    public class Kus : Hayvan
    {
        public override void Beslen()
        {
            Console.WriteLine("Kuş tohum yer.");
        }

        public void Uç()
        {
            Console.WriteLine("Kuş uçuyor.");
        }
    }

    public class Balik : Hayvan
    {
        public override void Beslen()
        {
            Console.WriteLine("Balık plankton yer.");
        }

        public void Yüz()
        {
            Console.WriteLine("Balık yüzüyor.");
        }
    }
}
