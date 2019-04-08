using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Manager_Default : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings["Key"]);

    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Login_Click(object sender, EventArgs e)
    {
        string enteredPassword = txtPassword.Text;

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
        string qry = "select * from tblManager where EmailAddress='" + txtEmailAddress.Text + "' and Password='" + hashedPassword + "'";
        SqlCommand cmd = new SqlCommand(qry, con);
        SqlDataReader dr = cmd.ExecuteReader();
        if (dr.Read())
        {

            Response.Redirect("Registration.aspx");

        }
        else
        {
            Response.Write("<script type='text/javascript'>alert('Invalid Email Address or Password..!');</script>");
        }

        con.Close();
    }
}