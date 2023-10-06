using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.ISP
{
    public interface IMusteriEkle
    {
        void MusteriEkle();
    }

    public interface IMusteriGuncelle
    {
        void MusteriGuncelle();
    }

    public interface IMusteriSil
    {
        void MusteriSil();
    }

    public class Musteri : IMusteriEkle, IMusteriGuncelle, IMusteriSil
    {
        public void MusteriEkle()
        {
            // Müşteri ekleme işlemi
        }

        public void MusteriGuncelle()
        {
            // Müşteri güncelleme işlemi
        }

        public void MusteriSil()
        {
            // Müşteri silme işlemi
        }
    }
}
