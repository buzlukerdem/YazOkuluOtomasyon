using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityKatmani;
using DataAccessLayer;

namespace BusinessLogicLayer
{
    public class BLLDers
    {
        public static List<EntityDers> DersListeleBLL()
        {
            return DALDers.DersListesi();
        }

         public static int BasvuruEkle(Basvurular p)
        {
            if(p.Basvurudersid != null && p.Basvurudersid > 0 && p.Basvuruogrid != null && p.Basvuruogrid > 0  )
            {
                return DALDers.BasvuruEkle(p);
            }
            return -1;
        }
    }
}
