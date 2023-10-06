using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.SRP
{
    public class Musteri
    {
        private string ad;
        private string soyad;
        private string telefonNumarasi;

        public Musteri(string ad, string soyad, string telefonNumarasi)
        {
            this.ad = ad;
            this.soyad = soyad;
            this.telefonNumarasi = telefonNumarasi;
        }

        public string AdAl()
        {
            return ad;
        }

        public string SoyadAl()
        {
            return soyad;
        }

        public string TelefonNumarasiAl()
        {
            return telefonNumarasi;
        }

        public void BilgileriGoster()
        {
            Console.WriteLine($"Ad: {ad}, Soyad: {soyad}, Telefon Numarası: {telefonNumarasi}");
        }

        public void BilgileriKaydet()
        {
            // Müşteri bilgilerini veritabanına kaydetme işlemi
            // Bu işlem, bu sınıfın sorumluluğuna dahil edilmemelidir.
        }
    }

}
