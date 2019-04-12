using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Irish_Woollens
{
    public partial class login_staff : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings["Key"]);

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void buttonLogin_Click(object sender, EventArgs e)
        {
            string enteredPassword = txtPassword.Text + txtEmailAddress.Text;

            // Create a new instance of the hash crypto service provider.
            HashAlgorithm hashAlg = new SHA256CryptoServiceProvider();
            // Convert the data to hash to an array of Bytes.
            byte[] bytValue = System.Text.Encoding.UTF8.GetBytes(enteredPassword);
            // Compute the Hash. This returns an array of Bytes.
            byte[] bytHash = hashAlg.ComputeHash(bytValue);
            // Optionally, represent the hash value as a base64-encoded string, 
            // For example, if you need to display the value or transmit it over a network.
            string hashedPassword = Convert.ToBase64String(bytHash);




            con.Open();
            string qry = "select * from tblStaff where EmailAddress='" + txtEmailAddress.Text + "' and Password='" + hashedPassword + "'";
            SqlCommand cmd = new SqlCommand(qry, con);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                Session["EmailAddress"] = dr["EmailAddress"].ToString();
                Session["StaffID"] = dr["StaffID"].ToString();
                Session["Firstname"] = dr["Firstname"].ToString();
                Session["uid"] = dr["StaffID"].ToString();
                Session["RoleId"] = dr["RoleId"].ToString();

                Response.Redirect("Homepage.aspx");

            }
            else
            {
                Response.Write("<script type='text/javascript'>alert('You have entered an invalid Email Address or Password');</script>");
            }

            con.Close();
        }
    }
}