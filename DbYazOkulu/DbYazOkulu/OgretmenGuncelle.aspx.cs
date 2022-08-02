using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntityKatmani;
using DataAccessLayer;
using BusinessLogicLayer;
public partial class OgretmenGuncelle : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        int x = Convert.ToInt32(Request.QueryString["OgretmenID"]);
        txtid.Enabled = false;
        txtid.Text = x.ToString();

        if (Page.IsPostBack == false)
        {
            List<EntityOgretmen> getOneOgretmen = BLLOgretmen.oneOgretmen(x);
            txtadsoyad.Text = getOneOgretmen[0].Adsoyad.ToString();
            txtbrans.Text = getOneOgretmen[0].Brans.ToString();
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        EntityOgretmen ento = new EntityOgretmen();
        ento.Ogrtid = Convert.ToInt32(txtid.Text);
        ento.Adsoyad = txtadsoyad.Text;
        ento.Brans = Convert.ToInt32(txtbrans.Text);
        BLLOgretmen.updateOgretmen(ento);
        Response.Redirect("OgretmenListesi.aspx");
    }
}