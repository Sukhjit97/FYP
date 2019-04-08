using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data.SqlClient;

public partial class MasterPage : System.Web.UI.MasterPage
{
    SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings["Key"]);

    protected void Page_Load(object sender, EventArgs e)
    {
       
    }

    protected void btnLogout_Click(object sender, EventArgs e)
    {
        if ((Session["Firstname"] != null) || (Session["Firstname"]!= ""))
        {
            Session["Firstname"] = null;
            Session["Firstname"] = "";
            Session.Abandon();
            Session.Clear();
            Session.RemoveAll();
            Page.Response.Cache.SetCacheability(HttpCacheability.NoCache);
            Response.Redirect("Default.aspx");
        }
    }
}
