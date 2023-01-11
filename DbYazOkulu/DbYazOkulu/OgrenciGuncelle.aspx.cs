using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DataAccessLayer;
using EntityKatmani;
using BusinessLogicLayer;

public partial class OgrenciGuncelle : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        int x = Convert.ToInt32(Request.QueryString["OgrenciID"]);
        txtid.Enabled = false;
        txtid.Text = x.ToString();

        if(Page.IsPostBack == false)
        {
            List<EntityOgrenci> oneOgrenci = BBLOgrenci.DetayBLL(x);
            txtad.Text = oneOgrenci[0].Ad.ToString();
            txtsoyad.Text = oneOgrenci[0].Soyad.ToString();
            txtno.Text = oneOgrenci[0].Numara.ToString();
            txtsifre.Text = oneOgrenci[0].Sifre.ToString();
            txtbakiye.Text = oneOgrenci[0].Bakiye.ToString();
            txtfoto.Text = oneOgrenci[0].Fotograf.ToString();
        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        #region OgrenciGuncellemeEntity
        EntityOgrenci ent = new EntityOgrenci();
        ent.Ogrid = Convert.ToInt32(txtid.Text);
        ent.Ad = txtad.Text;
        ent.Soyad = txtsoyad.Text;
        ent.Numara = txtno.Text;
        ent.Sifre = txtsifre.Text;
        ent.Bakiye = txtbakiye.Text;
        ent.Fotograf = txtfoto.Text;
        BBLOgrenci.OgrenciGuncelleBLL(ent);
        Response.Redirect("OgrenciListesi.aspx"); 
        #endregion
    }
}