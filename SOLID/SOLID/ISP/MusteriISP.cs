namespace SOLID.ISP
{
    public class MusteriISP : IMusteriEkleISP
    {
        public void MusteriEkle()
        {
            // Müşteri ekleme işlemi
        }
    }

    public class DigerMusteri : IMusteriGuncelleISP, IMusteriSilISP
    {
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