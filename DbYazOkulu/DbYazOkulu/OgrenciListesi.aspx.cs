using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntityKatmani;
using DataAccessLayer;
using BusinessLogicLayer;

public partial class OgrenciListesi : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        // sayfa yüklendiginde ogrenci listesini gormek istiyoruz.
        List<EntityOgrenci> ogrList = BBLOgrenci.OgrenciListeleBBL();
        Repeater1.DataSource = ogrList;
        Repeater1.DataBind();
    }
}