using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using EntityKatmani;

namespace DataAccessLayer
{
    public class DALOgretmen
    {   
        // LİSTELEME
        public static List<EntityOgretmen> ogretmenListesi()
        {

            List<EntityOgretmen> ogretmenler = new List<EntityOgretmen>();
            SqlCommand komutlistele = new SqlCommand("SELECT * FROM Tbl_Ogretmenler",Baglanti.bgl);
            if(komutlistele.Connection.State != ConnectionState.Open)
            {
                komutlistele.Connection.Open();
            }
            // okuma islemi
            SqlDataReader dr = komutlistele.ExecuteReader();
            while (dr.Read())
            {
                EntityOgretmen ento = new EntityOgretmen();
                ento.Ogrtid = Convert.ToInt32(dr["OgretmenID"]);
                ento.Adsoyad = dr["OgretmenAdSoyad"].ToString();
                ento.Brans = Convert.ToInt32(dr["OgretmenBrans"]);
                ogretmenler.Add(ento);
            }
            dr.Close();
            return ogretmenler;
        }

        public static List<EntityOgretmen> getOneOgretmen(int id)
        {
            List<EntityOgretmen> ogretmen = new List<EntityOgretmen>();
            SqlCommand komutgetir = new SqlCommand("SELECT * FROM Tbl_Ogretmenler WHERE OgretmenID=@p1", Baglanti.bgl);
            komutgetir.Parameters.AddWithValue("@p1", id);
            if (komutgetir.Connection.State != ConnectionState.Open)
            {
                komutgetir.Connection.Open();
            }
            SqlDataReader dr = komutgetir.ExecuteReader();
            while (dr.Read())
            {
                EntityOgretmen ento = new EntityOgretmen();
                ento.Ogrtid = Convert.ToInt32(dr["OgretmenID"]);
                ento.Adsoyad = dr["OgretmenAdSoyad"].ToString();
                ento.Brans = Convert.ToInt32(dr["OgretmenBrans"]);
                ogretmen.Add(ento);
            }
            dr.Close();
            return ogretmen;

        }

        public static bool OgretmenGuncelle(EntityOgretmen ogrt)
        {
            SqlCommand komutguncelle = new SqlCommand("UPDATE Tbl_Ogretmenler SET OgretmenAdSoyad=@p1, OgretmenBrans=@p2 WHERE OgretmenID=@p3",Baglanti.bgl);
            if (komutguncelle.Connection.State != ConnectionState.Open)
            {
                komutguncelle.Connection.Open();
            }
            komutguncelle.Parameters.AddWithValue("@p1", ogrt.Adsoyad);
            komutguncelle.Parameters.AddWithValue("@p2", ogrt.Brans);
            komutguncelle.Parameters.AddWithValue("@p3", ogrt.Ogrtid);
            return komutguncelle.ExecuteNonQuery() > 0;
        }
    }
}
