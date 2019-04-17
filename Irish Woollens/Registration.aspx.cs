using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

namespace Irish_Woollens
{
    public partial class Registeration : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings["Key"]);

        protected void Page_Load(object sender, EventArgs e)
        {
            //ClearTextBoxes(Page);

        }

        void Add()
        {

            clsCustomerCollection CustomerList = new clsCustomerCollection();
            String Error = CustomerList.ThisCustomer.Valid(txtAddress.Text,
                                                           txtEmailAddress.Text,
                                                           txtFirstname.Text,
                                                           txtSurname.Text,
                                                           txtPassword.Text,
                                                           txtTelephoneNumber.Text,
                                                           txtRole.Text);

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

            if (Error == "")
            {
                CustomerList.ThisCustomer.Firstname = txtFirstname.Text;
                CustomerList.ThisCustomer.Surname = txtSurname.Text;
                CustomerList.ThisCustomer.Address = txtAddress.Text;
                CustomerList.ThisCustomer.EmailAddress = txtEmailAddress.Text;
                CustomerList.ThisCustomer.Password = hashedPassword;
                CustomerList.ThisCustomer.TelephoneNumber = txtTelephoneNumber.Text;
                CustomerList.ThisCustomer.RoleId = 3;

                //Add the record
                CustomerList.Add();
                lblError.Text = "You have registered successfully";
            }
            else
            {
                //report
                lblError.Text = "There were problem(s) with the data you entered: " + Error;

            }
        }

        protected void Register_Click(object sender, EventArgs e)
        {
            //add the user
            Add();
            //Response.Redirect("homepage.aspx");


            //javascript message to show to the customer when they have registered successfully 
            //Response.Write("<script type='text/javascript'>alert('successfully added a new user..!');</script>");
            
        }

        //protected void ClearTextBoxes(Control p1)
        //{
        //    foreach (Control ctrl in p1.Controls)
        //    {
        //        if (ctrl is TextBox)
        //        {
        //            TextBox t = ctrl as TextBox;

        //            if (t != null)
        //            {
        //                t.Text = String.Empty;
        //            }
        //        }
        //        else
        //        {
        //            if (ctrl.Controls.Count > 0)
        //            {
        //                ClearTextBoxes(ctrl);
        //            }
        //        }
        //    }
        //}
    }
}
