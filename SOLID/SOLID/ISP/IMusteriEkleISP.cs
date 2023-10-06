using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.ISP
{
    public interface IMusteriEkleISP
    {
        void MusteriEkle();
    }

    public interface IMusteriGuncelleISP
    {
        void MusteriGuncelle();
    }

    public interface IMusteriSilISP
    {
        void MusteriSil();
    }
}
