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
    }
}
