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

    protected void btnRequestChange_Click(object sender, EventArgs e)
    {
        con.Open();

        String qry = "insert into tblQuotation(Firstname, ItemID, ItemName, Quotation)values('" + txtFirstname.Text + "','" + txtItemID.Text + "','" + txtItemName.Text + "','" + txtQuotation.Text + "')";

        SqlCommand cmd = new SqlCommand(qry, con);
        cmd.ExecuteNonQuery();
        Response.Write("<script type='text/javascript'>alert('Thank you for your Quotation. We will take this into consideration.');</script>");
        //Response.Redirect("register.aspx");
        con.Close();
    }
}