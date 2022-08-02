using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntityKatmani;
using DataAccessLayer;
using BusinessLogicLayer;

public partial class DersListesi : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if(Page.IsPostBack == false)
        {
            DropDownList1.DataSource = BLLDers.DersListeleBLL();
            DropDownList1.DataTextField = "Dersad";
            DropDownList1.DataValueField = "Dersid";
            DropDownList1.DataBind();
        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        Basvurular bas = new Basvurular();
        bas.Basvurudersid = int.Parse(DropDownList1.SelectedValue.ToString());
        bas.Basvuruogrid = int.Parse(TextBox1.Text);
        BLLDers.BasvuruEkle(bas);

    }
}