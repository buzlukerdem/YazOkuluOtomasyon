using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntityKatmani;
using DataAccessLayer;
using BusinessLogicLayer;

public partial class OgrenciSil : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        int x = Convert.ToInt32(Request.QueryString["OgrenciID"]);
        EntityOgrenci ent = new EntityOgrenci();
        ent.Ogrid = x;
        BBLOgrenci.OgrenciSilBLL(ent.Ogrid);
        Response.Redirect("OgrenciListesi.aspx");
    }
}