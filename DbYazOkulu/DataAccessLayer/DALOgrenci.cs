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
    public class DALOgrenci
    {
        public static int OgrenciEkle(EntityOgrenci parametre)
        {
            SqlCommand komutekle = new SqlCommand("INSERT INTO Tbl_Ogrenciler (OgrenciAd, OgrenciSoyad, OgrenciNumara, OgrenciFoto, OgrenciSifre) values (@p1, @p2, @p3, @p4, @p5)", Baglanti.bgl);
            if (komutekle.Connection.State != ConnectionState.Open)
            {
                komutekle.Connection.Open();
            }
            komutekle.Parameters.AddWithValue("@p1", parametre.Ad);
            komutekle.Parameters.AddWithValue("@p2", parametre.Soyad);
            komutekle.Parameters.AddWithValue("@p3", parametre.Numara);
            komutekle.Parameters.AddWithValue("@p4", parametre.Fotograf);
            komutekle.Parameters.AddWithValue("@p5", parametre.Sifre);
            return komutekle.ExecuteNonQuery();
        }
        
        public static List<EntityOgrenci> OgrenciListesi()
        {
            List<EntityOgrenci> ogrenciler = new List<EntityOgrenci>();
            SqlCommand komutlistele = new SqlCommand("SELECT * FROM Tbl_Ogrenciler",Baglanti.bgl);

            if (komutlistele.Connection.State != ConnectionState.Open)
            {
                komutlistele.Connection.Open();
            }

            SqlDataReader dr = komutlistele.ExecuteReader();
            while (dr.Read())
            {
                EntityOgrenci ent = new EntityOgrenci();
                ent.Ogrid = Convert.ToInt32(dr["OgrenciID"]);
                ent.Ad = dr["OgrenciAd"].ToString();
                ent.Soyad = dr["OgrenciSoyad"].ToString();
                ent.Numara = dr["OgrenciNumara"].ToString();
                ent.Sifre = dr["OgrenciSifre"].ToString();
                ent.Fotograf = dr["OgrenciFoto"].ToString();
                ent.Bakiye = dr["OgrenciBakiye"].ToString();
                ogrenciler.Add(ent);
            }
            dr.Close();
            return ogrenciler;

        }

        public static bool OgrenciSil(int parametre)
        {
            SqlCommand komutsil = new SqlCommand("Delete from Tbl_Ogrenciler where OgrenciID=@p1", Baglanti.bgl);

            if (komutsil.Connection.State != ConnectionState.Open)
            {
                komutsil.Connection.Open();
            }
            komutsil.Parameters.AddWithValue("@p1",parametre);
            return komutsil.ExecuteNonQuery() > 0;

        }

        public static List<EntityOgrenci> OgrenciDetay(int id)
        {
            List<EntityOgrenci> ogrenciler = new List<EntityOgrenci>();
            SqlCommand komutdetay = new SqlCommand("SELECT * FROM Tbl_Ogrenciler WHERE OgrenciID=@p1", Baglanti.bgl);
            komutdetay.Parameters.AddWithValue("@p1",id);

            if (komutdetay.Connection.State != ConnectionState.Open)
            {
                komutdetay.Connection.Open();
            }

            SqlDataReader dr = komutdetay.ExecuteReader();
            while (dr.Read())
            {
                EntityOgrenci ent = new EntityOgrenci();
                ent.Ad = dr["OgrenciAd"].ToString();
                ent.Soyad = dr["OgrenciSoyad"].ToString();
                ent.Numara = dr["OgrenciNumara"].ToString();
                ent.Sifre = dr["OgrenciSifre"].ToString();
                ent.Fotograf = dr["OgrenciFoto"].ToString();
                ent.Bakiye = dr["OgrenciBakiye"].ToString();
                ogrenciler.Add(ent);
            }
            dr.Close();
            return ogrenciler;
        }

        public static bool OgrenciGuncelle(EntityOgrenci ogr)
        {
            SqlCommand komutguncelle = new SqlCommand("UPDATE Tbl_Ogrenciler SET OgrenciAd=@p1, OgrenciSoyad=@p2, OgrenciNumara=@p3, OgrenciSifre=@p4, OgrenciBakiye=@p5, OgrenciFoto=@p6 where OgrenciID=@p7", Baglanti.bgl);

            if (komutguncelle.Connection.State != ConnectionState.Open)
            {
                komutguncelle.Connection.Open();
            }
            komutguncelle.Parameters.AddWithValue("@p1", ogr.Ad);
            komutguncelle.Parameters.AddWithValue("@p2", ogr.Soyad);
            komutguncelle.Parameters.AddWithValue("@p3", ogr.Numara);
            komutguncelle.Parameters.AddWithValue("@p4", ogr.Sifre);
            komutguncelle.Parameters.AddWithValue("@p5", ogr.Bakiye);
            komutguncelle.Parameters.AddWithValue("@p6", ogr.Fotograf);
            komutguncelle.Parameters.AddWithValue("@p7", ogr.Ogrid);
            return komutguncelle.ExecuteNonQuery() > 0;

        }
    }
}
