using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class User_EditDetails : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings["Key"]);
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["Firstname"] != null)
        {
            if (!IsPostBack)
            {
                userdisplay();

            }
        }
        else
        {
            Response.Redirect("Default.aspx");
        }
    }


    void userdisplay()
    {
        con.Open();
        string uid = Session["uid"].ToString();
        String qry1 = "select * from tblCustomer where CustomerID='" + uid + "' ";
        SqlCommand cmd1 = new SqlCommand(qry1, con);
        SqlDataReader dr1;
        dr1 = cmd1.ExecuteReader();
        if (dr1.Read())
        {
            txtAddress.Text = dr1["Address"].ToString();
            txtFirstname.Text = dr1["Firstname"].ToString();
            txtSurname.Text = dr1["Surname"].ToString();         
            txtTelephoneNumber.Text = dr1["TelephoneNumber"].ToString();
        }
        con.Close();
    }

    protected void btnUpdate_Click1(object sender, EventArgs e)
    {
        {
            con.Open();
            string uid = Session["uid"].ToString();
            String update = "update tblCustomer set Address='" + txtAddress.Text + "', Firstname='" + txtFirstname.Text + "', Surname='" + txtSurname.Text + "', TelephoneNumber='" + txtTelephoneNumber.Text + "'where CustomerID='" + uid + "'";
            SqlCommand cmd = new SqlCommand(update, con);
            cmd.ExecuteNonQuery();
            Response.Write("<script type='text/javascript'>alert('Your details have been successfully updated.');</script>");
            con.Close();
        }
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("Homepage.aspx");
    }
}