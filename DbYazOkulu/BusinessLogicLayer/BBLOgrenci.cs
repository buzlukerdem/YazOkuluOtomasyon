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
    }
}
