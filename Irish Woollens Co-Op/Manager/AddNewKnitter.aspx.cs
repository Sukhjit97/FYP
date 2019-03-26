using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class Manager_AddNewKnitter : System.Web.UI.Page
{
    //event handler for the register button
    protected void btnRegister_Click(object sender, EventArgs e)
    {
        //add the new record
        Add();
        //all done so redirect back to the main page
        Response.Redirect("Homepage.aspx");

    }

    //function for adding new records
    void Add()
    {
        //create an instance of the Customer Details
        clsStaffCollection StaffDetails = new clsStaffCollection();
        //validate the data on the web form
        String Error = StaffDetails.ThisStaff.Valid(txtAddress.Text, txtEmailAddress.Text, txtFirstname.Text, txtSurname.Text, txtPassword.Text, txtTelephoneNumber.Text);
        //if the data is OK then add it to the object
        if (Error == "")
        {
            //get the data entered by the user
            StaffDetails.ThisStaff.Address = txtAddress.Text;
            StaffDetails.ThisStaff.EmailAddress = txtEmailAddress.Text;
            StaffDetails.ThisStaff.Firstname = txtFirstname.Text;
            StaffDetails.ThisStaff.Surname = txtSurname.Text;
            StaffDetails.ThisStaff.Password = txtPassword.Text;
            StaffDetails.ThisStaff.TelephoneNumber = txtTelephoneNumber.Text;
            //Add the record
            StaffDetails.Add();
        }
        else
        {
            //report an error
            lblError.Text = "There were problems with the data entered";
        }
    }

    //event handler for the register button
    protected void btnRegister_Click1(object sender, EventArgs e)
    {
        //add the new record
        Add();

        Response.Write("<script type='text/javascript'>alert('You have successfully added a new knitter to the system');</script>");


    }
}


