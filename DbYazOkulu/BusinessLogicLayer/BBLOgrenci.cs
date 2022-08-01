using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityKatmani;
using DataAccessLayer;

namespace BusinessLogicLayer
{
    public class BBLOgrenci
    {
        public static int OgrenciEkleBLL(EntityOgrenci p)
        {
            if(p.Ad != null && p.Soyad != null && p.Numara != null && p.Fotograf != null && p.Sifre != null)
            {
                return DALOgrenci.OgrenciEkle(p);
            }
            return -1;
        }
        public static List<EntityOgrenci> OgrenciListeleBBL()
        {
            return DALOgrenci.OgrenciListesi();
        }

        public static bool OgrenciSilBLL(int p)
        {
            if (p > 0)
            {
                return DALOgrenci.OgrenciSil(p);
            }
            return false;
        }

        public static List<EntityOgrenci> DetayBLL(int p)
        {
            return DALOgrenci.OgrenciDetay(p);
        }

        public static bool OgrenciGuncelleBLL(EntityOgrenci p)
        {
            if (p.Ad != "" && p.Ad != null && p.Soyad != null && p.Numara != null && p.Fotograf != null && p.Sifre != null && p.Bakiye != null && p.Ogrid>0)
            {
                return DALOgrenci.OgrenciGuncelle(p);
            }
            return false;
        }
    }
}
