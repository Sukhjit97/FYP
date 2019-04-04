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

    protected void btnLogin_Click(object sender, EventArgs e)
    {
        //redirect to the login page
        Response.Redirect("Default.aspx");
       
    }

    protected void btnRegister_Click(object sender, EventArgs e)
    {
        //redirect to the registeration page
        Response.Redirect("Registeration.aspx");
    }

    protected void btnLogout_Click(object sender, EventArgs e)
    {


        Response.Redirect("Logout.aspx");
    }
}
