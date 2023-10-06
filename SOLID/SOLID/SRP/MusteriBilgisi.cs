using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.SRP
{
    public class MusteriBilgisi
    {
        private string ad;
        private string soyad;
        private string telefonNumarasi;

        public MusteriBilgisi(string ad, string soyad, string telefonNumarasi)
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
    }

}
