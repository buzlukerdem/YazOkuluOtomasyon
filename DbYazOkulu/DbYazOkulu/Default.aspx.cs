using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DataAccessLayer;
using EntityKatmani;
using BusinessLogicLayer;
public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click1(object sender, EventArgs e)
    {
        EntityOgrenci ent = new EntityOgrenci();
        ent.Ad = txtad.Text;
        ent.Soyad = txtsoyad.Text;
        ent.Numara = txtno.Text;
        ent.Fotograf = txtfoto.Text;
        ent.Sifre = txtsifre.Text;
        DALOgrenci.OgrenciEkle(ent);
    }
}