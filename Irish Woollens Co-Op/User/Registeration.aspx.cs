using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Registration : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings["Key"]);
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Register_Click(object sender, EventArgs e)
    {
        string enterPassword;
        enterPassword = txtPassword.Text;


        // Create a new instance of the hash crypto service provider.
        HashAlgorithm hashAlg = new SHA256CryptoServiceProvider();
        // Convert the data (entered password) to hash to an array of Bytes.
        byte[] bytValue = System.Text.Encoding.UTF8.GetBytes(enterPassword);
        // Compute the Hash. This returns an array of Bytes.
        byte[] bytHash = hashAlg.ComputeHash(bytValue);
        // represent the hash value as a base64-encoded string, for security --> 
        // -->if you need to display the value or transmit it over a network.
        string hashedPassword = Convert.ToBase64String(bytHash);

        con.Open();

        String qry = "insert into tblCustomer(Address, EmailAddress, Firstname, Surname, Password, TelephoneNumber)values('" + txtAddress.Text + "','" + txtEmailAddress.Text + "','" + txtFirstname.Text + "','" + txtSurname.Text + "','" + hashedPassword + "','" + txtTelephoneNuber.Text + "')";

        SqlCommand cmd = new SqlCommand(qry, con);
        cmd.ExecuteNonQuery();
        Response.Write("<script type='text/javascript'>alert('Successfully Registration..!');</script>");
        //Response.Redirect("register.aspx");
        con.Close();
    }
}