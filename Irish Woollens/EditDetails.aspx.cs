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
    public partial class EditDetails : System.Web.UI.Page
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
                    txtPassword.Text = dr1["Password"].ToString();
                    txtEmailAddress.Text = dr1["EmailAddress"].ToString();

                }
                con.Close();
            }
        }

        protected void btnEditDetails_Click(object sender, EventArgs e)
        {
            string enterPassword;
            enterPassword = txtPassword.Text + txtEmailAddress.Text;


            // Create a new instance of the hash crypto service provider.
            HashAlgorithm hashAlg = new SHA256CryptoServiceProvider();
            // Convert the data (entered password) to hash to an array of Bytes.
            byte[] bytValue = System.Text.Encoding.UTF8.GetBytes(enterPassword);
            // Compute the Hash. This returns an array of Bytes.
            byte[] bytHash = hashAlg.ComputeHash(bytValue);
            // represent the hash value as a base64-encoded string, for security --> 
            // -->if you need to display the value or transmit it over a network.
            string hashedPassword = Convert.ToBase64String(bytHash);


            {
                con.Open();
                string uid = Session["uid"].ToString();
                String update = "update tblCustomer set Address='" + txtAddress.Text + "', Firstname='" + txtFirstname.Text + "', Surname='" + txtSurname.Text + "',  TelephoneNumber='" + txtTelephoneNumber.Text + "' , Password='" + hashedPassword + "' where CustomerID='" + uid + "'";
                SqlCommand cmd = new SqlCommand(update, con);
                cmd.ExecuteNonQuery();
                Response.Write("<script type='text/javascript'>alert('Your details have been successfully updated.');</script>");
                con.Close();
            }
        }
    }
}