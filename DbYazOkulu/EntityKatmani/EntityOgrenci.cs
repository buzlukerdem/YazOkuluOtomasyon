using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityKatmani
{
    public class EntityOgrenci
    {
        private int ogrid;
        private string ad;
        private string soyad;
        private string numara;
        private string fotograf;
        private string sifre;
        private string bakiye;

        public int Ogrid { get => ogrid; set => ogrid = value; }
        public string Ad { get => ad; set => ad = value; }
        public string Soyad { get => soyad; set => soyad = value; }
        public string Numara { get => numara; set => numara = value; }
        public string Sifre { get => sifre; set => sifre = value; }
        public string Fotograf { get => fotograf; set => fotograf = value; }
        public string Bakiye { get => bakiye; set => bakiye = value; }
    }
}
