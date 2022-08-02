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
    public class DALDers
    {
        public static List<EntityDers> DersListesi()
        {
            List<EntityDers> dersler = new List<EntityDers>();
            SqlCommand komutlistele = new SqlCommand("SELECT * FROM Tbl_Dersler", Baglanti.bgl);

            if (komutlistele.Connection.State != ConnectionState.Open)
            {
                komutlistele.Connection.Open();
            }

            SqlDataReader dr = komutlistele.ExecuteReader();
            while (dr.Read())
            {
                EntityDers entd = new EntityDers();
                entd.Dersid = Convert.ToInt32(dr["DersID"]);
                entd.Dersad = dr["DersAd"].ToString();
                entd.Min = int.Parse(dr["DersMinKontenjan"].ToString());
                entd.Max = int.Parse(dr["DersMaxKontenjan"].ToString());
                dersler.Add(entd);
            }
            dr.Close();
            return dersler;

        }

        public static int BasvuruEkle(Basvurular parametre)
        {
            SqlCommand basvuruekle = new SqlCommand("INSERT INTO Tbl_Basvurular (OgrenciID, DersID) values (@p1, @p2)",Baglanti.bgl);
            basvuruekle.Parameters.AddWithValue("@p1",parametre.Basvuruogrid);
            basvuruekle.Parameters.AddWithValue("@p2",parametre.Basvurudersid);
            if (basvuruekle.Connection.State != ConnectionState.Open)
            {
                basvuruekle.Connection.Open();
            }
            return basvuruekle.ExecuteNonQuery();
        }
    }
}
