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
    public partial class AddKnitter : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings["Key"]);

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        //function for adding new records
        void Add()
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

            con.Open();

            String qry = "insert into tblStaff(Address, EmailAddress, Firstname, Surname, Password, TelephoneNumber, RoleId)values('" + txtAddress.Text + "','" + txtEmailAddress.Text + "','" + txtFirstname.Text + "','" + txtSurname.Text + "','" + hashedPassword + "','" + txtTelephoneNumber.Text + "', '" + 2 + "')";

            SqlCommand cmd = new SqlCommand(qry, con);
            cmd.ExecuteNonQuery();
            Response.Write("<script type='text/javascript'>alert('You have successfully added a new staff..!');</script>");
            //Response.Redirect("homepage.aspx");
            con.Close();
            ClearInputs(Page.Controls);
        }

        protected void btnAddKnitter_Click(object sender, EventArgs e)
        {
            //add the new record
            Add();

            //Response.Write("<script type='text/javascript'>alert('You have successfully added a new knitter to the system');</script>");
        }

        private void ClearInputs(ControlCollection ctrls)
        {
            foreach (Control ctrl in ctrls)
            {
                if (ctrl is TextBox)
                    ((TextBox)ctrl).Text = string.Empty;
                else if (ctrl is DropDownList)
                    ((DropDownList)ctrl).ClearSelection();

                ClearInputs(ctrl.Controls);
            }
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("homepage.aspx");
        }
    }
}