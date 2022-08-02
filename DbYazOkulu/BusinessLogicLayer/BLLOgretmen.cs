using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityKatmani;
using DataAccessLayer;

namespace BusinessLogicLayer
{
    public class BLLOgretmen
    {
        public static List<EntityOgretmen> ogretmenListeleBLL()
        {
            return DALOgretmen.ogretmenListesi();
        }

        public static List<EntityOgretmen> oneOgretmen(int p)
        {
            return DALOgretmen.getOneOgretmen(p);
        }

        public static bool updateOgretmen(EntityOgretmen p)
        {
            if (p.Adsoyad != "" && p.Adsoyad != null && p.Brans != null)
            {
                return DALOgretmen.OgretmenGuncelle(p);
            }
            return false;
        }
    }
}
