using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityKatmani
{
    public class EntityOgretmen
    {
        private int ogrtid;
        private string adsoyad;
        private int brans;

        public int Ogrtid { get => ogrtid; set => ogrtid = value; }
        public string Adsoyad { get => adsoyad; set => adsoyad = value; }
        public int Brans { get => brans; set => brans = value; }
    }
}
