using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Knitter_Quatation : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings["Key"]);

    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        con.Open();

        String qry = "insert into tblQuatation(knittername, productname, productid, quatation)values('" + txtname.Text + "','" + txtProductName.Text + "','" + txtProductId.Text + "','" + txtQuatation.Text + "')";

        SqlCommand cmd = new SqlCommand(qry, con);
        cmd.ExecuteNonQuery();
        Response.Write("<script type='text/javascript'>alert('Thank you for your Quatation..!');</script>");
        //Response.Redirect("register.aspx");
        con.Close();
    }
}