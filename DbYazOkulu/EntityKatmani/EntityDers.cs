using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityKatmani
{
    class EntityDers
    {
        private int dersid;
        private string dersad;
        private int min;
        private int max;

        public int Dersid { get => dersid; set => dersid = value; }
        public string Dersad { get => dersad; set => dersad = value; }
        public int Min { get => min; set => min = value; }
        public int Max { get => max; set => max = value; }
    }
}
