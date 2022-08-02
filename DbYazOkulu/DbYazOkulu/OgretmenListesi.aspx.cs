using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntityKatmani;
using DataAccessLayer;
using BusinessLogicLayer;
public partial class OgretmenListesi : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        List<EntityOgretmen> ogrtList = BLLOgretmen.ogretmenListeleBLL();
        Repeater1.DataSource = ogrtList;
        Repeater1.DataBind();
    }
}